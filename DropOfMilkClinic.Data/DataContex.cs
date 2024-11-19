using DropOfMilkClinic.Entities;

namespace DropOfMilkClinic.Data
{
    public class DataContex
    {
        public List<Baby> Baby { get; set; }
        public List<Branch> Branch { get; set; }
        public List<Nurse> Nurse { get; set; }
        public List<Recommendation> Recommedation { get; set; }
        public List<Turn> Turn { get; set; }

        public DataContex()
        {
            Baby = new List<Baby>
            {
                new Baby
                {
                    FirstName = "TAMAR",
                    LastName = "LEVI",
                    BabyId = "327720439",
                    IsBaby = true,
                    BranchId = new Branch { BranchId = 1, City = "NETANYA", Street = "LECHI", status = true },
                    TurnIDList = new List<Turn>
                    { new Turn { TurnId = 102, TurnDate = new DateTime(), BranchId = new Branch { BranchId = 1, City = "NETANYA", Street = "LECHI", status = true }, status = true }
                    }
                }
            };
            Branch = new List<Branch> {
            new Branch{BranchId=1,City="BNE BRAK",Street="RabyAkiva",status=true},
               new Branch{BranchId=2,City="RAMAT GAN",Street="SHOMRIM",status=false},
                  new Branch{BranchId=1,City="NETANYA",Street="LECHI",status = true}

        };
            Nurse = new List<Nurse> {
           new Nurse{FirstName="YAEL",LastName="SHUKER",NurseId="215262626",Status=true,BranchId=new Branch{ } }
        };
            Recommedation = new List<Recommendation> {
            new Recommendation{RecommendId=1,RecommendContent="Winter is coming, so hurry up to vaccinate your children"},
            new Recommendation{RecommendId=2,RecommendContent="vaccinate to your new baby is very important!!!"}
        };
            Turn = new List<Turn> {
            new Turn{TurnId=100,TurnDate=new DateTime(),BranchId=new Branch{BranchId=1,City="NETANYA",Street="LECHI",status = true}, status = true},
             new Turn{TurnId=101,TurnDate=new DateTime(),BranchId=new Branch{BranchId=1,City="NETANYA",Street="LECHI",status = true},status = true},
            new Turn{TurnId=102,TurnDate=new DateTime(),BranchId=new Branch{BranchId=1,City="NETANYA",Street="LECHI",status = true},status=true}
        };

        }
    }
}
