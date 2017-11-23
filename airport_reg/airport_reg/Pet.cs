

namespace airport_reg
{
    class Pet
    {
        private PetSize Size; //Размер животного
        private bool Tranquility; //Животное легко переносит перелёты?


        //Животное крупное?
        private bool IsBig()
        {
            return true;
        }

        //Животное легко переносит перелёты?
        private bool IsTranquile()
        {
            return true;
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
