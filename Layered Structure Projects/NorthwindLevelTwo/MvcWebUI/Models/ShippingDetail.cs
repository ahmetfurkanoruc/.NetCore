using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Models
{
    public class ShippingDetail
    {
        //[Required(ErrorMessage ="Please enter your name !")]
        public string FirstName { get; set; }
        //[Required(ErrorMessage = "Please enter your lastname !")]
        public string LastName { get; set; }
        //[Required(ErrorMessage = "Please enter your e-mail !")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Please enter your city !")]
        public string City { get; set; }
        //[Required(ErrorMessage = "Please enter your address !")]
        //[MinLength(10)]
        public string Address { get; set; }
        //[Required(ErrorMessage = "Please enter your age !")]
        //[Range(18,65)]
        public int Age { get; set; }
    }
}
