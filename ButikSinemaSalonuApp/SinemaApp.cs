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
                }
            }
        }

        private static void StatueInformation()
        {
            throw new NotImplementedException();
        }

        private static void ReturnTicket()
        {
            throw new NotImplementedException();
        }

        private static void SellTicket()
        {
            throw new NotImplementedException();
        }
    }
}
