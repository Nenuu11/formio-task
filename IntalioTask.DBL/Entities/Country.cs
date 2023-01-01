namespace IntalioTask.DBL.Entities
{
    [Table("Country")]
    public class Country
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }
        public int CountryId { get; set; }
        [Required, StringLength(50)]
        public string CountryName { get; set; }
        public virtual ICollection<City> Cities { get; set; }

    }
}
