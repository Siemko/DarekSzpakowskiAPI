using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DarekSzpakowskiApi 
{
    public class Score : Base
    {
        public string PlayerId { get; set; }
        public short ScoreTime { get; set; }
        public virtual Player Player { get; set; }
    }
}