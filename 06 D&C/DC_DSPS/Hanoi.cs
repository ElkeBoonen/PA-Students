
namespace DC_DSPS
{
    internal class Hanoi
    {
        internal void Solve(int disks, char left, char middle, char right)
        {
            if (disks == 1)
            {
                Console.WriteLine($"Move disk 1 from {left} to {right}");
            }
            else
            {
                Solve(disks - 1, left, right, middle);
                Console.WriteLine($"Move disk {disks} from {left} to {right}");
                Solve(disks - 1, middle, left, right);

            }
        }
    }
}