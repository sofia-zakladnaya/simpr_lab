using System.Drawing;
using System.Windows.Forms;
namespace airport_reg
{
    
    public class Airport
    {
        public static int FlightNum = 3;
        public static int TimeOut = 5000;

        public string ImgDir; //Папка с изображениями
        public Bitmap img; //текущее изображение
        
        public Airport()
        {
            ImgDir = Application.StartupPath + "\\img\\";
            //Задаём стартовое изображение
            string path = ImgDir + "start.png";
            img = new Bitmap(path);
            
        }
    }
}
