namespace DropOfMilkClinic
{
    public class Turn
    {
        public int TurnId { get; set; }
        public  DateTime TurnDate { get; set; }

        public Branch BranchId { get; set; }

        public bool status { get; set; }

    }
}
