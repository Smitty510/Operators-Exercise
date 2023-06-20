namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Excercise1

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)




                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");


            //Exercise 2: see Bonus Tab
            {
                Console.WriteLine("What is the radius of your circle?");
                var radius = double.Parse(Console.ReadLine());
                Bonus.AreaOfCircle(radius);
            }




        }

    }        
}





