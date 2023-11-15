using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxEdu.Domain.Entites
{
    public class Group
    {
        public Group()
        {
            StudentGroups = new HashSet<StudentGroup>();
            Lessons = new HashSet<Lesson>();
        }

        public int Id { get; set; }
        public string GroupName { get; set; }
        public int TeacherId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("TeacherId")]
        public User User { get; set; }

        public ICollection<StudentGroup> StudentGroups { get; set; }
        public ICollection<Lesson> Lessons { get; set; }

        
    }
}
