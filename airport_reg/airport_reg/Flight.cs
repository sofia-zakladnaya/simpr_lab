using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport_reg
{
    class Flight
    {
        public int Number; //Номер рейса
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
