namespace IntalioTask.DBL.Entities
{
    [Table("City")]
    public class City
    {
        public int CityId { get; set; }
        [Required, StringLength(50)]
        public string CityName { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
