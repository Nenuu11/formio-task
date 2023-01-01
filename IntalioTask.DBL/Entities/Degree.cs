namespace IntalioTask.DBL.Entities
{
    [Table("Degree")]
    public class Degree
    {
        public int DegreeId { get; set; }
        [Required, StringLength(50)]
        public string DegreeName { get; set; }
    }
}
