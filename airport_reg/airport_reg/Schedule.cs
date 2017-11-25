using System;
using System.Collections.Generic;


namespace airport_reg
{
    class Schedule
    {
        public List<Flight> FlightList; //Список рейсов
        public int Departures; //Количество отправленных рейсов


        //Регистрация всех рейсов завершена?
        public bool IsFinished()
        {
            if(Departures<FlightList.Count)
            {
                return false;
            }

            return true;
        }

        //Открыть регистрацию на рейс
        public void Open(int FlightNumber)
        {
            //TODO
        }

        //Закрыть регистрацию на рейс
        private void Close(int FlightNumber)
        {
            //TODO
        }


        public Schedule(int FlightNum)
        {
            //TODO
            //Инициализируем генератор случайных чисел и список рейсов
            Random rand = new Random();
            FlightList = new List<Flight>();

            for(int i=0; i<FlightNum; i++)
            {
                //генерируем случайный рейс и заносим в список
                Flight fl = new Flight(i + 1,rand);
                FlightList.Add(fl);
            }
            Departures = 0;
        }
    }

}
