using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Filters;
using Task3_2;

namespace Taks1
{
   // [WebApiException]
    [HeaderID]
    [RoutePrefix("api/application")]
    public class TasksController : ApiController
    {

        [Route("tasks")]
        public IEnumerable<Tasks> Get()
        {            
            return Program.tasks;
        }

        [Route("~/api/application/tasks/{id}")]
        public Tasks Get(int id)
        {
            var taks = Program.tasks.Where(s => s.TaksID == id).FirstOrDefault();
            return taks;
        }

        [Route("tasks")]
        public IHttpActionResult Post([FromBody]Tasks task)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            Program.tasks.Add(task);
            Console.WriteLine("Добавлена задача с именем " + task.TaskName);

            return Ok();
        }

        [Route("~/api/application/tasks/{id}")]
        public void Put(int id,[FromBody]Tasks task)
        {
            var editTask = Program.tasks.Where(s => s.TaksID == id).FirstOrDefault();
            if (editTask != null)
            {
                editTask.TaskName = task.TaskName;
                editTask.DeadLine = task.DeadLine;
                Console.WriteLine("Задача с именем " + task.TaskName + " изменена");
            }
            else
                Console.WriteLine("Задача не найдена. Изменение не выполнено");
        }

        [Route("~/api/application/tasks/{id}")]
        public void Delete(int id)
        {
            var taks = Program.tasks.Where(s => s.TaksID == id).FirstOrDefault();
            //if (taks != null)
           // {
                Program.tasks.Remove(taks);
                Console.WriteLine("Задача с именем " + taks.TaskName + " удалена");
           // }
            //else
             //   Console.WriteLine("Задача не найдена. Удаление не выполнено");
        }
    }

    public class HeaderID : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            Random random = new Random();
            int id = random.Next(0, Program.tasks.Count);
            if (actionExecutedContext.Exception != null)
            {
                actionExecutedContext.Response = actionExecutedContext.Request.CreateErrorResponse(
                                HttpStatusCode.BadRequest, actionExecutedContext.Exception.Message);
                Console.WriteLine("Web Api : " + actionExecutedContext.Exception.Message);

            }
            else
                actionExecutedContext.Response.Headers.Add("X-TEST-ID", id.ToString());
        }
    }

    //public class WebApiException : Attribute, IExceptionFilter
    //{
    //    public Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
    //    {
    //        if (actionExecutedContext.Exception != null )
    //        {
    //            Console.WriteLine("Web Api : " + actionExecutedContext.Exception.Message);
    //        }
    //        return Task.FromResult<object>(null);
    //    }
    //    public bool AllowMultiple
    //    {
    //        get { return true; }
    //    }
    //}
}
