using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DropOfMilkClinic.Entities
{
    public class Turn
    {
        public string TurnId { get; set; }
        public DateTime TurnDate { get; set; }
        public bool Status { get; set; }
       
    }
}
