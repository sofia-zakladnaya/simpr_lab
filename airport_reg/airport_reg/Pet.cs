using System;

namespace airport_reg
{
    public class Pet
    {
        private PetSize Size; //Размер животного
        private bool Tranquility; //Животное легко переносит перелёты?


        public Pet()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);

            Size = (PetSize)rnd.Next(0, 2);
            Tranquility = Passenger.Coin();
        }

        //Животное крупное?
        public bool IsBig()
        {
            return (Size == PetSize.Big);
           
        }

        //Животное легко переносит перелёты?
        public bool IsTranquile()
        {
            return Tranquility;
        }

        //Регистрация животных
        private void Regist()
        {

        }

        //Дать животному успокоительное
        private void Tranquile()
        {

        }

        //Отправка животного
        private bool Depart()
        {
            return true;
        }
    }

    public enum PetSize
    {
        Big,
        Small
    };
}
