using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("AssemblyB")]
namespace AssemblyA
{
    // The class is internal by default. 
    internal class FriendClass
    {
        public void Test()
        {
            Console.WriteLine("Sample Class");
        }
    }

    // Public class that has an internal method. 
    public class ClassWithFriendMethod
    {
        internal void Test()
        {
            Console.WriteLine("Sample Method");
        }

    }
}
