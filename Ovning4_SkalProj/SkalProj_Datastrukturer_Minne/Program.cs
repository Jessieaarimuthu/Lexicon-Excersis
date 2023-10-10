using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        


    /// <summary>
    /// The main method, vill handle the menues for the program
    /// </summary>
    /// <param name="args"></param>
    static void Main()
        {
         
            
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

           

            string exit = "C";
            List<string> theList;
            theList = new List<string>();
            do
            {
                
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        theList.Remove(value);
                        break;
                    default:
                        Console.WriteLine("Please enter value with + or - prefix to add to the list");
                        break;
                }
                Console.WriteLine("Continue 'C' or Exit 'E' ?");
                exit = Console.ReadLine();
            } while (exit == "C");

            foreach(string l in theList)
            {
                Console.WriteLine(l);
            }
            
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Queue<string> q = new Queue<string>();
            q.Enqueue("Hello");
            q.Enqueue("How are you?");
            q.Enqueue("How's the weather today?");

            while (q.Count > 0)
                Console.WriteLine(q.Dequeue());

            Queue<string> ICAQ = new Queue<string>();
            ICAQ.Enqueue("Kalle");
            ICAQ.Enqueue("Greta");
            ICAQ.Enqueue("Olle");

            while (ICAQ.Count > 0)
                Console.WriteLine(ICAQ.Dequeue());
                
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            Stack<string> s = new Stack<string>();
            Console.WriteLine("Enter a string to reverse using stack");
            string toreverse = Console.ReadLine();

            int count = toreverse.Length;
            for (int i = 0; i < count; i++)
                s.Push(toreverse.Substring(i));

            while (s.Count > 0)
                Console.WriteLine(s.Pop());
                    
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            Console.WriteLine("Enter parenthesis to check");
            String paranthesis = Console.ReadLine();
            Stack<string> s = new Stack<string>();
            string strresult = " is valid";
            int count = paranthesis.Length;
            for(int i=0; i<count; i++)
            {
                string param = paranthesis.Substring(i,1);
              
                if (param == "(" || param == "{" || param == "[")
                    s.Push(param);
                else if (param == ")" || param == "}" || param == "]")
                {
                    switch(param)
                    {
                        case ")":
                            if (s.Pop() != "(")
                                strresult = "Invalid";
                                 break;
                        case "}":
                            if(s.Pop()!="{")
                                strresult = "Invalid";
                            break;
                        case "]":
                            if (s.Pop() != "[")
                                strresult = "Invalid";
                            break;
                        default:
                            strresult = "default" + param;
                            break;
                    }
                }
            }

            if (!s.Any())
            {
                Console.WriteLine();
                Console.WriteLine(paranthesis + strresult);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(paranthesis + " is invalid");
            }



            Console.WriteLine();
            
            
        }
        
}

}



