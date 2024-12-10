using System.ComponentModel.DataAnnotations;

namespace DropOfMilkClinic.Entities
{
    public class Nurse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NurseId { get; set; }
        public bool Status { get; set; }
        //רבים ליחיד
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
