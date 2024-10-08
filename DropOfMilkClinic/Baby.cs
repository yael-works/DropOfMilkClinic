namespace DropOfMilkClinic
{
    public class Baby
    {
       public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BabyId { get; set; }
        public bool IsBaby { get; set; }
        public Branch BranchId { get; set; }
        public List<Turn> TurnIDList { get; set; }

        

    }
}
