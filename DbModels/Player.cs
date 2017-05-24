using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DarekSzpakowskiApi 
{
    public class Player : Base
    {
        public string Name { get; set; }
        public short Number { get; set; }
    }
}