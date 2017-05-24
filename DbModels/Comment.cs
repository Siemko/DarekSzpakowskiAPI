using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DarekSzpakowskiApi 
{
    public class Comment : Base
    {
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public short ActionTime { get; set; }
        public virtual Author Author { get; set; }
    }
}