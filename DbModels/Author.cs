using System.ComponentModel.DataAnnotations;

namespace DarekSzpakowskiApi 
{
    public class Author : Base
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}