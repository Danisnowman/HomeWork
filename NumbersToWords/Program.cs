using System;

namespace Numbers_To_Date
{
    class Program
    {
        static int year, month, monthMax, day;
        static string monthName;
         //Function for asking date
        static int askDate(string Question, int maxValue) //Define the data type for askDate()
        {
            Console.WriteLine(Question);    
            int date = int.Parse(Console.ReadLine());
            //Check if date is valid
            while (date <= 0 || date > maxValue)               
                {
                    Console.WriteLine("Your date is invalid, please try again.");
                    //Ask for the user's input again
                    date = int.Parse(Console.ReadLine());
                }
            return date;
        }
        //Function for user interaction
        static void Main()
        {

            bool done = false;
            while (!done)
            {
                year = askDate("Please enter a year (Example: 2049).", 1000000);
                month = askDate("Please enter a month by using it's number (Example: August is 8).", 12);


                switch(month)
                {
                    case(1):
                        monthName = "January";
                        monthMax = 31;
                        break;
                    case(2):
                        monthName = "February";
                        if(year % 4 == 0)
                        {
                            monthMax = 29;
                        }
                        else
                        {
                            monthMax= 28;
                        }
                        break;
                    case(3):
                        monthName = "March";
                        monthMax = 31;
                        break;
                    case(4):
                        monthName = "April";
                        monthMax = 30;
                        break;
                    case(5):
                        monthName = "May";
                        monthMax = 31;
                        break;
                    case(6):
              			monthName = "June";
              			monthMax = 30;
              			break;
              		case(7):
              			monthName = "July";
              			monthMax = 31;
              			break;
              		case(8):
              			monthName = "August";
              			monthMax = 31;
              			break;
              		case(9):
              			monthName = "Septmeber";
              			monthMax = 30;
              			break;
              		case(10):
              			monthName = "October"; 
              			monthMax = 31;
              			break;
              		case(11):
              			monthName = "November";
              			monthMax = 30;
              			break;
              		case(12):
              			monthName = "December";
              			monthMax = 31;
              			break;
                }
                day = askDate("Please enter a day by using it's number (Example: 27)", monthMax);
                Console.WriteLine($"The date you selected is {day} of {monthName} of the year, {year}");
                done = true;
            }
        }
    }
}
