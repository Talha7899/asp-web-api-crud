using System;
using System.Collections.Generic;

namespace Crud_Operations_Using_Asp_Core_Web_Api.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public int Age { get; set; }

    public string Standard { get; set; } = null!;

    public string FatherName { get; set; } = null!;
}
