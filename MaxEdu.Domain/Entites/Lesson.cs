using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxEdu.Domain.Entites
{
    public class Lesson
    {
        public Lesson()
        {
            Attadances = new HashSet<Attadance>();
        }
        public int Id { get; set; }
        public string LessonTheme { get; set; }
        public int GroupId { get; set; }
        public DateTime StartedDateTime { get; set; }
        public DateTime EndedDateTime { get; set;}

        [ForeignKey("GroupId")]
        public Group Group { get; set; }

        public ICollection<Attadance> Attadances { get; set;}
    }
}
