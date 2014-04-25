using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backleft_music_UI
{
    public class User
    {
        private static User instance;
        private User() { }

        public static User Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new User();
                }
                return instance;
            }
        }

        public int userID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }

        public int addressID { get; set; }
        public int purchasesID { get; set; }
        public int creditCardID { get; set; }

    }
}
