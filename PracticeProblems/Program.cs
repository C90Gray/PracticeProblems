using System;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Practice Problems Lesson One


            //Console.WriteLine("Hello,");
            //string messageOne = "My name is Christopher Michael Gray.";
            //string messageTwo = "I'm not really a car guy, but I have always liked the Plymouth Prowler.";
            //string messageThree = "I was never hip to comic books..." +
            //    "But, I do enjoy Netflix's show, The Flash.";
            //string messageFour = "Thank you for taking an interest in me. =]";
            //Console.WriteLine("");
            //Console.WriteLine(messageOne);
            //Console.WriteLine("");
            //Console.WriteLine(messageTwo);
            //Console.WriteLine("");
            //Console.WriteLine(messageThree);
            //Console.WriteLine("");
            //Console.WriteLine(messageFour);
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");

            //messageOne = "                                  0      0";
            //messageTwo = "                                      V    ";
            //messageThree = "                                 I        I";
            //messageFour = "                                  --____-- ";
            //Console.WriteLine(messageOne);
            //Console.WriteLine(messageTwo);
            //Console.WriteLine(messageThree);
            //Console.WriteLine(messageFour);
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");

            //// Practice Problems Lesson Three

            //float total = 7;
            //float variable = 2;
            //Console.WriteLine(total - variable);
            //total = 13;
            //variable = 4;
            //Console.WriteLine(total * variable);
            //total = 40;
            //variable = 8;
            //Console.WriteLine(total / variable);
            //total = 41;
            //variable = 29;
            //Console.WriteLine(total - variable);
            //total = 47;
            //variable = 30;
            //Console.WriteLine(total - variable);
            //total = 12;
            //variable = 3;
            //Console.WriteLine(total / variable);
            //total = 27.10f;
            //variable = 5.12f;
            //Console.WriteLine(total + variable);

            ////Practice Problems Lesson Four
            //ask user for their name
            //compute math
            //use concatonation and indexing to rewrite answers in full sentance form

            float total = 7;
            float variable = 2;
            Console.WriteLine("Please enter your name.");
            String nameMuffins = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Since " + nameMuffins + " already has " + variable + " cups of sugar and needs a total of " + total + ", " + nameMuffins + " will need to add " + (total - variable) + " more cups of sugar to make muffins.");
            variable = 13;
            total = (variable * 4);
            Console.WriteLine("");
            Console.WriteLine("Please enter your name.");
            String nameDinnerOne = Console.ReadLine();
            Console.WriteLine("Please enter your friend's name.");
            String nameDinnerTwo = Console.ReadLine();
            Console.WriteLine("Please enter your friend's name.");
            String nameDinnerThree = Console.ReadLine();
            Console.WriteLine("Please enter your friend's name.");
            String nameDinnerFour = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("{0} and {0}'s three friends, {1}, {2} and {3} all went to dinner and split the check evenly. Since they each paid {4} dollars, their total bill was {5} dollars.", nameDinnerOne, nameDinnerTwo, nameDinnerThree, nameDinnerFour, variable, total);
            total = 40;
            variable = 8;
            float solution = (total / variable);
            Console.WriteLine("");
            Console.WriteLine("Please enter your name.");
            String nameDiapers = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("{0} is getting old and needs diapers because sometimes it's hard to make it to the bathroom. \n{0} has {1} dollars and diapers cost {2} dollers per pack. {0} will be able to buy {3} packs of diapers.", nameDiapers, total, variable, solution);
            total = 41;
            variable = 29;
            Console.WriteLine("");
            solution = (total - variable);
            Console.WriteLine("Please enter your name.");
            string nameChores = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("After cleaning the attic, {0} has {1} dollars. Prior to this, {0} only had {2} dollars. This means that by cleaning the attic, {0} made {3} dollars.", nameChores, total, variable, solution);
            total = 47;
            variable = 30;
            Console.WriteLine("");
            solution = (total - variable);
            Console.WriteLine("Please enter your name.");
            String nameRunOne = Console.ReadLine();
            Console.WriteLine("Please enter your friend's name");
            string nameRunTwo = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Last week {0} ran {3} more miles than {1}. Since {0} ran {2} miles, that means that {1} ran {4} miles.", nameRunOne, nameRunTwo, total, variable, solution);
            total = 12;
            variable = 3;
            Console.WriteLine("");
            solution = (total / variable);
            Console.WriteLine("Please enter your name.");
            string nameEnv = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("{0} went to the store with {1} dollars to buy envelopes. Since envelopes are {2} dollars a piece, {0} can buy {3} envelopes.", nameEnv, total, variable, solution);
            total = 27.10f;
            variable = 5.12f;
            Console.WriteLine("");
            solution = (total + variable);
            Console.WriteLine("Please enter your name.");
            string nameSalad = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("After buying a fresh salad, {0} had ${1} left over. Knowing that the salad cost ${2}, we know that {0} had ${3} before buying the salad.", nameSalad, total, variable, solution);









        }
    }
}
