namespace ATM2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tBalance = 10000, wBalance, dBalance;
            int Withdrawl;
            int Deposit;
            int Selection;
            int x;


            Console.WriteLine("----------- Welcome to JonoBank -----------");
            Console.WriteLine("Enter your password: ");
            x = int.Parse(Console.ReadLine());
            Console.Clear();
            while (x > 0)
            {
                Console.WriteLine("----------- JonoBank -----------\n");
                Console.WriteLine("1. Check Balance\n");
                Console.WriteLine("2. Make a Withdrawl\n");
                Console.WriteLine("3. Deposit Cash\n");
                Console.WriteLine("4. Quit Service\n");
                //Selecting one of the options
                Console.WriteLine("Please enter one of the options: \n");
                Selection = int.Parse(Console.ReadLine());
                switch (Selection)
                {
                    case 1://Balance Check
                        int yes = 1;
                        int no = 0;
                        int answer;
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------------\n");
                        Console.WriteLine("Your Balance is: R{0}\n", tBalance);
                        Console.WriteLine("------------------------------------------------------\n");
                        Console.WriteLine("Would you like to use another service?\n");
                        Console.WriteLine("(Enter '1' to continue)");
                        answer = int.Parse(Console.ReadLine());
                        if (answer == 1)
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Thank you for using JonoBank");
                            System.Environment.Exit(0);
                        }
                        break;

                    case 2://Withdraw Money
                        Console.Clear();
                        Console.WriteLine("Your balance is: R{0}", tBalance);
                        Console.WriteLine("Enter the amount you want to withdraw: ");
                        Withdrawl = int.Parse(Console.ReadLine());
                        if(Withdrawl > tBalance)
                        {
                            Console.Clear();
                            Console.WriteLine("------------------------------------------------------\n");
                            Console.WriteLine("Insufficient Balance\n");
                            Console.WriteLine("------------------------------------------------------\n");
                            Console.WriteLine("Would you like to use another service?\n");
                            Console.WriteLine("(Enter '1' to continue)");
                            answer = int.Parse(Console.ReadLine());
                            if (answer == 1)
                            {
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Thank you for using JonoBank");
                                System.Environment.Exit(0);
                            }
                        }
                        else if (Withdrawl < tBalance && Withdrawl != 0)
                        {
                            wBalance = tBalance - Withdrawl;
                            Console.WriteLine("------------------------------------------------------\n");
                            Console.WriteLine("Previous Balance: R{0}\n", tBalance);
                            Console.WriteLine("Amount Withdrew: R{0}\n", Withdrawl);
                            Console.WriteLine("Current Balance: R{0}\n", wBalance);
                            Console.WriteLine("------------------------------------------------------\n");
                            Console.WriteLine("Would you like to use another service?\n");
                            Console.WriteLine("(Enter '1' to continue)");
                            answer = int.Parse(Console.ReadLine());
                            if (answer == 1)
                            {
                                Console.Clear();
                                continue;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Thank you for using JonoBank");
                                System.Environment.Exit(0);
                            }
                        }
                        break;

                    case 3://Deposit Money
                        Console.Clear();
                        Console.WriteLine("Enter the amount you want to Deposit: ");
                        Deposit = int.Parse(Console.ReadLine());
                        dBalance = tBalance + Deposit;
                        Console.WriteLine("------------------------------------------------------\n");
                        Console.WriteLine("Previous Balance: R{0}\n", tBalance);
                        Console.WriteLine("Amount Deposited: R{0}\n", Deposit);
                        Console.WriteLine("Your current balance is: R{0}\n", dBalance);
                        Console.WriteLine("------------------------------------------------------\n");
                        Console.WriteLine("Would you like to use another service?\n");
                        Console.WriteLine("(Enter '1' to continue)");
                        answer = int.Parse(Console.ReadLine());
                        if (answer == 1)
                        {
                            Console.Clear();
                            continue;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Thank you for using JonoBank");
                            System.Environment.Exit(0);
                        }
                        break;

                   case 4://Stop using service
                        Console.WriteLine("Thank you for using this ATM service.");
                        break;
                        
                }
                
            }
        }
    }
}