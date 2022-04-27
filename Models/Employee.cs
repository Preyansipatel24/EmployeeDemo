using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDemo.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = " Please Enter EmployeeName it is required")]

        public string EmployeeName { get; set; }


        public string Gender { get; set; }
        [DataType(DataType.DateTime)]
        public string DOB { get; set; }
        public string Department { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

    }
}
