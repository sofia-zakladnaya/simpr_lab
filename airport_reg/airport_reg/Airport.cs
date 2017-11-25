using System.Drawing;
using System.Windows.Forms;
namespace airport_reg
{
    
    public class Airport
    {
        const int FlightNum = 10;
        const int TimeOut = 5000;

        //public RegForm win;
        public Schedule schedule;
        public Image img;
        
        public Airport()
        {
            //Создаём расписание
            schedule = new Schedule(FlightNum);
            //Задаём стартовое изображение
            img = new Bitmap(Application.StartupPath + "\\img\\start.png");
            
        }
    }
}
