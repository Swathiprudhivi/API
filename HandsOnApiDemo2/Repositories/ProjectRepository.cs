using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnApiDemo2.Models;
namespace HandsOnApiDemo2.Repositories
{
    public class ProjectRepository
    {
        //Get all projects
        public List<Project> GetAll()
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                return db.Project.ToList();
            }
        }
        //Get project By Id
        public Project GetById(int pid)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                return db.Project.Find(pid);
            }
        }
        //Add project
        public void Add(Project item)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                db.Project.Add(item);
                db.SaveChanges();
            }
        }
        //Delete record
        public void Delete(int eid)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                Project e = db.Project.Find(eid);
                db.Project.Remove(e);
                db.SaveChanges();
            }
        }
        public void Update(Project item)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                db.Project.Update(item);
                db.SaveChanges();
            }
        }
    }
}
