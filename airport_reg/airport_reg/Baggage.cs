//using System;
//using System.Collections.Generic;
//using System.Linq;


namespace airport_reg
{
    public class Baggage
    {
        private bool Fragility; //Багаж хрупкий?

        public Baggage()
        {
            Fragility = Passenger.Coin();
        }

        public bool IsFragile()
        {
            return Fragility;
        }

        //Упаковка(для хрупкого багажа)
        private void Pack()
        {

        }
        //Регистрация
        private void Registr()
        {

        }
        //Отправка
        private void Depart()
        {

        }
    }
}
