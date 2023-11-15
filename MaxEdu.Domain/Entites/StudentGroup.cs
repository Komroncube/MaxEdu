using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxEdu.Domain.Entites
{
    public class StudentGroup
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int GroupId { get; set; }
        public DateTime JoinDate { get; set; }
        public bool IsPayed { get; set; }

        [ForeignKey("StudentId")]
        public User User { get; set; }

        [ForeignKey("GroupId")]
        public Group Group { get; set; }

    }
}
