using System;
using System.Collections.Generic;

namespace airport_reg
{
    public class Ticket
    {
        public int Number; //Номер билета
        public int FlightNumber; //Рейс
        public bool WithBaggage; //Входит ли в билет багаж
        public bool WithPets; //Входит ли в билет перевозка животных

        //Билет на заданный рейс и со случайными параметрами
        public Ticket(int flightnumber, int number)
        {
            Number = number;
            FlightNumber = flightnumber;
            WithBaggage = Passenger.Coin();
            WithPets = Passenger.Coin();
        }


        //Регистрация открыта?
        private bool CheckRegStatus()
        {
            return true; 
        }

        //Багаж оплачен?
        public string CheckBaggage()
        {
            if(WithBaggage)
            {
                return "+";
            }
            else
            {
                return "-";
            }
        }

        //Животные оплачены?
        public string CheckPets()
        {
            if (WithPets)
            {
                return "+";
            }
            else
            {
                return "-";
            }
        }
    }
}
