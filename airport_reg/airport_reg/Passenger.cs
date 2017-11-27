using System;
using System.Collections.Generic;


namespace airport_reg
{
    public class Passenger
    {
        public Ticket Ticket; //Билет пассажира
        public bool HandLuggage; //Есть ли ручная кладь?
        public Baggage Baggage; //Багаж
        public Pet Pet; //Животные

        //Пассажир с билетом на рейс с заданным номером и случайными параметрами
        public Passenger(Flight flight,int num)
        {
            Ticket = new Ticket(flight.Number,num,flight.type);
            HandLuggage = Coin();
            Random rnd = new Random(DateTime.Now.Millisecond);
            //С вероятностью 0,9 генерируем пассажира с оплаченным багажом и животными
            double r = rnd.NextDouble();
            if (r > 0.1)
            {
                if (Coin() && Ticket.WithBaggage)
                {
                    Baggage = new Baggage();
                }
                else
                {
                    Baggage = null;
                }

                if (Coin() && Ticket.WithPets)
                {
                    Pet = new Pet();
                }
                else
                {
                    Pet = null;
                }
            }
            //С вероятностью 0,1 генерируем случайные параметры
            else
            {
                if (Coin())
                {
                    Baggage = new Baggage();
                }
                else
                {
                    Baggage = null;
                }

                if (Coin())
                {
                    Pet = new Pet();
                }
                else
                {
                    Pet = null;
                }
            }

        }

        //Наличие багажа
        public bool HaveBaggage()
        {
            return (Baggage != null);
        }
        //Наличие животных
        public bool HavePet()
        {
            return (Pet != null);
        }

        //Случайное логическое значение
        public static bool Coin()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);

            return (rnd.Next(0, 2) == 1);
        }

        //проверка оплаты багажа
        private bool CheckBaggage()
        {
            if((!Ticket.WithBaggage) && HaveBaggage())
            {
                return false;
            }

            return true;
        }

        //проверка оплаты животных
        private bool CheckPet()
        {
            if ((!Ticket.WithPets) && HavePet())
            {
                return false;
            }

            return true;
        }

        private bool Registr()
        {
            return true;
        }

        private bool Board()
        {
            return true;
        }

    }
}
