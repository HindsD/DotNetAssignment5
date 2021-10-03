using System;
using System.IO;

namespace DotNetTicketSysCLASSES
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "Tickets.csv";
            Ticket ticket = new Ticket();
            string choice;
            do
            {
                Console.WriteLine("1) List all tickets.");
                Console.WriteLine("2) Create new ticket.");
                Console.WriteLine("Enter any other key to exit.");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    if (File.Exists(file))
                    {
                        StreamReader sr = new StreamReader(file);
                        
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            ticket.arr = line.Split('|');
                            Console.WriteLine(ticket.Display());
                            
                        }
                        sr.Close();
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                }
                else if (choice == "2")
                {
                    StreamWriter sw = new StreamWriter(file);
                    for (int i = 1; i < 10; i++)
                    {
                        ticket.ticketId = i;
                        Console.WriteLine("Enter a Ticket (Y/N)?");
                        string resp = Console.ReadLine().ToUpper();
                        if (resp != "Y") { break; }
                        Console.WriteLine("Enter the summary of the ticket.");
                        ticket.summary = Console.ReadLine();
                        Console.WriteLine("Enter the current status.");
                        ticket.status = Console.ReadLine();
                        Console.WriteLine("Enter the priority.");
                        ticket.priority = Console.ReadLine();
                        Console.WriteLine("Who submitted the ticket?");
                        ticket.submitter = Console.ReadLine();
                        Console.WriteLine("Who is assigned the ticket?");
                        ticket.assigned = Console.ReadLine();
                        Console.WriteLine("Who is watching?");
                        ticket.watching = Console.ReadLine();

                        sw.WriteLine(ticket.WriteTicket());
                    }
                    sw.Close();
                }
            } while (choice == "1" || choice == "2");
        }
    }
}
