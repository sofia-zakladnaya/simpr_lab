using System;

namespace airport_reg
{
    class Flight
    {
        public int Number; //Номер рейса
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

       //Расшифровки перечислений 
        public string GetStatusString()
        {
            switch (Status)
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
            switch (Type)
            {
                case FlightType.International:
                    return "Международный";
                default:
                    return "Внутренний";
            }
        }

        public string GetDestinationString()
        {
            switch (Destination)
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
            Type = (FlightType)rand.Next(0, 2);
            //случайный город(в зависимости от типа)
            if(Type==FlightType.Domestic)
            {
                Destination = (FlightDestination)rand.Next(0,7);
            }
            else
            {
                Destination = (FlightDestination)rand.Next(7, 14);
            }

            Status=FlightStatus.NoRegistration;

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
