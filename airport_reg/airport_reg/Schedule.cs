using System;
using System.Collections.Generic;


namespace airport_reg
{
    public class Schedule
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

        

        //Переключение рейсов
        public void Switch()
        {
            bool fl = false;
            for (int i = Departures; i < FlightList.Count; i++)
            {
                fl = false;
                switch (FlightList[i].status)
                {
                    case FlightStatus.NoRegistration:
                        {
                            FlightList[i].status = FlightStatus.RegistrationOpen;
                            fl = true;
                            break;
                        }
                    case FlightStatus.RegistrationOpen:
                        {
                            FlightList[i].status = FlightStatus.RegistrationClose;
                            break;
                        }
                    case FlightStatus.RegistrationClose:
                        {
                            FlightList[i].status = FlightStatus.Departed;
                            Departures++;
                            break;
                        }

                }
                //открыли новый рейс
                if(fl)
                {
                    break;
                }
                
            }
            
        }

        //Случайный рейс из списка
        public Flight RandomFlight()
        {
            int i;
            Random rnd = new Random(DateTime.Now.Millisecond);
            //С вероятностью 0,9 генерируем пассажира на открытый рейс
            double r = rnd.NextDouble();
            int lastopen = FlightList.FindLastIndex(x => x.status == FlightStatus.RegistrationOpen);
            //Нет рейса с открытой регистрацией
            if(lastopen<0)
            {
                i = rnd.Next(0,FlightList.Count); // выдаём любой рейс
            }
            else
            {
                //открытый рейс
                if(r>0.1)
                {
                    i = lastopen;
                }
                //опоздал
                else
                {
                    i = rnd.Next(0, lastopen);
                }
            }
            return FlightList[i];
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
