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
