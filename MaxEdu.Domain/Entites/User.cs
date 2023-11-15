using MaxEdu.Domain.Enums;

namespace MaxEdu.Domain.Entites
{
    public class User
    {
        public User()
        {
            Attadances = new HashSet<Attadance>();
            Groups = new HashSet<Group>();
            StudentGroups = new HashSet<StudentGroup>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRole Role { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public ICollection<Attadance> Attadances { get; set;}
        public ICollection<Group> Groups { get; set;}

        public ICollection<StudentGroup> StudentGroups { get; set;}
    }
}
