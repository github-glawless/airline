using System;
using System.Collections.Generic;
using System.Linq;

namespace AirPlaneDemo
{
    class Program
    {

        public enum SeatPosition{
            Window = 0,
            Middle = 1,
            Aisle = 2 
        }

        public struct Seat {
            public string SeatNumber;
            public SeatPosition SeatPosition;
            public bool IsAvailable;
        }

        public class Plane {
            public const int RowCount = 10;
            public const int SeatPerRow = 6;
            public const int SeatCount = RowCount * SeatPerRow;
            public string TailNumber = "NN8042";
            public string FlightNumber = "1";
            public Seat[] Seats = new Seat[SeatCount];

            public Plane() {
                string[] SeatLetters = {"A", "B", "C", "D", "E", "F"} ;
                for (int i = 0 ; i < SeatCount; i++) {
                    string seatLetter = SeatLetters[i % SeatPerRow];
                    Seats[i].SeatNumber = $"{i / SeatPerRow + 1}{seatLetter}";
                    Seats[i].SeatPosition = ((SeatPosition)(Math.Min(i % SeatsPerRow, (SeatsPerRow - 1) - (i % SeatsPerRow))));
                    Seats[i].IsAvailable = true ;
                }
            }
            public void PrintAvailableSeats() {
                Console.WriteLine("Seat Available:");
                foreach (Seat seat in Seats) {
                    
                }
            }









        }

    }
}

        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
        }
