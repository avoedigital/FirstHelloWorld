using System.Security.Cryptography.X509Certificates;

class HomeWork
{
    static void Main(string[] args)
    {
        //მთავარი ლოგიკის გამოძახება
        MainLogic();
        
    }


    //მომხმარებელს უნდა ჰქონდეს შესაძლებლობა, რომ სამჯერ სცადოს რიცხვის გამოცნობა.თუ რიცხვი მესამე ცდის შემდეგ ვერ გამოიცნო უნდა
    //გამოვიდეს შეტყობინება წაგების შესახებ.თუ გამოიცნო უნდა გამოვიდეს შეტყობინება გამარჯვების შესახებ.
    //უნდა დაუმატოთ შესაძლებლობა პროგრამას, რომ მომხმარებელმა ხელახლა დაიწყოს თამაში.
    static void MainLogic()
    {
        int count = 0;

        Random rand = new Random();
        int computernumber = rand.Next(0, 20);


        while (count < 3) {
        count++;
            Console.WriteLine("Enter Your Number Under 20....");
            int userinput = Int32.Parse(Console.ReadLine());

              
            
            

            if (userinput == computernumber)
            {
                Console.WriteLine("Computer Number is.." + computernumber + " " + "You Won");
                return;
                
               } else if (userinput > computernumber && count != 3) {
                Console.WriteLine("Your number is Higher");
            } else if (userinput< computernumber && count != 3) {

                Console.WriteLine("Your number is Lower");
                }
         

        } 
        
        Console.WriteLine("You Loose!!!!   Continue Game? Enter Y - Yes or N - NO"); 
        string nextgame = Console.ReadLine(); 

        if (nextgame == "Y"){

            MainLogic();
        } else
        {
            return;
        }
    }

     

}
