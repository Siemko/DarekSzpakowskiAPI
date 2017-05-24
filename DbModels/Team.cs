using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DarekSzpakowskiApi 
{
    public class Team : Base
    {
        public string Name { get; set; }

        public virtual ICollection<Player> Players {get; set;}
    }
}