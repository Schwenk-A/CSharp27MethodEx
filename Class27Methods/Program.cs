using System;

namespace Class27Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise One is down below- Here I am showing how I put everything into a method and am calling it from inside the main.
            UserStory(); //It takes in no parameters and does not return anything. Basically I am just asking for it to run the code inside.



           // AbstractingUsersName(); here is a method on how we would abstract a piece out 






            //Exercise two- here you can see all methods work. Both ways of using the params are valid as they get the correct answer. 
            Console.WriteLine(Sum(2, 4));
            Console.WriteLine(ParamAddWayOne(2, 4, 6));
            Console.WriteLine(ParamAddWayTwo(1, 1, 1, 1, 1));








            //Here is how we could collect user info the same way we did in exercise One
            Console.WriteLine("Please provide me your first number");
            var firstInput = int.Parse(Console.ReadLine());
            Console.WriteLine("and your next number");
            var secondInput = int.Parse(Console.ReadLine());
            Console.WriteLine("and lets add one more ");
            var thirdInput = int.Parse(Console.ReadLine());

            var answer = ParamAddWayOne(firstInput, secondInput, thirdInput);
            Console.WriteLine(answer);


            Console.WriteLine("Press anything to see alternate way");
            Console.ReadKey();

            //alternatively :
            Console.WriteLine($"Okay so using the method inside of the Console.WriteLine gives us the answer = {ParamAddWayOne(firstInput, secondInput, thirdInput)}");
           

        }

        public static void UserStory()
        {
        /*Exercise One. 
        Gather and store the information below using Console Writeine and Console.ReaLine
        Your Name
        Your Favorite Color
        Your Favorite Animal
        Your Favorite Band */
            Console.WriteLine("This is the start of exercise One. Wel will be using two methods. The first Console.WriteLine() and the second Console.ReadLine()");
            Console.WriteLine("Press anything to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Hello, What is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            var userFavColor = Console.ReadLine();
            Console.WriteLine("also, what is your favorite animal?");
            var userFavAnimal = Console.ReadLine();
            Console.WriteLine("last your favorite band?");
            var userFavBand = Console.ReadLine();

            //This is string interpolation:
            Console.WriteLine($"Hey {userName}! Look its a {userFavColor} {userFavAnimal}! What is that?? It is singing? Sounds like {userFavBand}! Awesome! ");
            //              ^^^^That dollar sign allows you to do this----^^^^^^^^^^^^^^^ using curly brackets to insert your own answers. 
            Console.ReadKey();
            Console.Clear();
        }

        public static void AbstractingUsersName()
        {
            Console.WriteLine("Hello, What is your name?");
            var username =Console.ReadLine();
        }

        /*Exercise Two.
            Declare 5 methods:
           1 Add method 
           1 Subtract method
           1 Multiply method
           1 Divide method
           1 Modulus method

            */
        public static int Sum(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int ParamAddWayOne(params int[] nums)
        {
            var sum = 0; //This will ensure you have a starting point of zero and it will store the answer when the method is complete.
            foreach (var x in nums)
            {         //^^^For each item( we call it x ) in the collection. 
                sum += x;
            }
            return sum;
        }
        public static int ParamAddWayTwo(params int[] nums)
        {
            int sum = 0; 
            for(int i = 0; i < nums.Length; i++)
            {
                 sum += nums[i];//<- nums at whatever index as it goes through the list start with 0 then 1 then 2 etc. 
                //sum = sum + x;
            }
            return sum; // you want to make sure your return is outside of the for loop otherwise your not able to go through the whole
                       // list of numbers.n
        }

        
    }
}
