using AssemblyA;

namespace AssemblyB
{
    class Program
    {
        static void Main()
        {
            new ClassWithFriendMethod().Test();
            new FriendClass().Test();
        }
    }
}
