using BankClone2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClone2
{
    public class Initializer
    {
        public static void InitializerMethod()
        {
            UserManager c1 = new UserManager();
            c1.CreateInitialUsers();
            c1.Run();
        }
    }
}
