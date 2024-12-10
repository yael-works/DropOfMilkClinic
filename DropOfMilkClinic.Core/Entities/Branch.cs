using System.ComponentModel.DataAnnotations;

namespace DropOfMilkClinic.Entities
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public bool Status { get; set; }
        public string BabyId { get; set; }
        public List<Nurse> Nurses { get; set; }
        public List<Turn> Turns { get; set; }
    }
}
