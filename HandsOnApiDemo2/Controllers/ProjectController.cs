using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnApiDemo2.Models;
using HandsOnApiDemo2.Repositories;
namespace HandsOnApiDemo2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        ProjectRepository repository = new ProjectRepository();
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(repository.GetAll());
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(repository.GetById(id));
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Project item)
        {
            repository.Add(item);
            return Ok();
        }
        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Project item)
        {
            repository.Update(item);
            return Ok("Record updated");
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok("Record deleted");
        }
    }
}