using System;

namespace airport_reg
{
    class Flight
    {
        public int Number { get; set; }//Номер рейса
        public string Type { get { return GetTypeString(); } } //Тип рейса
        public string Destination { get { return GetDestinationString(); } } //Назначение
        public string Status { get { return GetStatusString(); } } //Статус рейса

        public FlightType type; //Тип рейса
        public FlightDestination destination; //Назначение
        public FlightStatus status; //Статус рейса




        //Рейс международный?
        private bool IsInternational()
        {
            return (type==FlightType.International);
        }

        //Регистрация открыта?
        private bool IsOpen()
        {
            return (status==FlightStatus.RegistrationOpen);
        }

        //Изменить статус рейса
        private FlightStatus OpenReg(FlightStatus NewStatus)
        {
            status = NewStatus;

            return status;
        }

       //Расшифровки перечислений 
        public string GetStatusString()
        {
            switch (status)
            {
                case FlightStatus.RegistrationOpen:
                    return "Регистрация";
                case FlightStatus.RegistrationClose:
                    return "Регистрация завершена";
                case FlightStatus.Departed:
                    return "Улетел";
                default:
                    return "Нет регистрации";
            }
        }

       public string GetTypeString()
        {
            switch (type)
            {
                case FlightType.International:
                    return "Международный";
                default:
                    return "Внутренний";
            }
        }

        public string GetDestinationString()
        {
            switch (destination)
            {
                case FlightDestination.Moscow:
                    return "Москва";
                case FlightDestination.StPetersburg:
                    return "Санкт-Петербург";
                case FlightDestination.Simferopol:
                    return "Симферополь";
                case FlightDestination.Chelyabinsk:
                    return "Челябинск";
                case FlightDestination.Kaliningrad:
                    return "Калининград";
                case FlightDestination.Ufa:
                    return "Уфа";
                case FlightDestination.Vladivostok:
                    return "Владивосток";
                case FlightDestination.NewYork:
                    return "Нью-Йорк";
                case FlightDestination.London:
                    return "Лондон";
                case FlightDestination.Madrid:
                    return "Мадрид";
                case FlightDestination.Havana:
                    return "Гавана";
                case FlightDestination.Deli:
                    return "Дели";
                case FlightDestination.Paris:
                    return "Париж";
                default:
                    return "Рио-де-Жанейро";
            }
        }

        //Конструктор
        public Flight(int number,Random rand)
        {
            Number = number;
            //случайный тип рейса
            type = (FlightType)rand.Next(0, 2);
            //случайный город(в зависимости от типа)
            if(type==FlightType.Domestic)
            {
                destination = (FlightDestination)rand.Next(0,7);
            }
            else
            {
                destination = (FlightDestination)rand.Next(7, 14);
            }

            status=FlightStatus.NoRegistration;

        }

    }

    //Возможные назначения
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
