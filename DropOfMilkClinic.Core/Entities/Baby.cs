using System.ComponentModel.DataAnnotations;

namespace DropOfMilkClinic.Entities
{
    public class Baby
    {
        public string BabyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsBaby { get; set; }
        public Branch Branch { get; set; }
        public List<Turn> Turns { get; set; }
    }
}
