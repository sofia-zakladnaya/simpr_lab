

namespace airport_reg
{
    class Flight
    {
        private int Number; //Номер рейса
        private FlightType Type; //Тип рейса
        private FlightStatus Status; //Статус рейса
        private FlightDestination Destination; //Назначение

        //Рейс международный?
        private bool IsInternational()
        {
            return (Type==FlightType.International);
        }

        //Регистрация открыта?
        private bool IsOpen()
        {
            return (Status==FlightStatus.RegistrationOpen);
        }

        //Изменить статус рейса
        private FlightStatus OpenReg(FlightStatus NewStatus)
        {
            Status = NewStatus;

            return Status;
        }

        //Конструктор
        public Flight(int number)
        {
            Number = number;
            //TODO: генерация рандомного рейса
        }

    }

    //Возможные назначения(переделать на 2 массива строк)
    public enum FlightDestination
    {
        Moscow,
        StPetersburg,
        Simferopol,
        Chelyabinsk,
        Kaliningrad,
        Ufa,
        Vladivostok,
        NewYork,
        London,
        Madrid,
        Havana,
        Deli,
        Paris,
        RioDeJaneiro
    }

    //Типы рейсов
    public enum FlightType
    {
        International,
        Domestic
    };

    //Статусы рейсов
    public enum FlightStatus
    {
        NoRegistration,
        RegistrationOpen,
        RegistrationClose,
        Departed
    };
}
