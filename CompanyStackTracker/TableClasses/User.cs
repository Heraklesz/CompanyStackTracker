using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyStackTracker
{
    public class User
    {

        public int Id { get; set; }
        public string AccName { get; set; }
        public string Password { get; set; }
        public IList<Company> Companies { get; set; }
        public User()
        {
            Companies = new List<Company>();
        }
    }
}
