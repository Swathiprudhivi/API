using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnApiDemo2.Models;
namespace HandsOnApiDemo2.Repositories
{
    public class EmployeeRepository
    {
        //Get all employee
        public List<Employee> GetAll()
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                return db.Employee.ToList();
            }
        }
        //Get Employee By Id
        public Employee GetById(string eid)
        {
            using(EMSDBContext db=new EMSDBContext())
            {
                return db.Employee.Find(eid);
            }
        }
        //Add Employee
        public void Add(Employee item)
        {
            using(EMSDBContext db=new EMSDBContext())
            {
                db.Employee.Add(item);
                db.SaveChanges();
            }
        }
        //Delete record
        public void Delete(string eid)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                Employee e = db.Employee.Find(eid);
                db.Employee.Remove(e);
                db.SaveChanges();
            }
        }
        public void Update(Employee item)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                db.Employee.Update(item);
                db.SaveChanges();
            }
        }
    }
}
