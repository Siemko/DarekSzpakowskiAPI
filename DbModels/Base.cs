using System;
using System.ComponentModel.DataAnnotations;

namespace DarekSzpakowskiApi 
{
    public class Base
    {
        [Key]
        public int Id {get; set;}
        public DateTime CreatedAt { get; set; }
    }
}