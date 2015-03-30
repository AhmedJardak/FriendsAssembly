using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyA;

namespace AssemblyB
{
    class Program
    {
        static void Main(string[] args)
        {
            new ClassWithFriendMethod().Test();
            new FriendClass().Test();
        }
    }
}
