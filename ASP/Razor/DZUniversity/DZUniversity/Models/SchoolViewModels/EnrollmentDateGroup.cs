using System.ComponentModel.DataAnnotations;

namespace DZUniversity.Models.SchoolViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }
        public int StudentCount { get; set; }
    }
}
