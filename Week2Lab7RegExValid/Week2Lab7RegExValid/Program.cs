﻿using System;
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
            string email = null;
            string phone = null;
            string date = null;
            //Validate Names
            var namePattern = @"[A-Z][a-z]{1,29}\s[A-Z][a-z]{1,29}";
            //validate emails 
            var emailPattern = @"([\w]|\.|\\|\/|\-){5,30}@[\w]{5,10}\.[\w]{2,3}";
            //validate phone numbers: (d d d - d d d - d d d d)
            var phonePattern = @"[\d]{3}([\.\\\-\/]|\s)[\d]{3}([\.\\\-\/]|\s)[\d]{4}";
            //validate date (day, month, year)
            var datePattern = @"[\d]{2}([\.\\\-\/]|\s)[\d]{2}([\.\\\-\/]|\s)[\d]{4}";
            //validate html tags
            var htmlPattern = @"\<\w{1,9}\>\s\<\\\w{1,9}\>";
            
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

            Console.WriteLine("What's an email you check regularly?");
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
                    Console.WriteLine("Hmm... not sure that's going to send to an inbox\nCould you give me the one that recieves bank statments...\nJust to be sure of course!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            Console.WriteLine("What's your phone number? Separate parts please! Should be 10 numbers");
            phone = Console.ReadLine();
            var validPhone = Regex.IsMatch(phone, phonePattern);
            try
            {
                if (validPhone)
                {
                    Console.WriteLine("What a keen phone number!\nHope you love texts!");
                }
                else
                {
                    Console.WriteLine("I think you're pulling my leg champ!\nThat or you forgot the spaces.\nJust give me someone's number!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            Console.WriteLine("What's your birthdate? Write it dd mm yyyy");
            date = Console.ReadLine();
            var validDate = Regex.IsMatch(date, datePattern);
            try
            {
                if (validDate)
                {
                    Console.WriteLine("Wow, I bet you love to recieve birthday promotions!\nAnd now I know you're definitely 18!");
                }
                else
                {
                    Console.WriteLine("I think you're telling schoolyeard tales.\nBet your social security card has it written out right!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            string htmlTags = Console.ReadLine();
            var validHtmlTags = Regex.IsMatch(htmlTags, htmlPattern);
            try
            {
                if (validHtmlTags)
                {
                    Console.WriteLine("One more thing scout, could you give me an opening and closing html tag set to prove you're not a robot?");
                }
                else
                {
                    Console.WriteLine("C'mon, scouts honor here! Maybe try again? Html tags look like <x> </x> if that helps");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            Console.ReadKey();
            //Add retries throughout
        }
    }
}
