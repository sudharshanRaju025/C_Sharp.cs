using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_constructor
{
     class Exception_Handling
    {
        static void method(string[] args)
        {
            //try
            //{
            //    var Calculator = new Calculator();
            //    var result = Calculator.calculator (5, 0);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("sorry, an exception is occured.");

            //}
            //Console.ReadLine();

            StreamReader StreamReader = null;
            try
            {
                StreamReader = new StreamReader(@"C:\Users\sudarshan\source\repos");
                var content = StreamReader.ReadToEnd();
                throw new Exception("oops");
            }
            catch(Exception ex)
            {
                Console.WriteLine("sorry an error is occured.");
            }
            finally
            {
                if (StreamReader != null)
                

                    StreamReader.Dispose();
                
            }
        }
        

        
    }
}
