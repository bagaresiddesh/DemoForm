using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("Sample")]
    public class FormController : ControllerBase
    {
       public FormController()
        {

        }

        [HttpPost,Route("Create")]
        public void CreateRecord(Form form)
        {
           Form temp = form;
        }

        [HttpGet, Route("Get")]
        public Form GetData()
        {
            Form data = new Form { EmployeeNo = 1118, FirstName = "Siddesh", MiddleName = "abc", LastName = "Bagare", Department = "cs", Location = "Pune", WorkPhone = "8765456789", MobilePhone = "9876765446", TShirtSize = "Medium", Email = "sidd@gmail.com", BloodGroup = "A-" };

            return data;
        }
    }
}
 