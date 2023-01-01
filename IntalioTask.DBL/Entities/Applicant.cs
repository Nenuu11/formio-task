

namespace IntalioTask.DBL.Entities
{
    [Table("Applicant")]
    public class Applicant
    {
        public int ApplicantId { get; set; }
        [Required, StringLength(50)]
        public string FirstName { get; set; }
        [Required, StringLength(50)]
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime BirthDate { get; set; }
        public string GraduationYear { get; set; }
        public int YearsOfExperience { get; set; }
        [ForeignKey("Degree")]
        public int DegreeId { get; set; }
        [ForeignKey("City")]

        public int CityId { get; set; }
        public string CoverLetter { get; set; }
        public virtual Degree Degree { get; set; }
        public virtual City City { get; set; }
    }
}
