using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport_reg
{
    class Schedule
    {
        private List<Flight> FlightList; //Список рейсов
        private int Departures; //Количество отправленных рейсов


        //Регистрация всех рейсов завершена?
        private bool IsFinished()
        {
            //TODO
            return true;
        }

        //Открыть регистрацию на рейс
        private void Open(int FlightNumber)
        {
            //TODO
        }

        //Закрыть регистрацию на рейс
        private void Close(int FlightNumber)
        {
            //TODO
        }
    }
}
