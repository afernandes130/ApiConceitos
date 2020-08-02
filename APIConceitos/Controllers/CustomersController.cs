using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIConceitos.IServices;
using APIConceitos.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIConceitos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private IDppCustomerService _customerService;
        public CustomersController(IDppCustomerService customerService)
        {
            _customerService = customerService;
        }


        // GET: api/<CustomersController>
        [HttpGet]
        public IEnumerable<DPPCustomers> Get()
        {

            return _customerService.GetAll();
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public DPPCustomers Get(int id)
        {
            return _customerService.Get(id);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public DPPCustomers Post([FromBody] DPPCustomers customers)
        {
            if (ModelState.IsValid) 
                return _customerService.Save(customers);

            return null;
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customerService.Delete(id);
        }
    }
}
