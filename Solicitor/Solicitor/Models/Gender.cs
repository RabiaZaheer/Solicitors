using System.Collections.Generic;

namespace Solicitor.Models
{
    public class Gender
    {        
        public int GenderID { get; set; }
        public string Title { get; set; }

       public static IEnumerable<Gender> GetGenders {
            get {
                return new List<Gender> {
                    new Gender{
                        GenderID=1,
                        Title="Male"
                    },
                    new Gender{
                        GenderID=2,
                        Title="Female"
                    },
                    new Gender{
                        GenderID=3,
                        Title= "Not Sepecified"
                    }
                };
            }
        }
    }
}