

namespace airport_reg
{
    class Flight
    {
        private int Number; //Номер рейса
        private FlightType Type; //Тип рейса
        private FlightStatus Status; //Статус рейса

    }

    public enum FlightType
    {
        International,
        Domestic
    };

    public enum FlightStatus
    {
        NoRegistration,
        RegistrationOpen,
        RegistrationClose,
        Departed
    };
}
