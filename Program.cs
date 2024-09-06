using _2024_Autogarage.BusinessLayer;

namespace _2024_Autogarage
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welkom bij de autogarage!");

            foreach (CarOwner owner in CarOwner.GetAll())
            {
                Console.WriteLine($"Id {owner.Id} - Name {owner.Name}");
            }
        }
    }
}
