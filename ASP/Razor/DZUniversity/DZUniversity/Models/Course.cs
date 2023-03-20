using System.ComponentModel.DataAnnotations.Schema;

namespace DZUniversity.Models
{
    public class Course
    {
        
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int CourseID { get; set; }
            public string Title { get; set; } = default!;
            public int Credits { get; set; }

            public ICollection<Enrollment> Enrollments { get; set; }
    }
}