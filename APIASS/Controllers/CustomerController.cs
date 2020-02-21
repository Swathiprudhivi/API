using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIASS.Models;

namespace APIASS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerDBContext db = new CustomerDBContext();
        // GET: api/Customer
        [HttpGet]
        [Route("GetAll")]
        public List<Customer> GetAllCustomer()
        {
            return db.Customer.ToList();
        }
        [HttpGet("{Id}")]
        [Route("GetCustomerId/{Id}")]
       public Customer GetCustomerId(string id)
        {
            return db.Customer.Find(id);
        }
        [HttpGet("{city}")]
        [Route("GetByCity/{city}")]
        public List <Customer> GetByCity(string city)
        {
            return db.Customer.Where(e => e.City == city).ToList();
        }
        [HttpPost]
        [Route("AddCustomer")]
        public void AddCustomer(Customer item)
        {
            db.Add(item);
            db.SaveChanges();
        }
        [HttpPut]
        [Route("Update/{id}")]
        public void Update(string id)
        {
            Customer e = db.Customer.Find(id);
            e.Address = "chirala";
            db.Customer.Update(e);
            db.SaveChanges();
        }
    }
}
