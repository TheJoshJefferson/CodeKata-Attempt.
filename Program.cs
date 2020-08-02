/*
 * Programmer: Joshua Jefferson
 * Last Edited: 8/2/20
 * */
using System;

namespace CodeKataSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            string Command = null;
            string Name = null;
            string driverName = null;
            string StartTime = null;
            string EndTime = null;
            double miles = 0.0;
            double Tripmiles;
           
            

           
            try
            {
                // this is how i would program it to read in the text input file
                using (System.IO.StreamReader sr = new System.IO.StreamReader(@"file location\file name"))
                {
                    string line;
                    
                    do
                    {
                        line = sr.ReadLine();
                        Console.WriteLine(line);
                        string[] Splitline = line.Split(" ");
                    } while (line != null);
                }
            }
            catch
            {
                // error message, should the file not be located
                Console.WriteLine("no file detected");
            }
            // split it based on driver or trip as starting command 
            while (true)
            {
                //need to find an equivalent for has next.
               
                Command =  ; // here is where the error in the README occured. 
                if (Command == "Driver")
                {
                    //Specifies what to read from the Driver Command
                    driverName = Name;


                }
                else if (Command == "Trip")
                {
                    //convert the String Times into DateTimes and subtract
                    driverName = Name;
                    DateTime Start = DateTime.ParseExact(StartTime, "hh:mm:ss tt", System.Globalization.CultureInfo.CurrentCulture);
                    DateTime End = DateTime.ParseExact(EndTime, "hh:mm:ss tt", System.Globalization.CultureInfo.CurrentCulture);
                    TimeSpan TotalTime = End - Start;
                    Tripmiles = miles;

                }
                //Explain what happened when attempting to create the report
            }
            
              
            }

            

       
        }
    }
   

