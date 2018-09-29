using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreSeedDataSample.Entities
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}