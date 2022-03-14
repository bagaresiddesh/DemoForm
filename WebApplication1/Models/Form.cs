using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Form
    {
        [Required]
        [JsonProperty("employeeNo")]
        public int EmployeeNo { get; set; }

        [Required]
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [Required]
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [Required]
        [JsonProperty("department")]
        public string Department { get; set; }

        [Required]
        [JsonProperty("location")]
        public string Location { get; set; }

        [Required]
        //[RegularExpression(@"/^\+?1?\s*?\(?\d{3}(?:\)|[-|\s])?\s*?\d{3}[-|\s]?\d{4}$/")]
        [JsonProperty("workphone")]
        public string WorkPhone { get; set; }

        [DataType(DataType.Date)]
        [JsonProperty("salaryRev")]
        public DateTime SalaryRev { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [JsonProperty("dateOfJoining")]
        public DateTime DateOfJoining { get; set; }


        //[RegularExpression(@"/^\+?1?\s*?\(?\d{3}(?:\)|[-|\s])?\s*?\d{3}[-|\s]?\d{4}$/")]
        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [Required]
        [JsonProperty("tShirtSize")]
        public string TShirtSize { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [JsonProperty("email")]
        public string Email { get; set; }

        [Required]
        [JsonProperty("bloodGroup")]
        public string BloodGroup { get; set; }

    }
}
