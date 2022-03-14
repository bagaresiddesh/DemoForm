using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/value")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost, Route("Create")]
        public void CreateRecord(Form form)
        {
            //emp = form;
        }

        [HttpGet, Route("Get")]
        public Form GetData()
        {
            Form data = new Form { EmployeeNo = 1118, FirstName = "Siddesh", MiddleName = "abc", LastName = "Bagare", Department = "cs", Location = "Pune", WorkPhone = "8765456789", MobilePhone = "9876765446", TShirtSize = "Medium", Email = "sidd@gmail.com", BloodGroup = "A-" };

            return data;
        }
    }
}
