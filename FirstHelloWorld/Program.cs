
using System.Security.Cryptography.X509Certificates;

class HomeWork
{
    static void Main(string[] args)
    {
        //გამოვიძახოთ პირველი დავალება
        Console.WriteLine(Math(5, 4));

        // მეორე დავალება, შეიყვანოს მომხმარებელმა ცვლადები
        Console.WriteLine("Enter your X: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter your Y: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter your Z: ");
        double z = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter you W: ");
        double w = double.Parse(Console.ReadLine());
        // მეორე დავალება, გამოვიძახოთ მეთოდი რომელიც მინ და მაქსს გაჩექავს
        MinMax(x1, y1, z, w);

        //მესამე დავალების გამოძახება  
        Fruit();



    }

    //1. შევქმნათ მეთოდი, რომელსაც გადავცემთ ორ სრულ რიცხვს.
    //მეთოდმა უნდა დააბრუნოს ორი რიცხვის ჯამი. გამოვიყვანოთ ეს ჯამი შესვლის წერტილის მეთოდის მეშვეობით კონსოლში.
    static int Math(int x, int y) {

        int result = x + y;
        return result;

    }
    // 2. შევქმნათ მეთოდი. ვთხოვოთ მომხმარებელს შეიყვანოს ოთხი ნებისმიეირ ტიპის რიცხვი (ანუ არა მხოლოდ ინტეჯერი). მეთოდის ფარგლებში უნდა მოიძებნოს ამ ოთხი რიცხვიდან ყველაზე დიდი და ყველაზე პატარა.
    // მეთოდმა უნდა გამოიყვანოს კონსოლში ეს ორი რიცხვი.
static void MinMax(double x1, double y1, double z, double w)
    {
        if (x1 >= y1 && x1 >= z && x1 >= w)
        {
            Console.WriteLine("The Highest number: " + x1);
        }
        else if (y1 >= z && y1 >= w && y1 >= x1)
        {
            Console.WriteLine("The Highest number: " + y1);
        }
        else if (z >= w && z >= x1 && z >= y1)
        {
            Console.WriteLine("The Highest number: " + z);
        }
        else if (w >= x1 && w >= z && w >= y1)
        {
            Console.WriteLine("The Highest number: " + w);
        } else
        {
            Console.WriteLine("Numbers is equal");
        }

        if (x1 <= y1 && x1 <= z && x1 <= w)
        {
            Console.WriteLine("The Lowest number is " + x1);
        }
        else if (y1 <= x1 && y1 <= z && y1 <= w)
        {
            Console.WriteLine("The lowest number is " + y1);
        }
        else if (z <= x1 && z <= y1 && z <= w)
        {
            Console.WriteLine("The lowest number is " + z);

        }
        else if (w <= x1 && w <= y1 && w <= z)
        {
            Console.WriteLine("The lowest numver is " + w);
        } 
    }

    //შევქმნათ მეთოდი, რომელმაც უნდა მიიღოს მეორე მეთოდის მეშვეობით მომხმარებლისგან ხილის დასახელება.
    //ამ ხილის დასახელების მიღების შემდეგ switch ოპერატორის მეშვეობით ნახოს თუ რომელი ხილია და გამოიყვანოს შესაბამისი შეტყობინება. თუ ასეთი ხილი არ მოიძებნა, ამის შესახებაც მომხმარებელმა უნდა მიიღოს შეტყობინება.
    //ხილი: apple, watermelon, melon, cherry, strawberry. 

    
     static void Fruit()
    {
        Console.WriteLine("Enter your Fruit: "); 
        string FruitInput = Console.ReadLine();
        switch(FruitInput)
        {
            case "apple":
                Console.WriteLine("This is an Apple");
                break;
            case "watermelon":
                Console.WriteLine("This is an watermelon");
                break;
            case "melon":
                Console.WriteLine("This is an melon");
                break;
            case "cherry":
                Console.WriteLine("This is an cherry");
                break;
            case "stawberry":
                Console.WriteLine("This is an strawberry");
                break;
            default:
                Console.WriteLine("There is no such fruit");
                break;
        }
    }
    
}
