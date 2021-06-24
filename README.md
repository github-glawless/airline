# airline
Airline exercise 
Create a console project for an airline to track available seats on each of their airplanes. To accomplish this, you will need to create the following:

    An Enum for the seat position called SeatPosition with the following options:
        Aisle
        Middle
        Window

    A struct called Seat that represents a seat with the following properties:
        SeatNumber as a string type (15a, 15b, 15c, etc...)
        SeatPosition as the SeatPosition enum
        IsAvailable property as a boolean type

    A Plane class with the following properties:
        A TailNumber property as a string type
        A FlightNumber property as a string type
        A Seats property as a Seat structs array

Each plane should have a total of 60 seats with 10 rows with 6 seats each row.

Set the IsAvailable property to false for all of the Aisle seats.

Print to the console window all of the available seat numbers and their seat position.

Once your application compiles and returns the correct array of available seat numbers and seat positions, add it to a public GitHub repository and paste the link below.
