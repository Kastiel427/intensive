using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Task5
{
    public class TaskController : ApiController
    {
        IntensiveContext db = new IntensiveContext();

        public IEnumerable<GroupedModel> GetGrouped()
        {
            var groupModel = from p in db.Projects
                             join t in db.Tasks on p.ProjectId equals t.ProjectId
                             group p by new
                             {
                                 p.ProjectName,
                                 t.DeadLine
                             }
                             into grouping
                             select new GroupedModel
                             {
                                 ProjectName = grouping.Key.ProjectName,
                                 DeadLine = grouping.Key.DeadLine,
                                 CountTasks = grouping.Count()
                             };

            return groupModel;
        }

        [Route("Show")]
        public IEnumerable<Task> GetTasks()
        {
            return db.Tasks;
        }

        public int Post(Task task)
        {
            db.Tasks.Add(task);
            db.SaveChanges();

            return db.Tasks.SingleOrDefault(t => t.TaskName == task.TaskName).TaskId;
        }

       [Route("edit/{id}")]
        public void Put(int id, [FromBody]Task task)
        {
            Task sTast = db.Tasks.Find(id);

            if (sTast != null)
            {
                sTast.ProjectId = task.ProjectId;
                sTast.TaskName = task.TaskName;
                sTast.Specification = task.Specification;
                sTast.Closed = task.Closed;
                sTast.DeadLine = task.DeadLine;

                db.SaveChanges();
            }
        }
    }

    public class GroupedModel
    {
        public string ProjectName { get; set; }

        public string DeadLine { get; set; }

        public int CountTasks { get; set; }
    }
}
