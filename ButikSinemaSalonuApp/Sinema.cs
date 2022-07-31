using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButikSinemaSalonuApp
{
    class Sinema
    {
        public string MovieName;
        public int Capacity;
        public double FullTicketPrice;
        public double HalfTicketPrice;
        public int SumOfFullTicketNumber;
        public int SumOfHalfTicketNumber;
        public double Ciro;
        public int EmptySeatNumber;

        public Sinema(string movieName, int capacity, double fullTicketPrice, double halfTicketPrice)
        {
            MovieName = movieName;
            Capacity = capacity;
            FullTicketPrice = fullTicketPrice;
            HalfTicketPrice = halfTicketPrice;
            EmptySeatNumber = Capacity;            
        }
        public void SellTicket(int fullTicketNumber, int halfTicketNumber)
        {
            if(fullTicketNumber+halfTicketNumber>Capacity || fullTicketNumber > Capacity || halfTicketNumber > Capacity)
            {
                Console.WriteLine("Wrong Entry!");
            }
            else if ((fullTicketNumber+halfTicketNumber)>EmptySeatNumber)
            {
                Console.WriteLine($"Not enough seat! emty seat number: {EmptySeatNumber}");
            }
            else
            {
                SumOfFullTicketNumber += fullTicketNumber;
                SumOfHalfTicketNumber = SumOfHalfTicketNumber + halfTicketNumber;
                CalculateEmtySeat(SumOfFullTicketNumber, SumOfHalfTicketNumber);
                //Ciro = (SumOfFullTicketNumber * FullTicketPrice) + (SumOfHalfTicketNumber * HalfTicketPrice);
                CalculateCiro(SumOfFullTicketNumber, SumOfHalfTicketNumber);
                Console.WriteLine("Process Completed.");
            }           
        }     
        public void ReturnTicket(int returnFullTicketNumber, int returnHalfTicketNumber)
        {
            if (returnFullTicketNumber > SumOfFullTicketNumber || 
                returnHalfTicketNumber > SumOfHalfTicketNumber)
            {
                Console.WriteLine("Wrong Entry. Returned ticket cannot be higher than sold ticket.");
            }
            else
            {
                SumOfFullTicketNumber -= returnFullTicketNumber;
                SumOfHalfTicketNumber -= returnHalfTicketNumber;
                CalculateCiro(SumOfFullTicketNumber, SumOfHalfTicketNumber);
                CalculateEmtySeat(SumOfFullTicketNumber, SumOfHalfTicketNumber);
            }
            
        }
        private void CalculateCiro(int sumOfFullTicketNumber,int sumOfhalfTicketNumber)
        {
            Ciro = (SumOfFullTicketNumber * FullTicketPrice) + (SumOfHalfTicketNumber * HalfTicketPrice);
            
        }
        private void CalculateEmtySeat(int sumOfFullTicketNumber, int sumOfHalfTicketNumber)
        {
            EmptySeatNumber = Capacity - (SumOfFullTicketNumber + SumOfHalfTicketNumber);
        }
    }
}
