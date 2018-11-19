using System;

namespace Pension_Uppgift1_Björn_Stenberg
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int userAge, retirementAge, sum; //Dessa har satts upp för att registrera integers - alltså siffror utan decimaler. Detta är även förenklat, ist för att skriva:
            /* int numOne;
             * int numTwo;
             * int sum; ---- Samma sak är implementerat i string variablerna.*/
            string ansOne, ansTwo, ansThree, ansFour, ansFive, ansSix, ansSeven; //Dessa är strings som kallas i if-else. således ansOne = Answer One. Se nedan.


            Console.WriteLine("____________________________"); // Det här är enbart för kosmetiska skäl. Så att det ska se fint ut. 
            Console.WriteLine("*                           *"); // Det välkomnar användaren.
            Console.WriteLine("*      HI AND WELCOME!      *");
            Console.WriteLine("* HOW MANY YEARS LEFT UNTIL *");
            Console.WriteLine("*        YOU RETIRE?        *");
            Console.WriteLine("*___________________________*");

            Console.WriteLine("Please enter your first name: "); //Ber om användarens förnamn.
            string name = Console.ReadLine(); //Läser in användarens text och lagrar string texten i "name"

            Console.WriteLine("Please enter your surname: ");
            string surname = Console.ReadLine(); //Denna kod ber användaren om deras efternamn, likt ovan, sparar efternamnet i "surname".

            Start: //Denna har brukats huvudsakligen för att testa mina olika if-else-statements

            Console.WriteLine("Welcome " + name + " " + surname + ", how old are you?"); //Här skriver konsolen ut input som blivit inskrivet av användaren. Då name och surname blivit sparat i variablerna string "name" och "surname".Användingen av " " mellan är för att skapa ett mellanrum.
            userAge = int.Parse(Console.ReadLine()); //Här får vi input angående ålder och skriver ut åldern. Ändrar med andra ord input string till int med hjälp av Parse.

            retirementAge = 65; //Åldern vi satt som pensionsålder.
            sum = retirementAge - userAge; //Här räknar vi ut antal år det är kvar till pensionen. Vi tar pensionAge som är åldern när man går i pension, minus userAge som är deras ålder. 

            //Valt att skriva ut 7 st strings som kan kallas på i if-else statement.
            string ansOne = "you have " + sum + " years left until retirement."; //Tid tills pension
            string ansTwo = "you have yet to enter the life of a working adult, keep enjoying your childhood! " + sum + " years until you reach the age of retirement."; //Inte ens påbörjat sitt arbetsliv
            string ansThree = "just started working? Time to start thinking about saving up for retirement. " + sum + " years left until you can retire"; // Precis börjat, informerar om att det är dags att börja spara
            string ansFour = "you are already retired. You have been retired for " + -sum + " years. Keep on enjoying your retirement!"; //Redan pensionär
            string ansFive = "you still have " + sum + " years to go. Stay focused and dont buy yourself a porsche just yet."; // Medelålderskris
            string ansSix = "retirmenet is just around the corner, you only have " + sum + " years to go, stay strong."; //Nära pensionsåldern.
            string ansSeven = " you are " + userAge "?! Wow, impressive!"; // 100+ år gammal, imponerande.

            /*if (userAge >= 0) // Om personen är äldre än 0 år, skrivs ansOne ut.. 
            {
                Console.WriteLine(name + " " + surname + ", " + ansOne);
            } */
            if (userAge <= 17 && userAge > 0) // Om personen är äldre än 0 och under, eller 17, skrivs ansTwo ut.
            {
                Console.WriteLine(name + " " + surname + ", " + ansTwo);
            }
            else if (userAge >= 18 || userAge <= 35) // Om personen är mellan 18 och 35, skrivs ansThree ut.
            {
                Console.WriteLine(name + " " + surname + ", " + ansThree);
            }
            else if (userAge >= 65) // Om personen är 65 eller äldre skrivs ansFour ut.
            {
                Console.WriteLine(name + " " + surname + ", " + ansFour);
            }
            else if (userAge >= 45 || userAge <= 59) // Om personen är 45 eller yngre än, eller 59, skrivs ansFive ut.
            {
                Console.WriteLine(name + " " + surname + ", " + ansFive);
            }
            else if (userAge > 61 && userAge < 65) // Om personen är äldre än, eller 61, och under 65 skrivs ansSix ut.
            {
                Console.WriteLine(name + " " + surname + ", " + ansSix);
            }
            else if (userAge > 100) // Om personen lyckats passera 100år!
            {
                Console.WriteLine(name + " " + surname + ", " ansSeven);
            }


            Console.Write("\nPress any key.");
            Console.ReadLine();
            goto Start; // går tillbaka till "Start" ovan.

        }
    }
}
