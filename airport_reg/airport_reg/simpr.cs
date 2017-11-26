using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace airport_reg // не забудьте поменять на свой namespace //
{

    public class MyHookClass : NativeWindow
    {
        //
        //   Класс работы с сообщениями.
        //   Автор: Кузнецов Андрей (А-16-05)
        //
        //   Примечание: для выполнение действий в этом классе рекомендуется создать 
        //   элемент класса, который используется для работы основной программы 
        //   например: public solver solv; // в объявлениях
        //   тогда в WndProc доступ к функциям будет как solv.function(...)
        //   а доступ из основной программы(с формы) к значеним и функциям решателя
        //   будет осуществлён так:
        //   MyHookClass hook; // в пространстве имён формы
        //   hook= new MyHookClass(); // в инициализаторе формы
        //   hook.solv.function(...); // доступ к значениям и функциям (например из таймера, для обновления графики)
        //   
        //  

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern uint RegisterWindowMessage(string lpString);

        //public Airport solver;
        uint simpr_cond;
        uint simpr_act;
        RegForm Win;
        int fc = 0; //счётчик рейсов(для теста)

        public MyHookClass(IntPtr hWnd, RegForm f)
        {
            simpr_cond = 49788;//RegisterWindowMessage("MyMessage"); // регистрируем своё сообщение
            simpr_act = 49773; RegisterWindowMessage("MyMessage1");
            this.AssignHandle(hWnd);
            //solver = new Airport();
            Win = f;
            //Win.DrawStart(solver);   Прописать свою отрисовку
        }

        protected override void WndProc(ref Message m) // в эту функцию приходят все сообщения от СИМПРА
        {
            
            int /*wparamhi, */wparamlo, wparam, lParam;
            lParam = (int)m.LParam;
            wparam = (int)m.WParam;
            //wparamhi = wparam >> 16;
            wparamlo = wparam & 0xffff;
            //проверка условий
            if (m.Msg == simpr_cond)
            {
                Win.Log("Проверка условия");
                switch (wparamlo)
                {
                    //Таблица 1
                    case 1:
                        {
                            Win.Log("Таблица 1 - проверка условий");
                            switch (lParam)
                            {
                                //Регистрация на все рейсы завершена?
                                case 1:
                                {
                                    Win.Log("Регистрация на все рейсы завершена?");
                                    if (fc < Airport.FlightNum)
                                    {
                                        fc++;
                                        Win.Log("Не завершена: fc="+fc.ToString());                                        
                                        m.Result = new IntPtr(0);
                                    }
                                    else
                                    {
                                        Win.Log("Завершена");
                                        
                                        m.Result = new IntPtr(1);
                                    }
                                    break;

                                }
                                


                            }
                            break;
                        }
                    //Таблица 2
                    case 2:
                        {
                            Win.Log("Таблица 2 - проверка условий");
                            switch (lParam)
                            {
                                //Регистрация на рейс открыта?
                                case 1:
                                    {
                                        Win.Log("Регистрация на рейс открыта?");
                                        m.Result = new IntPtr(1);

                                        break;
                                    }
                                //Рейс международный?
                                case 2:
                                    {
                                        Win.Log("Рейс международный?");
                                        m.Result = new IntPtr(1);
                                        break;
                                    }
                                //Есть ручная кладь?
                                case 3:
                                    {
                                        Win.Log("Есть ручная кладь?");
                                        m.Result = new IntPtr(1);
                                        break;
                                    }
                                //Билет с багажом?
                                case 4:
                                    {
                                        Win.Log("Билет с багажом?");
                                        m.Result = new IntPtr(1);
                                        break;
                                    }
                                //Есть багаж?
                                case 5:
                                    {
                                        Win.Log("Есть багаж?");
                                        m.Result = new IntPtr(1);
                                        break;
                                    }
                                //Билет с перевозкой животных?
                                case 6:
                                    {
                                        Win.Log("Билет с перевозкой животных?");
                                        m.Result = new IntPtr(1);
                                        break;
                                    }
                                //Есть животные?
                                case 7:
                                    {
                                        Win.Log("Есть животные?");
                                        m.Result = new IntPtr(1);
                                        break;
                                    }
                            }
                            break;
                                    
                        }
                    //Таблица 3
                    case 3:
                        {
                            Win.Log("Таблица 3 - проверка условий");
                            switch (lParam)
                            {
                                //Багаж хрупкий?
                                case 1:
                                    {
                                        Win.Log("Багаж хрупкий?");
                                        m.Result = new IntPtr(1);
                                        break;
                                    }
                                //Есть животные?
                                case 2:
                                    {
                                        Win.Log("Есть животные?");
                                        m.Result = new IntPtr(1);
                                        break;
                                    }

                            }
                            break;
                        }
                    //Таблица 4
                    case 4:
                        {
                            Win.Log("Таблица 4 - проверка условий");
                            switch (lParam)
                            {
                                //Крупное?
                                case 1:
                                    {
                                        Win.Log("Крупное?");
                                        m.Result = new IntPtr(1);
                                        break;
                                    }
                                //Требуется успокоительное?
                                case 2:
                                    {
                                        Win.Log("Требуется успокоительное?");
                                        m.Result = new IntPtr(1);
                                        break;
                                    }

                            }
                            break;
                        }
                }
            }
            //выполенение действий
            else if(m.Msg == simpr_act)
            {
                Win.Log("Выполение действия");
                switch (wparamlo)
                {
                    //Таблица 1
                    case 1:
                        {
                            Win.Log("Таблица 1 - действия");
                            switch (lParam)
                            {
                                    //Начать обслуживание пассажира
                                    case 1:
                                        {
                                            fc++;
                                            Win.Log("Начать обслуживание пассажира");
                                            break;
                                        }
                                default:
                                    {
                                        Win.Log("Имитация завершена");
                                        break;
                                    }

                            }
                            break;
                        }
                    //Таблица 2
                    case 2:
                        {
                            Win.Log("Таблица 2 - действия");
                            switch (lParam)
                            {
                                //Отправить в кассу для возврата/обмена билета
                                case 1:
                                    {
                                        Win.Log("Отправить в кассу для возврата/обмена билета");
                                        break;
                                    }
                                //Присвоить посадочное место
                                case 2:
                                    {
                                        Win.Log("Присвоить посадочное место");
                                        break;
                                    }
                                //Зарегистрировать ручную кладь
                                case 3:
                                    {
                                        Win.Log("Зарегистрировать ручную кладь");
                                        break;
                                    }
                                //Отправить на посадку на международные рейсы
                                case 4:
                                    {
                                        Win.Log("Отправить на посадку на международные рейсы");
                                        break;
                                    }
                                //Отправить на посадку на внутренние рейсы
                                case 5:
                                    {
                                        Win.Log("Отправить на посадку на внутренние рейсы");
                                        break;
                                    }
                                //Начать регистрацию багажа
                                case 6:
                                    {
                                        Win.Log("Начать регистрацию багажа");
                                        break;
                                    }
                                //Начать регистрацию животных
                                case 7:
                                    {
                                        Win.Log("Начать регистрацию животных");
                                        break;
                                    }
                            }
                            break;
                        }
                    //Таблица 3
                    case 3:
                        {
                            Win.Log("Таблица 3 - действия");
                            switch (lParam)
                            {
                                //Упаковать
                                case 1:
                                    {
                                        Win.Log("Упаковать");
                                        break;
                                    }
                                //Отправить на погрузку
                                case 2:
                                    {
                                        Win.Log("Отправить на погрузку");
                                        break;
                                    }
                                //Начать регистрацию животных
                                case 3:
                                    {
                                        Win.Log("Начать регистрацию животных");
                                        break;
                                    }

                            }
                            break;
                        }
                    //Таблица 4
                    case 4:
                        {
                            Win.Log("Таблица 4 - действия");
                            switch (lParam)
                            {
                                //Дать успокоительное
                                case 1:
                                    {
                                        Win.Log("Дать успокоительное");
                                        break;
                                    }
                                //Отправить в салон
                                case 2:
                                    {
                                        Win.Log("Отправить в салон");
                                        break;
                                    }
                                //Отправить в багаж
                                case 3:
                                    {
                                        Win.Log("Отправить в багаж");
                                        break;
                                    }

                            }
                            break;
                        }
                }
                Application.DoEvents();
                //Thread.Sleep(1000); // если у нас есть визуальное отображение, то задержку можно установить здесь                    
                m.Result = new IntPtr(1); // ответом на запрос действия со стороны СИМПР должна быть единица

            }
            //прочие сообщения
            else 
            {
                
                base.WndProc(ref m); // для всех действий не связанных с СИМПР возвращаем управление программе
            }
           


        }

    }
}
