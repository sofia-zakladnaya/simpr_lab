using System;
using System.Collections.Generic;

namespace airport_reg
{
    class Ticket
    {
        private Flight Flight; //Рейс
        private bool WithBaggage; //Входит ли в билет багаж
        private bool WithPets; //Входит ли в билет перевозка животных

        //Регистрация открыта?
        private bool CheckRegStatus()
        {
            return true; 
        }

        //Багаж оплачен?(false, если есть неоплаченный багаж)
        private bool CheckBaggage()
        {
            return true;
        }

        //Животные оплачены?(false, если есть неоплаченные животные)
        private bool CheckPets()
        {
            return true;
        }
    }
}
