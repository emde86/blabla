
namespace rndTestConsole.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    public class AppController
    {
        public int A { get; private set; }

        public int B { get; private set; }

        public AppController(int a, int b)
        {
            A = 2 * a;// (a == 5 ? 6 : a);
            B = 5 * (b == 2 ? 4 : b);
        }
    }
}
