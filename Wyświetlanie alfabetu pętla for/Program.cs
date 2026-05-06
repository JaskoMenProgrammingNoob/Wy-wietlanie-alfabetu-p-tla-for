class program
{
    static void Main(string[] args)
    {
        char A = 'A';
        char Z = 'Z';
        for (A = 'A'; A <= 'Z'; A++)
        {



            Console.Write($"{A}");

            if (A < 'Z')
            {
                Console.Write(",");
            }
            else
            {
                Console.WriteLine(".");
            }
        }   
            for (Z = 'Z'; Z >= 'A'; Z--)
            {
                Console.Write($"{Z}");
                if (Z > 'A')
                {
                    Console.Write(",");
                }
                else
                {
                    Console.WriteLine(".");
                }
                
            }
            
     }
        







    
}