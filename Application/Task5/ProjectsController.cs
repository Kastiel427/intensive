using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Task5
{
    public class ProjectsController : ApiController
    {
        IntensiveContext db = new IntensiveContext();

        public async Task<IEnumerable<AsyncModel>> Get()
        {
            var queryProject = await db.Projects.ToListAsync();
            var queryTask = await db.Tasks.ToListAsync();

            var joinProjectTask = from p in queryProject
                                  join t in queryTask on p.ProjectId equals t.ProjectId
                                  select new AsyncModel
                                  {
                                      ProjectId = p.ProjectId,
                                      ProjectName = p.ProjectName,
                                      TaskId = t.TaskId,
                                      TaskName = t.TaskName,
                                      Specification = t.Specification,
                                      Closed = t.Closed,
                                      DeadLine = t.DeadLine
                                  };

            return joinProjectTask;
        }

        [Route("Simple")]
        public IEnumerable<SimpleModel> GetSimple()
        {
            var query = from p in db.Projects
                    join t in db.Tasks on p.ProjectId equals t.ProjectId
                    group p by p.ProjectName into g
                    select new SimpleModel { ProjectName = g.Key, CountTasks = g.Count() };
                    

            return query;
        }

        public void Post(Project project)
        {
            db.Projects.Add(project);
            db.SaveChanges();
        }
    }

    public class AsyncModel
    {
        public int ProjectId { get; set; }
        
        public string ProjectName { get; set; }

        public int TaskId { get; set; }

        public string TaskName { get; set; }

        public string Specification { get; set; }

        public bool Closed { get; set; }

        public string DeadLine { get; set; }
    }

    public class SimpleModel
    {
        public string ProjectName { get; set; }

        public int CountTasks { get; set; }
    }
}
