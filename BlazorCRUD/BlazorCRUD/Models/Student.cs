﻿using System.Data;

namespace BlazorCRUD.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public DateTime? Birthday { get; set; }
    }
}