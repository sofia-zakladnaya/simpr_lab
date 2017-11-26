using System.Drawing;
using System.Windows.Forms;
namespace airport_reg
{
    
    public class Airport
    {
        public static int FlightNum = 3;
        public static int TimeOut = 5000;

        public Passenger pass; //Текущий пассажир
        public int PassCounter; //Счётчик пассажиров

        public string ImgTemplate; //Шаблон пути к файлу с изображением
        public Bitmap img; //текущее изображение
        
        public Airport()
        {
            PassCounter = 0;

            ImgTemplate = Application.StartupPath + "\\img\\img";
            //Задаём стартовое изображение
            SetImage(Pictures.Start);
            
            
        }

        //Установка изображения
        public void SetImage(Pictures num)
        {
            int index = (int)num;
            img = new Bitmap(ImgTemplate+index.ToString()+".png");
        }
    }

    public enum Pictures
    {
        //Старт
        Start,
        //Пустой пассажир
        Passenger,
        //Пассажир с разным набором клади, багажа и животных
        PassengerHand,       
        PassengerHandBaggage,
        PassengerHandLPet,
        PassengerHandBPet,
        PassengerHandBaggageLPet,
        PassengerHandBaggageBPet,

        PassengerBaggage,
        PassengerBaggageLPet,
        PassengerBaggageBPet,

        PassengerLPet,
        PassengerBPet,

        //Регистрация ручной глади
        PassengerHandRegH,
        PassengerHandBaggageRegH,
        PassengerHandLPetRegH,
        PassengerHandBPetRegH,
        PassengerHandBaggageLPetRegH,
        PassengerHandBaggageBPetRegH,
        //Отправка на международный рейс
        PassengerInternational,

        PassengerHandInternational,
        PassengerHandBaggageInternational,
        PassengerHandLPetInternational,
        PassengerHandBPetInternational,
        PassengerHandBaggageLPetInternational,
        PassengerHandBaggageBPetInternational,

        PassengerBaggageInternational,
        PassengerBaggageLPetInternational,
        PassengerBaggageBPetInternational,

        PassengerLPetInternational,
        PassengerBPetInternational,

        //Отправка на внутренний рейс
        PassengerHandDomestic,
        PassengerHandBaggageDomestic,
        PassengerHandLPetDomestic,
        PassengerHandBPetDomestic,
        PassengerHandBaggageLPetDomestic,
        PassengerHandBaggageBPetDomestic,

        PassengerBaggageDomestic,
        PassengerBaggageLPetDomestic,
        PassengerBaggageBPetDomestic,

        PassengerLPetDomestic,
        PassengerBPetDomestic,

        //Регистрация багажа
        BaggageReg,
        BaggageRegLPet,
        BaggageRegBPet,
        //Упаковка багажа
        BaggageRegPack,
        BaggageRegLPetPack,
        BaggageRegBPetPack,
        //Регистрация животных
        LittlePet,
        BigPet,
        //Успокоительное для животных
        LittlePetTr,
        BigPetTr

    }
}
