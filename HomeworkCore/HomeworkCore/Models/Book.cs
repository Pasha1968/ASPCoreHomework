using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HomeworkCore.Models
{
    public class Book
    {
        public int Id { get;set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        [Range(1, 2030)]
        public int year { get; set; }
    }
}
