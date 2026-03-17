namespace ExceptionHandling_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment-1
            try
            {
                BankAccount acc = new BankAccount(101, "Pavan", 1000);
                acc.Details();
                Console.WriteLine("Enter Transcation Type (d=Deposite, c=Withdraw):");
                char type = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter Amount:");
                double amt = Convert.ToDouble(Console.ReadLine());
                acc.Transaction(type, amt);
                acc.Details();
            }
            catch(CheckBalanceException ex)
            {
                Console.WriteLine("Exception: "+ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Console.WriteLine();

            try
            {
                MovieTicket mt = new MovieTicket();
                Console.WriteLine("Do You want to Book tickets(yes/no):");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "yes")
                {
                    Console.WriteLine("Enter number of tickets:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    mt.BookTickets(num);
                }
                else
                {
                    Console.WriteLine("Thank You!");
                }
            }
            catch (TicketException ex)
            {
                Console.WriteLine("Execption: " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
