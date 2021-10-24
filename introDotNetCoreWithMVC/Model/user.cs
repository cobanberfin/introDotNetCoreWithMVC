using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace introDotNetCoreWithMVC.Model
{
    //public class user
    //{
    //    public string Name { get; set; }
    //    public string LastName { get; set; }

    //    public string Email { get; set; }


    //}


    //valıdaton ornegi
    public class user
    {
        [Required(ErrorMessage ="Ad alanı boş olamaz")]
        [MinLength(2,ErrorMessage ="en az 2 karakter")]
        public string Name { get; set; }
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage ="e posta formatı yanlış")]

        [Required(ErrorMessage = "Eposta alanı boş olamaz")]
        public string Email { get; set; }


    }
}
