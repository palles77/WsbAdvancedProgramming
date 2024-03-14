using System;
using System.ComponentModel.DataAnnotations;

namespace AdvancedProgramming_Lesson1.Models;

public class Student
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
}
