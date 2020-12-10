using System;

namespace Hotels
{
    class Hotels
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Hotel ");
       
            String entrance = "yes";
            OrderDetails Order = new OrderDetails();
            Issuedetails issue=new Issuedetails();
            while (entrance.Equals("yes"))
            {
                Console.WriteLine("1.Do You want to order: .       2.report an issue.         3.show issue. 4.exit.");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Order.setOrderDetails();
                        break;
                    case 2:
                        issue.setIssuedetails();
                        break;
                    case 3:
                        issue.ShowIssuedetails();
                        break;
                    case 4:
                        entrance = "no";
                        Console.WriteLine("Thankyou ");
                        break;
                    default: 
                    break;
                }

            }

        }
    }
}