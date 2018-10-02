using Banking.domain;
using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Customer c = new Customer("Arthur", "Coucke", null);
                Customer c1 = new Customer("Arthur1", "Coucke", "be123",);
                Console.WriteLine(c);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("NULL");
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Global");
                Console.WriteLine(ex.Message);

            }
            finally {

                Console.WriteLine("I ran");
            }

           
          
        }
    
    }
    


    
}
