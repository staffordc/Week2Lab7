using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Week2Lab7RegExValid
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = null;
            //Validate Names
            var namePattern = @"[A-Z][a-z]{1,29}\s[A-Z][a-z]{1,29}";
            //validate emails 
            var emailPattern = @"[\w]{5,30}@[\w]{5,10}.[\w]{2,3}";
            //validate phone numbers: (d d d - d d d - d d d d)
            //validate date (day{2}, month{2}, year{4})
            string email = null; 
            Console.WriteLine("Hey, are you older than 18? Fill this out to (possibly) win a car!");

            Console.WriteLine($"\nWhat's your name Sport? First and Last");
             
            userName = Console.ReadLine();

            var validUserName = Regex.IsMatch(userName, namePattern);
            try
            {
                if (validUserName)
                {
                    Console.WriteLine("Wow, what a good name!");
                }
                else
                {
                    Console.WriteLine("I'm not sure that's a name, could you write it again with Capitals first?\nAnd a space in between?\nDouble check your birth certificate!");
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            
            email = Console.ReadLine();
            var validEmail = Regex.IsMatch(email, emailPattern);
            try
            {
                if (validEmail)
                {
                    Console.WriteLine("Wow, what a neat email!\nHope you have it cleaned up so you can see new surveys to fill!\nOpportunities!");
                }
                else
                {
                    Console.WriteLine("Hmm... not sure that's going to send to an inbox\nCould you give me the one that sends bank statments...\nJust to be sure of course!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
