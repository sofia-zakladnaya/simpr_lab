using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport_reg
{
    class Schedule
    {
        public Flight FlightList; //Список рейсов
        private int Departures; //Количество отправленных рейсов


        //Регистрация всех рейсов завершена?
        public bool IsFinished()
        {
            //TODO
            return true;
        }

        //Открыть регистрацию на рейс
        public void Open(int FlightNumber)
        {
            //TODO
        }

        //Закрыть регистрацию на рейс
        public void Close(int FlightNumber)
        {
            //TODO
        }
    }
}
