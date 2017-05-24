using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DarekSzpakowskiApi 
{
    public class Match : Base
    {
        public int HomeTeamId { get; set; }
        public int GuestTeamId { get; set; }

        public virtual ICollection<Score> HomeScores {get;set;}
        public virtual ICollection<Score> GuestScores {get;set;}
        
        [ForeignKey("HomeTeamId")]
        public virtual Team HomeTeam { get; set; }

        [ForeignKey("GuestTeamId")]
        public virtual Team GuestTeam { get; set; }
    }
}