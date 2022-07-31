using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButikSinemaSalonuApp
{
    public class SinemaApp
    {
        public SinemaApp()
        {
            Kurulum();
            Menu();
            Secim();
        }
        static Sinema sinema;
        static void Kurulum()
        {
            Console.WriteLine("---Butik Sinema Salonu---");
            Console.Write("Movie name: ");
            string movieName = Console.ReadLine();
            Console.Write("Capacity: ");
            int capacity = int.Parse(Console.ReadLine());   
            Console.Write("Full Ticket Price: ");
            double fullTicketPrice = double.Parse(Console.ReadLine());
            Console.Write("Half Ticket Pice: ");
            double halfTicketPrice = double.Parse(Console.ReadLine());

            sinema = new Sinema(movieName, capacity, fullTicketPrice, halfTicketPrice);
        }
        static void Menu()
        {
            Console.WriteLine("1-Sell Ticket(S)" +
                "\n2-Return Ticket(R)" +
                "\n3-Statue Information(I)" +
                "\n4-Exit(X)");
        }
        static void Secim()
        {
            while (true)
            {
                Console.Write("Your Selection: ");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "S":
                        SellTicket();
                        break;
                    case "1":
                        SellTicket();
                        break;
                    case "R":
                        ReturnTicket();
                        break;
                    case "2":
                        ReturnTicket();
                        break;
                    case "I":
                        StatueInformation();
                        break;
                    case "3":
                        StatueInformation();
                        break;
                    case "X":
                        return;                       
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Wrong selection. Please try again!");
                        break;
                }
            }
        }

        private static void StatueInformation()
        {
            Console.WriteLine($"-Statue Information-\n" +
                $"Movie: {sinema.MovieName}" +
                $"\nCapacity: {sinema.Capacity}" +
                $"\nFull Ticket Price: {sinema.FullTicketPrice}" +
                $"\nHalf Ticket Price: {sinema.HalfTicketPrice}" +
                $"\nSum of Full Ticket Number: {sinema.SumOfFullTicketNumber}" +
                $"\nSum of Half Ticket Number: {sinema.SumOfHalfTicketNumber}" +
                $"\nCiro: {sinema.Ciro}" +
                $"\nEmpty Seat number: {sinema.EmptySeatNumber}");           
        }

        private static void ReturnTicket()
        {
            Console.WriteLine("-Return Ticket-");
            Console.Write("How many Full Ticket Number to Return: ");
            int returnFullTicketNumber = int.Parse(Console.ReadLine());
            Console.Write("How many Half Ticket Number to Return: ");
            int returnHalfTicketNumber = int.Parse(Console.ReadLine());
            sinema.ReturnTicket(returnFullTicketNumber,returnHalfTicketNumber);
        }

        private static void SellTicket()
        {
            Console.WriteLine("-Sell Ticket-");
            Console.Write("Full Ticket Number: ");
            int fullTicketNumber = int.Parse(Console.ReadLine());
            Console.Write("Half Ticket Number: ");
            int halfTicketNumber = int.Parse(Console.ReadLine());
            sinema.SellTicket(fullTicketNumber, halfTicketNumber);

            
        }
    }
}
