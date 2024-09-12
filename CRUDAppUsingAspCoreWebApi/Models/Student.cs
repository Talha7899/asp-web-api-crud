using System.ComponentModel.DataAnnotations;
namespace CRUDAppUsingAspCoreWebApi.Models
{
    public class Student
    {
            public int id { get; set; }
            [Required]
            public string name { get; set; }
            [Required]
            public string gender { get; set; }
            [Required]
            public int age { get; set; }
            [Required]
            public string standard { get; set; }
            [Required]
            public string fatherName { get; set; }

        public static implicit operator List<object>(Student v)
        {
            throw new NotImplementedException();
        }
    }
}
