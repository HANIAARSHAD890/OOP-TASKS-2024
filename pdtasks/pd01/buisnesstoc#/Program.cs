using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace buisnessToC_
{
    internal class Program
    {
 
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        // all headers----------------------------------------------------------------- 
        static void Main(string[] args)
        {   
            /////functions calling
           /* loadmessoff(messoffday, messofftime, filename7);

            loadupdatemesstimings(openbreakfasttime, opendinnertime, closebreakfasttime, closedinnertime, filename6);
            load(peopleList, ref usercount, filename1);  /// sign in 
            loaddinnerorbreakfast(breakfast, dinner, days, filenamedb);
            loadratingstars(stars, filename3, star);
            loadaboutus(welcome, excellence, effeciency, purpose, contactus, email, phone, filename4);
            loadratebreakfastordinner(Ratesdinner, Ratesbreakfast, filename5);
            storefeedbacks(customerfeedbacks, feedbackitration, filename8);*/

            //variable  for checking
            string check;
        string checkanswer;
        bool adminoption = false;
        bool customeroption = false;
        //filesnames
        string filename8 = "customerfeedbacks.txt";
        string filename7 = "messoffday.txt";
        string filename6 = "messtimings.txt";
        string filename5 = "ratedinnerorbreakfast.txt";
        string filename4 = "aboutus.txt";
        string fileName = "signin.txt";
        string filenamedb = "dinnerorbreakfast.txt";
        string filename3 = "ratingstars.txt";
        string option1 = "";
        bool option2 = false;
        //counter variables 
        int usercount = 0;
        int currentitration = 0;
        int j = 0;
            //--------------------------------------------------
            string welcome = "Welcome to our Online Mess Billing System! We are delighted to introduce you to our business.cpp program, a cornerstone of our commitment to providing you with the best experience and services.";

            string excellence = "Our Commitment to Excellence:At the heart of our services is a dedication to excellence. We strive to offer you the best experience by continuously refining and enhancing our business.cpp program. Expect a user interface that is intuitive, features that meet your needs, and a billing system that is both reliable and efficient.";

            string effeciency = " Save time with a streamlined billing process, allowing you to focus on what matters most.";

            string purpose = "Our Purpose:We understand the importance of smooth operations in managing mess billing, and our purpose is to provide you with a tool that simplifies this aspect of your daily routine. Our business.cpp program is tailored to cater to the specific needs of our users, empowering you to manage mess billing with ease.";

            string contactus = "Contact Us:Have questions or need assistance? We are here for you! Feel free to reach out to our dedicated support team:";

            string email = " supportmessbillingsystem.com";
            string phone = "05551234567";


            string day;
            string breakfastordinner;
            string updatedfood;
            string updatedrate;
            string updatemenu6;
            string upgradefoodtimings = "";
            string upgradedtimingsopen = "";
            string upgradedtimingsclose = "";
            string openbreakfasttime = "7:00am";
            string opendinnertime = "6:30pm";
            string closebreakfasttime = "10:00am";
            string closedinnertime = "7:30pm";
            string messoffday;
            string messofftime;
            string yesorno;
            string timingsattendance;

            // variables receiving the value from the function
            string option;   // option for mainmenu
            string admin;   // option for admin menu
            string customer; // option for customermenu 
            int background;
            string rate;
            string Starview;
            int rateupdates = 0;
            string updatetimings = "";
            string offmess;
            string attendancemark = "";
            string attendanceviewadmin;
            string attendanceviewcustomer;
            int billcalculation = 0;
            int billcalculate = 0;
            int feedbackitration = 0;
            //arrays declaration
            string[] stars;
        string[] breakfast = { "AndaParatha", "alooQeema", "daalChanay ", "alooAnday", "sabzeeChawal", "naanChannay ", "AlooParatha" };

        string[] dinner = { "QuormaChicken", "  alooPalak  ", "  baryani  ", "  roastchips  ", "  cutlus  ", "maashKiDaal", "ChineseChawal" };

        string[] days = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
      /*  string markingattendance[10][7];   //for breakfast */
        string[] billpersons;

        // int ratesbreakfast[7] = { 150, 120, 100, 150, 140, 130, 170 };

        // int ratesdinner[7] = { 150, 140, 120, 150, 130, 130, 180 };

        int[] bill = { 0 };
            /*
                    string attendanceday[100];
                    string breakfastattendance[100];
                    string dinnerattendance[100];
                    int totalbills[10];
                    string dayattendance[100];
                    string attendancebreakfast[100];
                    string attendancedinner[100];
                    string customerfeedbacks[100];
                    string attendancechecker[7];
                    string billnames[10];*/

            string[] Ratesdinner = { "150", "140", "120", "150", "130", "130", "180" };
            string[] Ratesbreakfast = { "150", "120", "100", "150", "140", "130", "170" };
        string[] checkarray = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        string[] messtimings = { "1:00am", "2:00am", "3:00am", "4:00am", "5:00am", "6:00am", "7:00am", "8:00am", "9:00am", "12:00am", "1:00pm", "2:00pm", "3:00pm", "4:00pm", "5:00pm", "6:00pm", "7:00pm", "8:00pm", "9:00pm", "10:00pm", "11:00pm", "12:00pm" };
        int billcount = -1;
        int star = 0;
        int breakfastcount = billcount;  // for breakfast attendance
        int dinnercount = billcount + 1;     // for dinner attendance
        int billitration = 0;

            // declaring variables 
            // variables for sign up function
            string signupname = "";
            string signuprole = "";
            string signuppassword = "";
            string name1 = "";
            string password1 = "";


            //variable  for checking
           /* string option = "";*/
           /* bool option2 = false;*/
        
    
            //-----declaraing objects of the class

            signup student1 = new signup("", "", "");
            signup student2 = new signup("", "", "");
            signup student3 = new signup("", "", "");
            signup student4 = new signup("", "", "");
            signup student5 = new signup("", "", "");
            signup student6 = new signup("", "", "");
            signup student7 = new signup("", "", "");
            signup student8 = new signup("", "", "");
            signup student9 = new signup("", "", "");
            signup student10 = new signup("", "", "");
            // declaring list ofobjects
            List<signup> peopleList = new List<signup>
            { student1,student2,student3,student4,student5,student6,student7,student8,student9,student10 };
          /*  string [] checkarray = { "0", "1", "2", "3", "4", "5" };*/


            // file names 
            string filename1 = "signup.txt";
            // calling load functions 
            // functions 

            while (option != "3")
            {
                option = menu(ref option);
                Console.ReadKey();
                Console.Clear();
                //sign in 
                if (option == "1")
                {

                    peopleList[currentitration].UISignin(ref name1, ref password1);
                    Console.ReadKey();
                    Console.Clear();
                    peopleList[currentitration].Signin(ref usercount, ref name1, ref signuprole, ref password1, ref currentitration, peopleList);

                    //sign in as customer
                    if (option1 == "customer")
                    {
                        Console.WriteLine(" sign in as customer ");
                        Console.ReadKey();
                        customer = "-1";
                        while (customer != "0")
                        {
                            customerprintmenu();
                            customer = customermenu();
                            customeroption = true;

                            Console.ReadKey();
                            Console.Clear();

                            if (customer == "1")
                            {
                                printmenu();
                                dinnerorbreakfast(breakfast, dinner, days);
                            }
                            else if (customer == "2")
                            {
                                displayrates();
                                displayrates(breakfast, dinner, days, Ratesbreakfast, Ratesdinner);

                            }
                            else if (customer == "3")
                            {
                                timings();
                                messopeningtimings(openbreakfasttime, opendinnertime, closebreakfasttime, closedinnertime);
                            }
                            else if (customer == "4")
                            {
                                themes();
                                background = backgroundoption();
                                changebackground(background);
                            }
                            else if (customer == "5")
                            {
                                displayrates();
                                rate = rateus();
                                if (rate == "yes")
                                {
                                    stars[star] = checkratingstars(ref checkanswer);
                                    star++;
                                }
                                else if (rate == " ")
                                {
                                    messageinput();
                                }
                                storeratingstars(stars, filename3, star);
                            }
                            else if (customer == "6")
                            {
                                attendance();
                                attendancemark = UImarkattendance(markingattendance, currentitration, billpersons, billcount, name, days, breakfastcount, dinnercount, billitration);
                            }
                            else if (customer == "7")
                            {
                                attendance();
                                viewattendance(markingattendance, billpersons, billcount, days);
                            }
                            else if (customer == "8")
                            {
                                messbill();
                                // billcalculation = calculateitrationbill(dayattendance, days, attendancechecker, currentitration);
                                // billcalculate = calculatebill(ratesbreakfast, ratesdinner, currentitration, attendancebreakfast, attendancedinner, j, bill);
                                // viewbill(bill, name, currentitration);
                            }
                            else if (customer == "9")
                            {
                                feedbacksheader();
                                customerfeedbacks[feedbackitration] = customerfeedback();
                                feedbackitration++;
                                storefeedbacks(customerfeedbacks, feedbackitration, filename8);

                            }
                            else if (customer == "10")
                            {
                                aboutus(welcome, excellence, effeciency, purpose, contactus, email, phone);
                            }
                            Console.ReadKey();
                            Console.Clear();

                        }
                    }
                    else if (signuprole == "admin")
                    {
                        Console.WriteLine(" sign in as admin ");
                        //sign in as admin 
                        admin = "-1";

                        while (admin != "0")
                        {
                            adminprintmenu();
                            admin = adminmenu();
                            adminoption = true;
                            if (!optionvalidation(admin, checkarray, adminoption, customeroption))
                            {
                                messageoption();


                            }
                           Console.ReadKey();
                            system("cls");

                            if (admin == "1")
                            {
                                dinnerorbreakfast(breakfast, dinner, days);
                            }
                            else if (admin == "2")
                            {
                                displayrates();
                                displayrates(breakfast, dinner, days, Ratesbreakfast, Ratesdinner);
                            }
                            else if (admin == "3")
                            {
                                timings();
                                messopeningtimings(openbreakfasttime, opendinnertime, closebreakfasttime, closedinnertime);
                            }
                            else if (admin == "4")
                            {
                                themes();
                                background = backgroundoption();
                                changebackground(background);
                            }
                            else if (admin == "5")
                            {
                                viewrates();
                                viewstars(stars, star);
                            }
                            else if (admin == "6")
                            {
                                updatemenuu();
                                updatemenu6 = UIupdatemenu(day, breakfastordinner, updatedfood, days);
                                updatemenu(breakfast, dinner, days, day, breakfastordinner, usercount, updatedfood);
                                storedinnerorbreakfast(breakfast, dinner, days, filenamedb);
                            }
                            else if (admin == "7")
                            {
                                viewrates();

                                UIupdaterates(day, breakfastordinner, updatedrate, days);
                                // conversionrates(ratesdinner, ratesbreakfast,Ratesdinner,Ratesbreakfast);   // conversion form int rates to string rates

                                updaterates(Ratesbreakfast, Ratesdinner, days, day, breakfastordinner, usercount, updatedrate);
                                storeratebreakfastordinner(Ratesdinner, Ratesbreakfast, filename5);
                            }
                            else if (admin == "8")
                            {
                                timings();
                                updatetimings = UIupdatemesstimings(ref upgradefoodtimings, ref upgradedtimingsopen,ref  upgradedtimingsclose, messtimings);
                                updatemesstimings(upgradefoodtimings, upgradedtimingsopen, upgradedtimingsclose, openbreakfasttime, opendinnertime, closebreakfasttime, closedinnertime);
                                storeupdatemesstimings(openbreakfasttime, opendinnertime, closebreakfasttime, closedinnertime, filename6);
                            }
                            else if (admin == "9")
                            {
                                offmessprint();
                                offmess = UIMessoff(messoffday,ref messofftime);
                                messoff(messoffday, messofftime, Ratesbreakfast, Ratesdinner, days, usercount, breakfast, dinner);
                                storemesssoff(messoffday, messofftime, filename7);
                                storedinnerorbreakfast(breakfast, dinner, d
                                    
                                    ays, filenamedb);

                            }
                            else if (admin == "10")
                            {
                                attendance();
                                viewattendance(markingattendance, billpersons, billcount, days);
                            }
                            else if (admin == "11")
                            {
                                feedbacksheader();
                                adminviewfeedbacks(customerfeedbacks, feedbackitration, currentitration, name);
                            }
                            else if (admin == "12")
                            {
                                updateaboutus(welcome, excellence, effeciency, purpose, contactus, email, phone, check);
                                storeaboutus(welcome, excellence, effeciency, purpose, contactus, email, phone, filename4);
                            }

                            Console.WriteLine("Press any key to continue";
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }

                }


                else if (option == "2")
                {
                    Console.WriteLine(" sign up ");
                    Console.WriteLine("sign up header");
                    Console.ReadKey();
                    Console.Clear();
                    UISignup(ref signupname, ref signuppassword, ref signuprole);
                    option2 = Signup(ref usercount, ref signupname, ref signuprole, ref signuppassword, ref currentitration, peopleList);
                    if (option2)
                    {
                        Console.WriteLine("Valid");
                        store1signin(peopleList, filename1, ref usercount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        static string menu(ref string option)
        {
            Console.WriteLine("1. Sign in");
            Console.WriteLine("2. Sign up");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your option: ");
            option = Console.ReadLine();
            return option;

        }

        static int UISignup(ref string signupname, ref string signuppassword, ref string signuprole)
        {

            Console.WriteLine("Name: ");
            signupname = Console.ReadLine();
            Console.WriteLine("User password: ");
            signuppassword = Console.ReadLine();
            Console.WriteLine("User role ('admin' or 'customer'): ");
            signuprole = Console.ReadLine();

            return 0;

        }

        static bool Signup(ref int usercount, ref string signupname, ref string signuprole, ref string signuppassword, ref int currentitration, List<signup> peopleList)
        {
            if (!checksignup(signupname, ref usercount, ref signuprole, ref signuppassword, peopleList))
            {
                peopleList[usercount] = new signup(signupname, signuppassword, signuprole);
                usercount++;
                Console.WriteLine("Press any key to continue:");

                return true;
            }
            else
            {
                Console.WriteLine("Press any key to continue:");
                return false;
            }
        }

        static bool checksignup(string signupname, ref int usercount, ref string signuprole, ref string signuppassword, List<signup> peopleList)
        {
            for (int k = 0; k < usercount; k++)
            {

                if (((peopleList[k].name == signupname) && (peopleList[k].role == signuprole) && (peopleList[k].password == signuppassword)))
                {

                    return true;

                }

            }

            return false;

        }




        static bool validoption(string option) // validation for main menu options
        {
            int check = 0;  // taking the ascii code of option 
            int countercheck = 0;   // for counting the characters,so that each character entered will be valid
            check = option[0];
            if ((check >= 49) && (check <= 51))
            {
                countercheck++;
            }

            if ((countercheck == 1))    // options are 1,2 and 3 
                return true;

            else
                return false;
        }
        ///////////////////////////////////////////////FUNCTIONS FOR VALIDATIONS ///////////////////////////////////////////////////////////////////////////////

        static string messageoption()
        {
            Console.WriteLine("You have entered an invalid option");
            return "";

        }


        /// ///////////////////////////////////////////////FUNCTIONS FOR LOAD AND STORE//////////////////////////////////////////////////////////////////////

        static void store1signin(List<signup> peopleList, string fileName, ref int usercount)
        {
            string path = "D:\\OOP labTasks\\lab3\\challenge#3\\bin\\Debug\\signup.txt";
            StreamWriter fileVariable = new StreamWriter(path, true);

            for (int i = 0; i < usercount; i++)
            {
                fileVariable.WriteLine(peopleList[i].name + "," + peopleList[i].password + "," + peopleList[i].role);
            }
            fileVariable.Flush();
            fileVariable.Close();
        }

        static void load(List<signup> peopleList, ref int usercount, string filename1)

        {
            string path = "D:\\OOP labTasks\\lab3\\challenge#3\\bin\\Debug\\signup.txt";

            StreamReader fileVariable = new StreamReader(path);

            if (File.Exists(path))
            {
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    if (record != "")
                    {
                        peopleList[usercount].name = getField(record, 1);
                        peopleList[usercount].password = getField(record, 2);
                        peopleList[usercount].role = getField(record, 3);
                        usercount = usercount + 1;
                    }




                }
                fileVariable.Close();


            }
            else
            {
                Console.WriteLine("file does not exists");
            }
        }

        static string getField(string record, int field)
        {
            int commaCount = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commaCount = commaCount + 1;
                }
                else if (commaCount == field)
                {
                    item = item + record[x];
                }
            }

            return item;

        }

     
    -----------------------------------------------------------------------
          

   


    void dinnerorbreakfast(string[] breakfast , string[] dinner, string[] days)
    {

       Console.WriteLine("BREAKFAST                                        ");
       Console.WriteLine("*************************************************");
            Console.WriteLine("{0,-20}{1,-20}", "DAYS", "FOOD");
            Console.WriteLine("*************************************************");
        for (int i = 0; i <= 6; i++)
        {
                Console.WriteLine("{0,-20}{1,-20}", days[i], breakfast[i]);
                Console.WriteLine("*************************************************");
        }
            Console.WriteLine("");
            Console.WriteLine("");



            Console.WriteLine(" DINNER                                           ");
       Console.WriteLine(" *************************************************");
            Console.WriteLine("{0,-20}{1,-20}", "DAYS", "FOOD");
            Console.WriteLine(" *************************************************");
        for (int i = 0; i <= 6; i++)
        {
                Console.WriteLine("{0,-20}{1,-20}", days[i], breakfast[i]);
                Console.WriteLine("*************************************************");
        }





    }

    string adminmenu()
    {
        string optionSelected;
       Console.WriteLine("  1.see menu");
       Console.WriteLine("  2.display rates");
       Console.WriteLine("  3.See timings   ");
       Console.WriteLine("  4.Change text colour");
       Console.WriteLine("  5.View rates");
       Console.WriteLine("  6.update menu");
       Console.WriteLine("  7.update rates");
       Console.WriteLine("  8.update timings");
       Console.WriteLine("  9.For closing of mess ");
       Console.WriteLine("  10.view attendance");
       Console.WriteLine("  11.View customer feedbacks");
       Console.WriteLine("  12.Update Aboutus page");
       Console.WriteLine("  0.Back");
       Console.WriteLine("  Enter your option: ");
            optionSelected = Console.ReadLine();

        return optionSelected;



    }
    string customermenu()
    {
        string option;
       Console.WriteLine("  1.see menu");
       Console.WriteLine("  2.display rates");
       Console.WriteLine("  3.See timings   ");
       Console.WriteLine("  4.Change text colour");
       Console.WriteLine("  5.Rate us ");
       Console.WriteLine("  6.Mark attendance");
       Console.WriteLine("  7.view attendance");
       Console.WriteLine("  8.View bill");
       Console.WriteLine("  9.Givefeedbacks");
       Console.WriteLine("  10.About us page");
       Console.WriteLine("  0.Back");

       Console.WriteLine("  Enter your option: ";
    option= Console.ReadLine();
        return option;



    }
    void displayrates(string []breakfast, string []dinner, string[] days, string[] Ratesbreakfast, string []Ratesdinner)

    {
       Console.WriteLine(" BREAKFAST                                          ");
       Console.WriteLine(" ****************************************************************************");
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", "DAYS", "FOODS", "RATES");

            Console.WriteLine(" ****************************************************************************");
        for (int i = 0; i <= 6; i++)
        {
                Console.WriteLine("{0,-20}{1,-20}{2,-20}", days[i], breakfast[i], Ratesbreakfast[i]);
             
           Console.WriteLine("****************************************************************************");
        }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("DINNER");
       Console.WriteLine(" *******************************************************************************  ");
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", "DAYS", "FOODS", "RATES");
            Console.WriteLine(" *******************************************************************************  ");
        for (int i = 0; i <= 6; i++)
        {

                Console.WriteLine("{0,-20}{1,-20}{2,-20}", days[i], breakfast[i], Ratesdinner[i]);

                Console.WriteLine("**********************************************************************************  ");
        }

    }
    static void messopeningtimings(ref string openbreakfasttime, ref string opendinnertime ,ref string closebreakfasttime,ref  string closedinnertime)
    {

       Console.WriteLine("MESS OPENING TIMINGS");
       Console.WriteLine("");
       Console.WriteLine("FOR BREAKFAST   :");
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", openbreakfasttime, "To", closebreakfasttime);

            Console.WriteLine("FOR DINNER   ");
            Console.WriteLine("{0,-20}{1,-20}{2,-20}", opendinnertime, "To", closedinnertime);

        }


   static  void changebackground(int backopt)
    {
        if (backopt == 1)
        {

                Console.ForegroundColor = ConsoleColor.Cyan;
          }

        else if (backopt == 2)
        {
                Console.ForegroundColor = ConsoleColor.Green;

               

            }
        else if (backopt == 3)
        {
                Console.ForegroundColor = ConsoleColor.DarkBlue;

            }
        }
    static int backgroundoption()
    {
        int option = 0;
       Console.WriteLine("which background you want to choose:");
       Console.WriteLine("1.BLUE");
       Console.WriteLine("2.GREEN");
       Console.WriteLine("3.DarkBlue");
       Console.WriteLine("Enter your option ...");
            option= int.Parse(Console.ReadLine());
        return option;
    }



    string rateus()
    {
        string validation;   // validation for yes or no 
        string yesorno;
       Console.WriteLine("Do you  want to rate us?('yes ' OR 'no')");
            validation =Console.ReadLine();
        if ((validation == "yes") || (validation == "no"))
        {
            yesorno = validation;
            return yesorno;
        }
        else
        {

            return " ";
        }

    }
    static string checkratingstars(ref string checkanswer)
    {

        // string checkanswer;
        string service = " ";
       Console.WriteLine("How was our service");
       Console.WriteLine("1.*****");
       Console.WriteLine("2.****");
       Console.WriteLine("3.***");
       Console.WriteLine("4.**");
       Console.WriteLine("5.*");
       Console.WriteLine("Enter your answer in steric form (i.e '*')");
        checkanswer=Console.ReadLine();


    }
    static void viewstars(string[] stars, ref int star)
    {
        for (int a = 0; a < star; a++)
        {
                Console.WriteLine($"FEEDBACK NO. {a + 1}");


                Console.WriteLine( stars[a]);
           Console.WriteLine("");
        }

    }
    static string UIupdatemenu(ref string day, ref string breakfastordinner, ref string updatedfood, string[] days)
    {
        int count = 0;   // to count whether all of the required inputs are correct
        string check1;  // for validation
        string check2;   // for validation
        string check3;    // for validation
       Console.WriteLine(" Enter the day for which menu you want to update (i.e 'monday' or 'tuesday',etc ): ";

       Console.WriteLine("Enter which type of food you want to update (i.e breakfast or dinner) ";
      check2 = Console.ReadLine();
        if (breakfastdinnerchecking(check2))
        {
            count++;
        }
       Console.WriteLine("Enter the updated food");
       check3 = Console.ReadLine();
            if (alphabeticvalidation(check3))
        {
            count++;
        }
        if (count == 3)
        {
            breakfastordinner = check2;
            updatedfood = check3;
        }
        else
        {
            messageinput();
        }
        return "0";
    }


    string updatemenu(string[] breakfast, string[] dinner, string[] days, ref string day,ref string breakfastordinner,ref int usercount,ref string updatedfood)
    {
        string answer = " ";
        for (int k = 0; k < 7; k++)
        {
            if ((days[k] == day) && (breakfastordinner == "breakfast"))

            {
                breakfast[k] = updatedfood;
                answer = breakfast[k];

            }
            else if ((days[k] == day) && (breakfastordinner == "dinner"))
            {
                dinner[k] = updatedfood;
                answer = dinner[k];

            }
        }



        return answer;
    }
    string updaterates(string[] Ratesbreakfast, string[] Ratesdinner, string[] days, ref string day,ref string breakfastordinner,ref int usercount,ref string updatedrate)
    {
        // string answer = " ";
        for (int k = 0; k < 7; k++)
        {
            if ((days[k] == day) && (breakfastordinner == "breakfast"))

            {
                Ratesbreakfast[k] = updatedrate;



                //  answer = Ratesbreakfast[k];

            }
            else if ((days[k] == day) && (breakfastordinner == "dinner"))
            {
                Ratesdinner[k] = updatedrate;
                // answer = Ratesdinner[k];

            }
        }
        return " ";
    }
    static string UIupdaterates(ref string day,ref  string breakfastordinner,ref string updatedrate,ref string[] days)
    {

        string check;  // for validation;  
       Console.WriteLine(" Enter the day for which menu you want to update: (i.e 'monday' or 'tuesday',etc) ";
            check = Console.ReadLine();
        if (!daysvalidation(check, days))
        {
           /* messageinput();*/
        }
        else
        {
            day = check;
           Console.WriteLine("Enter which type of food you want to update (i.e breakfast or dinner) ";
          check = Console.ReadLine();
            if (!breakfastdinnerchecking(check))
            {
             /*   messageinput();*/
            }
            else
            {
                breakfastordinner = check;
               Console.WriteLine("Enter the updated rate ";
               check = Console.ReadLine();
                    if (!numbervalidation(check))
                {
                 /*   messageinput();*/
                }
                else
                {
                    updatedrate = check;
                    return "";   //   it's in else condition so that space is not created in the file 
                }
            }


        }
    }

    static string UIupdatemesstimings(ref string upgradefoodtimings, ref string upgradedtimingsopen, ref string upgradedtimingsclose , string[] messtimings)
    {
        string check;   // for validation

       Console.WriteLine(" For which type of food  do you want to upgrade the timings : (i.e breakfast or dinner) ";
        check= Console.ReadLine();
            if (!breakfastdinnerchecking(check))
        {
                messageinput();
            }
        else
        {
            upgradefoodtimings = check;
           Console.WriteLine("what are the timings (write in this format 'X:XX  am/pm' NOTE: Do not left any space while writing)");
           Console.WriteLine("opening timings: ");
                check= Console.ReadLine();
            if (!messtimingsvalidation(check, messtimings))
            {
                messageinput();
            }
            else
            {
                upgradedtimingsopen = check;
               Console.WriteLine("closing timings: ";
                Console.ReadLine();check;
                if (!messtimingsvalidation(check, messtimings))
                {
                    messageinput();
                }
                else
                {
                    upgradedtimingsclose = check;
                }

            }
        }

    }


    string updatemesstimings(ref string upgradefoodtimings,ref string upgradedtimingsopen, ref string upgradedtimingsclose ,ref string openbreakfasttime, ref string opendinnertime, ref string closebreakfasttime,ref int closeddinnertime)
    {
        if (upgradefoodtimings == "breakfast")
        {
            openbreakfasttime = upgradedtimingsopen;
            closebreakfasttime = upgradedtimingsclose;
        }
        else if (upgradefoodtimings == "dinner")
        {
            opendinnertime = upgradedtimingsopen;
            opendinnertime = upgradedtimingsclose;
        }
        return "0";
    }
   static string UIMessoff(string messoffday, ref string messofftime)

    {

       Console.WriteLine("Enter the day you wanted to off the mess?( i.e 'monday' or 'tuesday',etc) ";
            messoffday= Console.ReadLine();
       Console.WriteLine("For which time you wanted to off (i.e 'beakfast' or 'dinner' ) ";
            messofftime=Console.ReadLine();
        return "0";
    }
  static  string messoff(ref string messoffday,ref string messofftime, string[] Ratesbreakfast, string[] Ratesdinner, string[] days, ref int usercount, string[] breakfast, string[] dinner)
    {

        string answer = " ";
        for (int k = 0; k < 7; k++)
        {
            if ((days[k] == messoffday) && (messofftime == "breakfast"))

            {

                breakfast[k] = "off";
                Ratesbreakfast[k] = "0";
                answer = breakfast[k];

            }
            else if ((days[k] == messoffday) && (messofftime == "dinner"))
            {
                dinner[k] = "off";
                Ratesdinner[k] = "0";
                answer = dinner[k];

            }
        }
        return answer;
    }
  /*static  string UImarkattendance(string  [0,7] markingattendance, ref int currentitration, string []billpersons, ref int billcount, string[] name, string[] days, ref int breakfastcount, ref int dinnercount, ref int billitration)

    {
        int itrationofbill = 0;

        int numbercatcher = 0; // for receiving value from function
        int numbercheck; // for validation of checking numnber
        string check;  // for validation
        string yesorno;
        string attendingday;  // stored day for attendance
       Console.WriteLine("Do you want to mark your attendance? ('yes' or 'no')");
            check= Console.ReadLine();
        if (!funcyesorno)
        {
            messageinput();
        }
        else
        {
            yesorno = check;
            if (yesorno == "yes")
            {

                // numbercheck=billcount+1;  //  for temporary testing of bill count
               Console.WriteLine("Mark your attendance carefully because you can mark your attendance for only once ");
               Console.WriteLine("Enter the name of day(i.e monday ,tuesday etc) ");
                    attendingday= Console.ReadLine();
                    *//*  numbercatcher = returnnumber(attendingday, days);*/
                   /* if (!checkingattendance(markingattendance, numbercatcher, billcount, breakfastcount, dinnercount))
                    {
                        showmessage();
                    }*/
                   /* else
                    {*/

                       /* if (!nameinbillpersons(billpersons, name, currentitration, billcount, billitration))
                        {
                            billcount++;
                            itrationofbill = billcount;
                            billpersons[billcount] = name[currentitration];
                            cout << billcount;
                        }
                        else
                    {
                        itrationofbill = billitration;

                    }*/

                 /*  Console.WriteLine("Do you want for breakfast? ('yes'  or 'no') ";*/
                /*    markingattendance[itrationofbill][numbercatcher]= Console.ReadLine();*//*
                    //Console.WriteLine("Do you want for dinner? ('yes'  or 'no') ";
                    // Console.ReadLine();markingattendance[billcount][numbercatcher+1];
             *//*   }
            }*//*

            // breakfastcount=breakfastcount+2;
            // dinnercount=dinnercount+2;
            return "0";

        }
            return "0";
    }*/

    static int returnnumber(string day, string[] days)
    {
        int number = 0;
        for (int i = 0; i < 7; i = i + 1)
        {
            if (days[i] == day)
            {
                number = i;
                number = number + 1;
            }
        }
        return number;
    }
    /*void viewattendance(string  [,]markingattendance, string billpersons[], int &billcount, string days[])
    {
        for (int i = 0; i <= billcount; i++)
        {
            for (int j = 0; j < 7; j++)
            {
               Console.WriteLine( markingattendance, billpersons[i], " ");

            }
                Console.WriteLine("");
        }*/

        //Console.WriteLine(" ATTENDANCE                                          ");
        //Console.WriteLine("**************************************************************************************************");
        // cout << left << setw(20) << "NAMES" << left << setw(20) << "DAY"<<left << setw(20) <<"BREAKFAST" <<left << setw(20) <<"DINNER"<< endl;
        //Console.WriteLine("**************************************************************************************************");
        // for (int i = 0; i <= j; i++)
        // {
        //     cout << left << setw(20) <<name[i] << left << setw(20) << attendanceday[i]<<left << setw(20) <<breakfastattendance[i]<<left << setw(20) <<dinnerattendance[i]<< endl;


    }



    //      }
    //           int calculateitrationbill( string dayattendance[],string days[],string attendancechecker[],int &currentitration)
    //    {

    //            int j = 0;
    //            for (int i = 0; i <= 6;i++)
    //           {

    //             if (dayattendance[currentitration]==days[i])
    //             {
    //                 attendancechecker[i]=days[i];              
    //                   j = i;
    //             }
    //           }
    //            return j;
    //        }
    //          int calculatebill(int ratesbreakfast[],int ratesdinner[],int &currentitration,string attendancebreakfast[], string attendancedinner[],int &j,int bill[])
    //       {
    //           int totalbills = 0;


    //               if ((attendancebreakfast[currentitration] == "yes") && (attendancedinner[currentitration] == "yes"))
    //               {
    //                   totalbills = ratesbreakfast[j] + ratesdinner[j];
    //               }
    //               else if ((attendancebreakfast[currentitration] == "yes") && (attendancedinner[currentitration] == "no"))
    //               {
    //                   totalbills = ratesbreakfast[j];
    //               }
    //               else if ((attendancebreakfast[currentitration] == "no") && (attendancedinner[currentitration] == "yes"))
    //               {
    //                   totalbills = ratesdinner[j];
    //               }
    //  bill[currentitration]= bill[currentitration] +totalbills;




    //           return 0;
    //       }
    //   int viewbill ( int bill[],string name[],int &currentitration)
    //        {
    //        Console.WriteLine("BILL CALCULATION                                       ");                                                           
    //    Console.WriteLine("*************************************************"); 
    //     cout << left<<setw(20)<<"NAMES"<<left<<setw(20)<<"BILLS"<<left<<setw(20)<<"*"<< endl;
    //    Console.WriteLine("*************************************************");
    //      cout << left << setw(20) << name[currentitration] << left << setw(20) << bill[currentitration] << left << setw(20) <<"*"<< endl;                            


    //        }



    //  int adminviewbill ( int bill[],string name[],int &billcount,string billnames[])
    //        {
    //        Console.WriteLine("BILL CALCULATION                                       ");                                                           
    //    Console.WriteLine("*************************************************"); 
    //     cout << left<<setw(20)<<"NAMES"<<left<<setw(20)<<"BILLS"<<left<<setw(20)<<"*"<< endl;
    //    Console.WriteLine("*************************************************");
    //     for (int i=0;i<=billcount;i++)
    //      cout << left << setw(20) <<" " << left << setw(20) << bill[i] << left << setw(20) <<"*"<< endl;

    //        }

    static string customerfeedback()
    {
          string line;
         Console.WriteLine("Write your feedback here .");
        Console.ReadLine();
       Console.WriteLine("Thankyou for your feedback.");
        return line;
    }

    void adminviewfeedbacks(string customerfeedbacks[], ref int feedbackitration,ref  int currentitration,List<signup>name
        )
    {
        int counter = 0;
        for (int i = 0; i <= feedbackitration - 1; i++)
        {
            Console.WriteLine("$Feedback: {counter + 1} ");
            Console.WriteLine(customerfeedbacks[i]);
           Console.WriteLine("from " name[currentitration] << endl;
            counter++;
        }
    }

    void aboutus(string &welcome, string &excellence, string &effeciency, string &purpose, string &contactus, string &email, string &phone)
    {
        {
            cout << welcome << endl;
            cout << endl;

            cout << excellence << endl;
            cout << endl;

            cout << effeciency << endl;
            cout << endl;
            cout << purpose << endl;
            cout << endl;

            cout << contactus << endl;
            cout << email << endl;
            cout << phone << endl;
        }
    }

    void updateaboutus(string &welcome, string &excellence, string &effeciency, string &purpose, string &contactus, string &email, string &phone, string &check)
    {

        string yesorno;
        string yesorno1;
        string yesorno2;
        string yesorno3;
        string yesorno4;
        string yesorno5;
        string yesorno6;

        aboutus(welcome, excellence, effeciency, purpose, contactus, email, phone);
       Console.WriteLine(" Do you want to update the content ?('yes' or 'no')";
        Console.ReadLine();check;

        if (!funcyesorno(check))
        {
            messageinput();

        }
        else if (check == "yes")
        {
           Console.WriteLine("Do you want to update the welcoming lines in the page('yes' or 'no')";
            Console.ReadLine();check;
            if (!funcyesorno(check))
            {
                messageinput();
            }
            else if (check == "yes")
            {
                Console.ReadLine();
                getline(cin, yesorno1);
                if (!alphabeticvalidation(yesorno1))
                {
                    messageinput();
                }
                else
                {
                    welcome = yesorno1;
                }

            }

           Console.WriteLine("Do you want to update the level of excellence in the page('yes' or 'no')";
            Console.ReadLine();check;
            if (!funcyesorno(check))
            {
                messageinput();

            }
            else if (check == "yes")
            {
                Console.ReadLine();
                getline(cin, yesorno2);
                if (!alphabeticvalidation(yesorno2))
                {
                    messageinput();
                }
                else
                {
                    excellence = yesorno2;
                }

            }
           Console.WriteLine("Do you want to update the purpose content of the page('yes' or 'no')";
            Console.ReadLine();check;
            if (!funcyesorno(check))
            {
                messageinput();

            }
            else if (check == "yes")
            {
                Console.ReadLine();
                getline(cin, yesorno3);
                if (!alphabeticvalidation(yesorno3))
                {
                    messageinput();
                }
                else
                {
                    purpose = yesorno3;
                }

            }


           Console.WriteLine("Do you want to update the contact us information given in the page('yes' or 'no')";
            Console.ReadLine();check;
            if (!funcyesorno(check))
            {
                messageinput();

            }
            else if (check == "yes")
            {

                Console.ReadLine();
                getline(cin, yesorno4);
                if (!alphabeticvalidation(yesorno4))
                {
                    messageinput();
                }
                else
                {
                    contactus = yesorno4;
                }

            }



           Console.WriteLine("Do you want to update the email Id('yes' or 'no')";
            Console.ReadLine();check;
            if (!funcyesorno(check))
            {
                messageinput();

            }
            else if (check == "yes")
            {
                Console.ReadLine();
                getline(cin, yesorno5);
                if (!emailvalidation(yesorno5))
                {
                    messageinput();
                }
                else
                {
                    email = yesorno5;
                }
            }

           Console.WriteLine("Do you want to update the phone number('yes' or 'no')";
            Console.ReadLine();check;
            if (!funcyesorno(check))
            {
                messageinput();

            }
            else if (check == "yes")
            {
                Console.ReadLine();
                getline(cin, yesorno6);

                if (!numbervalidation(yesorno6))
                {
                    messageinput();
                }
                else
                {
                    phone = yesorno6;
                }
            }

        }


    }


    void menuheader()

    {
        SetConsoleTextAttribute(hConsole, 12);




       Console.WriteLine("@ ___ ___    ___  _____ _____     ____   ____  _      _      ____  ____    ____       _____ __ __  _____ __ __  ______    ___  ___ ___ )");
       Console.WriteLine("@|   T   T  /  _]/ ___// ___/    |    \ l    j| T    | T    l    j|    \  /    T     / ___/|  T  T/ ___/|  T  T|      T  /  _]|   T   T)");
       Console.WriteLine("@| _   _ | /  [_(   \_(   \_     |  o  ) |  T | |    | |     |  T |  _  YY   __j    (   \_ |  |  (   \_ |  |  ||      | /  [_ | _   _ |)");
       Console.WriteLine("@|  \_/  |Y    _]\__  T\__  T    |     T |  | | l___ | l___  |  | |  |  ||  T  |     \__  T|  ~  |\__  T|  ~  |l_j  l_jY    _]|  \_/  |)");
       Console.WriteLine("@|   |   ||   [_ /  \ |/  \ |    |  O  | |  | |     T|     T |  | |  |  ||  l_ |     /  \ |l___, |/  \ |l___, |  |  |  |   [_ |   |   |)");
       Console.WriteLine("@|   |   ||     T\    |\    |    |     | j  l |     ||     | j  l |  |  ||     |     \    ||     !\    ||     !  |  |  |     T|   |   |)");
       Console.WriteLine("@l___j___jl_____j \___j \___j    l_____j|____jl_____jl_____j|____jl__j__jl___,_j      \___jl____/  \___jl____/   l__j  l_____jl___j___j)");
       Console.WriteLine("@  
                                                                                                                               )"<<endl;


    cout << endl;
        SetConsoleTextAttribute(hConsole, 12);
       Console.WriteLine("\t\t---------------------");
       Console.WriteLine("\t\t|     Main Menu     |");
       Console.WriteLine("\t\t---------------------");
        SetConsoleTextAttribute(hConsole, 14);
        cout << endl;
       Console.WriteLine("\t  -------------------------------");
       Console.WriteLine("\t  | Select one option from menu |");
       Console.WriteLine("\t  -------------------------------");
        cout << endl;
        SetConsoleTextAttribute(hConsole, 15);

    }
   static void customerprintmenu()
    {
     
       Console.WriteLine("@                   _                                                                )");
       Console.WriteLine("@                  | |                                                               )");
       Console.WriteLine("@  ___  _   _  ___ | |_   ___   _ __ ___    ___  _ __  _ __ ___    ___  _ __   _   _ )");
       Console.WriteLine("@ / __|| | | |/ __|| __| / _ \ | '_ ` _ \  / _ \| '__|| '_ ` _ \  / _ \| '_ \ | | | |)");
       Console.WriteLine("@ (__ | |_| |\__ \| |_ | (_) || | | | | ||  __/| |   | | | | | ||  __/| | | || |_| |)");
       Console.WriteLine("@ \___| \__,_||___/ \__| \___/ |_| |_| |_| \___||_|   |_| |_| |_| \___||_| |_| \__,_|)");
       Console.WriteLine("@                                                                                  )");
       Console.WriteLine("@                                                                                 )");

    
       Console.WriteLine("\t\t\t   -------------------");
       Console.WriteLine("\t\t\t   |  CUSTOMER MENU  |");
       Console.WriteLine("\t\t\t   -------------------");
   
       Console.WriteLine(" -------------------------------");
       Console.WriteLine(" | Select one option from menu |");
       Console.WriteLine(" -------------------------------");

    }
   static  void adminprintmenu()
    {
      
       Console.WriteLine("@            _             _                                       )");
       Console.WriteLine("@           | |           (_)                                      )");
       Console.WriteLine("@  __ _   __| | _ __ ___   _  _ __   _ __ ___    ___  _ __   _   _ )");
       Console.WriteLine("@ / _` | / _` || '_ ` _ \ | || '_ \ | '_ ` _ \  / _ \| '_ \ | | | |)");
       Console.WriteLine("@| (_| || (_| || | | | | || || | | || | | | | ||  __/| | | || |_| |)");
       Console.WriteLine("@ \__,_| \__,_||_| |_| |_||_||_| |_||_| |_| |_| \___||_| |_| \__,_|)");
       Console.WriteLine("@                                                                  )");
       Console.WriteLine("@                                                                  )");

       Console.WriteLine("\t\t\t   -------------------");
       Console.WriteLine("\t\t\t   |    ADMIN MENU   |");
       Console.WriteLine("\t\t\t   -------------------");
     

      
       Console.WriteLine(" -------------------------------");
       Console.WriteLine(" | Select one option from menu |");
       Console.WriteLine(" -------------------------------");
  
    }
    static void displayrates()
    {
        SetConsoleTextAttribute(hConsole, 12);
       Console.WriteLine("@      _  _              _                              _              )");
       Console.WriteLine("@    | |(_)            | |                            | |             )");
       Console.WriteLine("@  __| | _  ___  _ __  | |  __ _  _   _   _ __   __ _ | |_   ___  ___ )");
       Console.WriteLine("@ / _` || |/ __|| '_ \\ | | / _` || | | | | '__| / _` || __| / _ \\/ __|)");
       Console.WriteLine("@| (_| || |\\__ \\| |_) || || (_| || |_| | | |   | (_| || |_ |  __/\\__ \)");
       Console.WriteLine("@ \__,_||_||___/| .__/ |_| \__,_| \__, | |_|    \__,_| \__| \___||___/)");
       Console.WriteLine("@               | |                __/ |                              )");
       Console.WriteLine("@               |_|               |___/                               )");
       Console.WriteLine("@)");
    }
    
   static  void themes()
    {
        SetConsoleTextAttribute(hConsole, 12);
       Console.WriteLine("@______  __ __    ___  ___ ___    ___  _____)");
       Console.WriteLine("@|      T|  T  T  /  _]|   T   T  /  _]/ ___/)");
       Console.WriteLine("@|      ||  l  | /  [_ | _   _ | /  [_(   \_ )");
       Console.WriteLine("@l_j  l_j|  _  |Y    _]|  \_/  |Y    _]\__  T)");
       Console.WriteLine("@  |  |  |  |  ||   [_ |   |   ||   [_ /  \ |)");
       Console.WriteLine("@  |  |  |  |  ||     T|   |   ||     T\    |)");
       Console.WriteLine("@  l__j  l__j__jl_____jl___j___jl_____j \___j)");
       Console.WriteLine("@                                            )");
        SetConsoleTextAttribute(hConsole, 15);


    }
    static void viewrates()
    {
        SetConsoleTextAttribute(hConsole, 12);
       Console.WriteLine("@ ____    ____  ______  ____    _____)");
       Console.WriteLine("@|    \  /    T|      T|    \  / ___/)");
       Console.WriteLine("@|  D  )Y  o  ||      ||  D  )(   \_ )");
       Console.WriteLine("@|    / |     |l_j  l_j|    /  \__  T)");
       Console.WriteLine("@|    \ |  _  |  |  |  |    \  /  \ |)");
       Console.WriteLine("@|  .  Y|  |  |  |  |  |  .  Y \    |)");
       Console.WriteLine("@l__j\_jl__j__j  l__j  l__j\_j  \___j)");
       Console.WriteLine("@                                    )");
        SetConsoleTextAttribute(hConsole, 15);


    }
   static  void attendance()
    {
        SetConsoleTextAttribute(hConsole, 12);
       Console.WriteLine("@ ____  ______  ______    ___  ____   ___     ____  ____     __    ___ )");
       Console.WriteLine("@ /    T|      T|      T  /  _]|    \ |   \   /    T|    \   /  ]  /  _])");
       Console.WriteLine("@Y  o  ||      ||      | /  [_ |  _  Y|    \ Y  o  ||  _  Y /  /  /  [_ )");
       Console.WriteLine("@|     |l_j  l_jl_j  l_jY    _]|  |  ||  D  Y|     ||  |  |/  /  Y    _])");
       Console.WriteLine("@|  _  |  |  |    |  |  |   [_ |  |  ||     ||  _  ||  |  /   \_ |   [_ )");
       Console.WriteLine("@|  |  |  |  |    |  |  |     T|  |  ||     ||  |  ||  |  \     ||     T)");
       Console.WriteLine("@l__j__j  l__j    l__j  l_____jl__j__jl_____jl__j__jl__j__j\____jl_____j)");
       Console.WriteLine("@                                                                       )");
       Console.WriteLine("@                                                                       )");
        SetConsoleTextAttribute(hConsole, 15);
    }
   static  void offmessprint()
    {
        SetConsoleTextAttribute(hConsole, 12);
       Console.WriteLine("@  ___   _____  _____  ___ ___    ___  _____ _____)");
       Console.WriteLine("@ /   \ |     ||     ||   T   T  /  _]/ ___// ___/)");
       Console.WriteLine("@Y     Y|   __j|   __j| _   _ | /  [_(   \_(   \_ )");
       Console.WriteLine("@|  O  ||  l_  |  l_  |  \_/  |Y    _]\__  T\__  T)");
       Console.WriteLine("@|     ||   _] |   _] |   |   ||   [_ /  \ |/  \ |)");
       Console.WriteLine("@l     !|  T   |  T   |   |   ||     T\    |\    |)");
       Console.WriteLine("@ \___/ l__j   l__j   l___j___jl_____j \___j \___j)");
       Console.WriteLine("@                                                 )");
        SetConsoleTextAttribute(hConsole, 15);
    }
    static void messbill()
    {
        SetConsoleTextAttribute(hConsole, 12);
       Console.WriteLine("@     ___ ___    ___  _____ _____     ____   ____  _      _     )");
       Console.WriteLine("@|   T   T  /  _]/ ___// ___/    |    \ l    j| T    | T    )");
       Console.WriteLine("@| _   _ | /  [_(   \_(   \_     |  o  ) |  T | |    | |    )");
       Console.WriteLine("@|  \_/  |Y    _]\__  T\__  T    |     T |  | | l___ | l___ )");
       Console.WriteLine("@|   |   ||   [_ /  \ |/  \ |    |  O  | |  | |     T|     T)");
       Console.WriteLine("@|   |   ||     T\    |\    |    |     | j  l |     ||     |)");
       Console.WriteLine("@l___j___jl_____j \___j \___j    l_____j|____jl_____jl_____j)");
       Console.WriteLine("@                                                           )");
        SetConsoleTextAttribute(hConsole, 15);
    }

   static void updatemenuu()
    {
        SetConsoleTextAttribute(hConsole, 12);
       Console.WriteLine("@ __ __  ____   ___     ____  ______    ___      ___ ___    ___  ____   __ __ )");
       Console.WriteLine("@|  T  T|    \ |   \   /    T|      T  /  _]    |   T   T  /  _]|    \ |  T  T)");
       Console.WriteLine("@|  |  ||   _/ |  D  Y|     |l_j  l_jY    _]    |  \_/  |Y    _]|  |  ||  |  |)");
       Console.WriteLine("@|  :  ||  |   |     ||  _  |  |  |  |   [_     |   |   ||   [_ |  |  ||  :  |)");
       Console.WriteLine("@l     ||  |   |     ||  |  |  |  |  |     T    |   |   ||     T|  |  |l     |)");
       Console.WriteLine("@ \__,_jl__j   l_____jl__j__j  l__j  l_____j    l___j___jl_____jl__j__j \__,_j)");
       Console.WriteLine("@                                                                             )");
        SetConsoleTextAttribute(hConsole, 15);
    }

    static void printmenu()
    {
        SetConsoleTextAttribute(hConsole, 12);
       Console.WriteLine("@     ___ ___ ___ ____ __    __     )");
       Console.WriteLine("@    |   T   T  /  _]|    \ |  T  T)");
       Console.WriteLine("@    | _   _ | /  [_ |  _  Y|  |  |)");
       Console.WriteLine("@    |  \_/  |Y    _]|  |  ||  |  |)");
       Console.WriteLine("@    |   |   ||   [_ |  |  ||  :  |)");
       Console.WriteLine("@    |   |   ||     T|  |  |l     |)");
       Console.WriteLine("@    l___j___jl_____jl__j__j \__,_j)");
       Console.WriteLine("@                                  )");
        SetConsoleTextAttribute(hConsole, 15);
    }
    void feedbacksheader()
    {
        SetConsoleTextAttribute(hConsole, 12);
       Console.WriteLine("@_____  _____  _____ ______ ______   ___   _____  _   __ _____ )");
       Console.WriteLine("@  ___||  ___||  ___||  _  \| ___ \ / _ \ /  __ \| | / //  ___|)");
       Console.WriteLine("@| |_   | |__  | |__  | | | || |_/ // /_\ \| /  \/| |/ / \ `--. )");
       Console.WriteLine("@|  _|  |  __| |  __| | | | || ___ \|  _  || |    |    \  `--. \)");
       Console.WriteLine("@| |    | |___ | |___ | |/ / | |_/ /| | | || \__/\| |\  \/\__/ /)");
       Console.WriteLine("@\_|    \____/ \____/ |___/  \____/ \_| |_/ \____/\_| \_/\____/ )");
       Console.WriteLine("@                                                               )");
        SetConsoleTextAttribute(hConsole, 15);

    }

   static void signinheader()
    {

        SetConsoleTextAttribute(hConsole, 12);
       Console.WriteLine("@ _____  _____  _____  _   _   _____  _   _ )");
       Console.WriteLine("@/  ___||_   _||  __ \| \ | | |_   _|| \ | |)");
       Console.WriteLine("@\ `--.   | |  | |  \/|  \| |   | |  |  \| |)");
       Console.WriteLine("@ `--. \  | |  | | __ | . ` |   | |  | . ` |)");
       Console.WriteLine("@/\__/ / _| |_ | |_\ \| |\  |  _| |_ | |\  |)");
       Console.WriteLine("@\____/  \___/  \____/\_| \_/  \___/ \_| \_/)");
       Console.WriteLine("@                                           )");
        SetConsoleTextAttribute(hConsole, 15);

    }
    static void signupheader()
    {
        SetConsoleTextAttribute(hConsole, 12);
       Console.WriteLine("@ _____  _____  _____  _   _  _   _ ______ )");
       Console.WriteLine("@/  ___||_   _||  __ \| \ | || | | || ___ \)");
       Console.WriteLine("@\ `--.   | |  | |  \/|  \| || | | || |_/ /)");
       Console.WriteLine("@ `--. \  | |  | | __ | . ` || | | ||  __/ )");
       Console.WriteLine("@/\__/ / _| |_ | |_\ \| |\  || |_| || |    )");
       Console.WriteLine("@\____/  \___/  \____/\_| \_/ \___/ \_|    )");
       Console.WriteLine("@                                          )");
        SetConsoleTextAttribute(hConsole, 15);
    }

    void storedinnerorbreakfast(string breakfast[], string dinner[], string days[], string filenamedb)
    {
        string line;
        fstream file;
        file.open(filename1, ios::out);
        for (int i = 0; i < 7; i++)
        {
            file << breakfast[i] << "," << dinner[i] << "," << days[i] << endl;
        }

        file.close();

    }

    void loaddinnerorbreakfast(string breakfast[], string dinner[], string days[], string filenamedb
        )
    {
        string line;
        fstream data;
        data.open(filename1, ios:: in);
        for (int i = 0; i < 7; i++)
        {
            getline(data, line);
            if (line != "")
            {
                breakfast[i] = getField(line, 1);
                dinner[i] = getField(line, 2);
                days[i] = getField(line, 3);
            }
        }

        data.close();
    }

    void storeratingstars(string stars[], string filename3, int &star)

    {
        string line;
        fstream file;
        file.open(filename3, ios::out);
        for (int j = 0; j < star; j++)
        {
            file << stars[j] << endl;
        }

        file.close();

    }

    void loadratingstars(string stars[], string filename3, int &star)
    {
        string line;
        fstream data;
        data.open(filename3, ios:: in);
        while (!data.eof())
        {
            getline(data, line);
            if (line != "")
            {
                stars[star] = getField(line, 1);
                star++;
            }
        }
        data.close();
    }

    void storeaboutus(string &welcome, string &excellence, string &effeciency, string &purpose, string &contactus, string &email, string &phone, string filename4)
    {
        string line;
        fstream file;
        file.open(filename4, ios::out);
        file << welcome << "," << excellence << "," << effeciency << "," << purpose << "," << contactus << "," << email << endl;
        file.close();
    }

    void loadaboutus(string &welcome, string &excellence, string &effeciency, string &purpose, string &contactus, string &email, string &phone, string filename4)
    {
        string line;
        fstream file;
        file.open(filename4, ios:: in);
        getline(file, line);
        if (line != "")
        {
            welcome = getField(line, 1);

            excellence = getField(line, 2);
            effeciency = getField(line, 3);
            purpose = getField(line, 4);
            contactus = getField(line, 5);
            email = getField(line, 6);
            phone = getField(line, 7);
        }

        file.close();

    }

    void loadratebreakfastordinner(string Ratesdinner[], string Ratesbreakfast[], string filename5)
    {
        string line;
        fstream data;
        data.open(filename5, ios:: in);
        for (int i = 0; i < 7; i++)
        {
            getline(data, line);
            if (line != "")
            {
                Ratesdinner[i] = getField(line, 1);
                Ratesbreakfast[i] = getField(line, 2);
            }
        }

        data.close();

    }

    void storeratebreakfastordinner(string Ratesdinner[], string Ratesbreakfast[], string filename5)

    {
        string line;
        fstream file;
        file.open(filename5, ios::out);
        for (int i = 0; i < 7; i++)
        {
            file << Ratesbreakfast[i] << "," << Ratesdinner[i] << endl;
        }

        file.close();

    }

    void storeupdatemesstimings(string &openbreakfasttime, string &opendinnertime, string &closebreakfasttime, string &closedinnertime, string filename6)
    {
        string line;
        fstream file;
        file.open(filename6, ios::out);
        file << openbreakfasttime << "," << opendinnertime << "," << closebreakfasttime << "," << closedinnertime << endl;

        file.close();

    }

    void loadupdatemesstimings(string &openbreakfasttime, string &opendinnertime, string &closebreakfasttime, string &closedinnertime, string filename6)
    {
        string line;
        fstream file;
        file.open(filename6, ios:: in);
        getline(file, line);
        if (line != "")
        {
            openbreakfasttime = getField(line, 1);

            opendinnertime = getField(line, 2);

            closebreakfasttime = getField(line, 3);
            closedinnertime = getField(line, 4);
        }

        file.close();
    }

    void storemesssoff(string &messoffday, string &messofftime, string filename7)
    {
        string line;
        fstream file;
        file.open(filename7, ios:: out);
        file << messoffday << "," << messofftime << ",");

        file.close();
    }

    void loadmessoff(string &messoffday, string &messofftime, string filename7)
    {
        string line;
        fstream file;
        file.open(filename7, ios::in);
        getline(file, line);
        if (line != "")
        {
            messoffday = getField(line, 1);

            messofftime = getField(line, 2);

        }

        file.close();
    }

    void storefeedbacks(string customerfeedbacks[], int &feedbackitration, string filename8)
    {
        string line;
        fstream file;
        file.open(filename8, ios::out);
        for (int j = 0; j < feedbackitration; j++)
        {
            file << customerfeedbacks[j] << endl;
        }

        file.close();

    }

    void loadfeedbacks(string customerfeedbacks[], int &feedbackitration, string filename8)
    {
        string line;
        fstream data;
        data.open(filename8, ios:: in);
        while (!data.eof())
        {
            getline(data, line);
            if (line != "")
            {
                customerfeedbacks[feedbackitration] = getField(line, 1);

                feedbackitration++;
            }
        }

        data.close();
    }

    string conversionrates(int ratesdinner[], int ratesbreakfast[], string Ratesdinner[], string Ratesbreakfast[])  // problematic
    {
        string convertedrate1;  // for dinnerrates
        string convertedrate2;  // for breakfastrates
        for (int i = 0; i < 7; i++)
        {
            convertedrate1 = to_string(ratesdinner[i]);
            Ratesdinner[i] = convertedrate1;
            convertedrate2 = to_string(ratesbreakfast[i]);
            Ratesbreakfast[i] = convertedrate2;
        }

        return " ";
    }



    bool optionvalidation(string checkoption, string checkarray[], bool &adminoption, bool &customeroption)
    {
        int n = 0;
        if (adminoption)
        {
            n = 12;
        }
        else if (customeroption)
        {
            n = 10;
        }
        int countercheck = 0;   // for counting the character,so to check that the character entered will be valid
        for (int i = 0; i <= n; i++)
        {
            if (checkarray[i] == checkoption)
            {
                countercheck++;

            }

        }

        if (countercheck == 1)
        {
            adminoption = false;
            customeroption = false;
            n = 0;
            countercheck = 0;
            return true;

        }
        else
        {
            return false;
        }
    }

    static string messageoption()
    {
       Console.WriteLine("You have entered an invalid option";

    }

    static string messageinput()
    {
       Console.WriteLine("You have entered an invalid input");
    }
    static bool rolevalidation(string role)
    {
        if ((role == "customer") || (role == "admin"))
        {
            return true;
        }

        return false;
    }

   static  bool check(string checkanswer)
    {
        int check = 0;  // for taking the ascii code of the name variable 
        int countercheck = 0;   // for counting the characters,so that each character entered will be valid

        for (int i = 0; i <= checkanswer.Length; i++)
        {
            check = checkanswer[i];
            if (check == 42)    // 42 is ascii code of '*'
            {
                countercheck++;
            }
        }

        if (countercheck == checkanswer.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

   static  bool checkabout(string variable)
    {
        int check = 0;  // for taking the ascii code of the name variable 
        int countercheck = 0;   // for counting the characters,so that each character entered will be valid

        for (int i = 0; i <= variable.Length; i++)
        {
            check = variable[i];
            if (((check >= 97) && (check <= 122)) || (check == 32) || ((check >= 65) && (check <= 90))) // 122 and 97 are  alphabetsin lower case, 32 is for space,
            {
                countercheck++;
            }
        }

        if (countercheck == variable.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool funcyesorno(string check)
    {

        if ((check == "yes") || (check == "no"))
        {
            return true;
        }
    }

    static bool alphabeticvalidation(string alphabet)
    {
        int check = 0;  // for taking the ascii code of the name variable 
        int countercheck = 0;   // for counting the characters,so that each character entered will be valid

        for (int i = 0; i <= alphabet.Length; i++)
        {
            check = alphabet[i];
            if (((check >= 97) && (check <= 122)) || ((check >= 65) && (check <= 90)) || (check == 32)) // for lower case  || for upper case  ||  for space 
            {
                countercheck++;
            }
        }

        if (countercheck == alphabet.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
   static bool numbervalidation(string number)
    {
        int check = 0;  // for taking the ascii code of the name variable 
        int countercheck = 0;   // for counting the characters,so that each character entered will be valid

        for (int i = 0; i <= number.Length; i++)
        {
            check = number[i];
            if ((check >= 48) && (check <= 57))
                countercheck++;
        }


        if (countercheck == number.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

  static  bool daysvalidation(string day, string[] days)
    {


        int countercheck = 0;   // for counting the character,so to check that the character entered will be valid
        for (int i = 0; i <= 6; i++)
        {
            if (days[i] == day)
            {
                countercheck++;
            }

        }

        if (countercheck == 1)
        {

            return true;

        }
        else
        {
            return false;
        }
    }
    static  bool breakfastdinnerchecking(string breakfastordinner)
    {
        if ((breakfastordinner == "breakfast") || (breakfastordinner == "dinner"))
        {
            return true;
        }

        return false;
    }
    static bool emailvalidation(string email)
    {
        int check = 0;  // for taking the ascii code of the name variable 
        int countercheck = 0;   // for counting the characters,so that each character entered will be valid

        for (int i = 0; i <= email.Length; i++)
        {
            check = email[i];
            if (check == 64)    // 64 is ascii code of '@'
            {
                countercheck++;
            }
        }

        if (countercheck == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
        bool messtimingsvalidation(string varmesstimings, string[] messtimings)
        {

            int countercheck = 0;   // for counting the character,so to check that the character entered will be valid
            for (int i = 0; i <= 23; i++)
            {
                if (messtimings[i] == varmesstimings)
                {
                    countercheck++;
                }

            }

            if (countercheck == 1)
            {

                return true;

            }
            else
            {
                return false;
            }
        }
        /* bool checkingattendance(string markingattendance[][7], int numbercatcher, int &billcount, int &breakfastcount, int &dinnercount)
         {
             if (((markingattendance[billcount][numbercatcher]) == "yes") || ((markingattendance[billcount][numbercatcher]) == "no"))
             {
                 return false;
             }
             else
             {
                 return true;

             }
         }*/
        static void showmessage()
    {
       Console.WriteLine("You cannot mark your attendance again as you have already marked tyour attendance for once");
    }

 /*   bool nameinbillpersons(string billpersons[], string name[], int &currentitration, int &billcount, int &billitration)
    {
        int count = 0;
        for (int i = 0; i <= billcount; i++)
        {
            if (billpersons[i] == name[currentitration])
            {
                billitration = i;
                count++;
            }

        }
        if (count == 1)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}*/
    }
}
