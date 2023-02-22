
using System.Runtime.Intrinsics.X86;

class HomeWork
{
    static void Main(string[] args)
    {
        //HomeWork 1
        Console.Write("Enter X: ");
        int X = Int32.Parse(Console.ReadLine());
        
        Console.Write("Enter Y: ");
        int Y = Int32.Parse(Console.ReadLine());
        
        Console.Write("Enter Z: ");
        int Z = Int32.Parse(Console.ReadLine());
        
        int result = X + Y * Z;
        Console.WriteLine("Unswer is:" + result);

        //HomeWork 2
        Console.Write("Enter your name: ");
        string firstName = Console.ReadLine();
       
        Console.Write("Enter your surname: ");
        string surName = Console.ReadLine();
        
        Console.Write("Enter your age: ");
        int age = Int32.Parse(Console.ReadLine());
        
        Console.Write("Enter your height: ");
        float height = float.Parse(Console.ReadLine());
        
        Console.Write("Enter your weight: ");
        double weight = double.Parse(Console.ReadLine());

        
        Console.WriteLine(firstName + " " + surName);
        Console.WriteLine("Your age is: " + age);
        Console.WriteLine("Your height is: " + height);
        Console.WriteLine("Your weight is: " + weight);

        //HomeWork 3:

        Console.WriteLine("Please Enter your height in CM : "); 
        double height1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Please Enter your weight in KG: ");
        double weight1 = double.Parse(Console.ReadLine());

        double Bmi = weight1 / ((height1 / 100)  * (height1 / 100));
        Console.WriteLine("Your Bmi is equel " + Bmi);


        //HomewWork 4
        string vertical = "|";
        string horizontal = "_";
        Console.WriteLine(" " + vertical + " " + vertical + " ");
        Console.WriteLine("1" + vertical + "2" + vertical + "3");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine(" " + vertical + " " + vertical + " ");
        Console.WriteLine("4" + vertical + "5" + vertical + "6");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine(" " + vertical + " " + vertical + " ");
        Console.WriteLine("7" + vertical + "8" + vertical + "9");

    
    }
}
