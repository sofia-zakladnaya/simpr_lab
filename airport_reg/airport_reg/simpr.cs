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

        public Airport solver;
        uint simpr;
        RegForm Win;
        int time = 0;

        public MyHookClass(IntPtr hWnd, RegForm f)
        {
            simpr = RegisterWindowMessage("MyMessage"); // регистрируем своё сообщение
            this.AssignHandle(hWnd);
            solver = new Airport();
            Win = f;
            //Win.DrawStart(solver);   Прописать свою отрисовку
        }

        protected override void WndProc(ref Message m) // в эту функцию приходят все сообщения от СИМПРА
        {

            int i = 0,wparamhi,wparamlo,wparam;
            int lParam = Convert.ToInt32("" + m.LParam);

            if (m.Msg == simpr)
            {

                wparam = Convert.ToInt32("" + m.WParam);
                wparamhi = wparam / 65536;
                wparamlo = wparam - wparamhi * 65536;

                if (wparamhi == 0)//условия
                {
                    if (wparamlo == 1)// таблица 1 
                    {
                        switch (lParam)
                        {
                          

                        }

                    }
                    else if (wparamlo == 2)// таблица 2 
                    {
                        
                    }
                    else if (wparamlo == 3)// таблица 3
                    {

                    }
                    else if (wparamlo == 4)// таблица 4 
                    {

                    }
                }
                else if (wparamhi == 1)//действия
                {
                    if (wparamlo == 1)// таблица 1 
                    {
                       
                    }
                    else if (wparamlo == 2)// таблица 2 
                    {
                    }
                    else if (wparamlo == 3)// таблица 3
                    {

                    }
                    else if (wparamlo == 4)// таблица 4 
                    {

                    }

                    Application.DoEvents();
                Thread.Sleep(1000); // если у нас есть визуальное отображение, то задержку можно установить здесь                    
                m.Result = new IntPtr(1); // ответом на запрос действия со стороны СИМПР должна быть единица
                }
            }
            else
            {
                base.WndProc(ref m); // для всех действий не связанных с СИМПР возвращаем управление программе
            }



        }

    }
}
