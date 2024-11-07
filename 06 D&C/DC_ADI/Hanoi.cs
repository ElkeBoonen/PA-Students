
namespace DC_ADI
{
    internal class Hanoi
    {
        internal void Solve(int disks, char from, char to, char temp)
        {
            if (disks == 1) Console.WriteLine($"disk 1 from {from} to {to}");
            else if (disks > 1)
            {
                Solve(disks - 1, from, temp, to);
                Console.WriteLine($"disk {disks} from {from} to {to}");
                Solve(disks - 1, temp, to, from);
            }

        }
    }
}