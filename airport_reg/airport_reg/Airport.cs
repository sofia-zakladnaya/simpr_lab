using System.Drawing;
using System.Windows.Forms;
namespace airport_reg
{
    
    public class Airport
    {
        public static int FlightNum = 10;
        public static int TimeOut = 5000;

        //public RegForm win;
        public Schedule schedule;
        public Bitmap img;
        
        public Airport()
        {
            //Создаём расписание
            schedule = new Schedule(FlightNum);
            //Задаём стартовое изображение
            string path = Application.StartupPath + "\\img\\start.png";
            img = new Bitmap(path);
            
        }
    }
}
