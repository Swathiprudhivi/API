﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIDEMO.Models;
namespace APIDEMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        PracticeDBContext db = new PracticeDBContext();
        [HttpGet]
        public List<Project> GetAll()
        {
            return db.Project.ToList();
        }
       [HttpGet("{id}")]
       [Route("GetById/{id}")]
       public Project GetById(string id)
        {
            return db.Project.Find(id);
        }
        [HttpGet("{name}")]
        [Route("GetByName/{name}")]
        public Project GetByName(string name)
        {
            return db.Project.SingleOrDefault(p => p.Pname == name);
        }
        [HttpPost]
        [Route("AddProject")]
        public void Add(Project item)
        {
            db.Project.Add(item);
            db.SaveChanges();
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public void Delete(string id)
        {
            Project p = db.Project.Find(id);
            db.Remove(p);
            db.SaveChanges();
        }
        [HttpPut]
        [Route("Update/{id}")]
        public void Update(string id)
        {
            Project p = db. Project.Find(id);
            p.Sdate = DateTime.Now;
            db.Project.Update(p);
            db.SaveChanges();
        }
    }
}