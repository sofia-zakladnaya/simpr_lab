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
        //Выбор изображения
        //Старовое изображение
        public void StartImage()
        {
            SetImage(Pictures.Start);
        }
        //Пассажир
        public void PassImage()
        {
            //Есть ручная кладь?
            if(pass.HandLuggage)
            {
                //есть багаж
                if (pass.HaveBaggage())
                {
                    //есть животное?
                    if (pass.HavePet())
                    {
                        //крупное?
                        if(pass.Pet.IsBig())
                        {
                            SetImage(Pictures.PassengerHandBaggageBPet);
                        }
                        //мелкое животное
                        else
                        {
                            SetImage(Pictures.PassengerHandBaggageLPet);
                        }
                    }
                    //нет животного
                    else
                    {
                        SetImage(Pictures.PassengerHandBaggage);
                    }
                }
                //нет багажа
                else
                {
                    //есть животное?
                    if (pass.HavePet())
                    {
                        //крупное?
                        if (pass.Pet.IsBig())
                        {
                            SetImage(Pictures.PassengerHandBPet);
                        }
                        //мелкое животное
                        else
                        {
                            SetImage(Pictures.PassengerHandLPet);
                        }
                    }
                    //нет животного
                    else
                    {
                        SetImage(Pictures.PassengerHand);
                    }
                }
            }
            //Нет ручной клади
            else
            {
                //есть багаж
                if (pass.HaveBaggage())
                {
                    //есть животное?
                    if (pass.HavePet())
                    {
                        //крупное?
                        if (pass.Pet.IsBig())
                        {
                            SetImage(Pictures.PassengerBaggageBPet);
                        }
                        //мелкое животное
                        else
                        {
                            SetImage(Pictures.PassengerBaggageLPet);
                        }
                    }
                    //нет животного
                    else
                    {
                        SetImage(Pictures.PassengerBaggage);
                    }
                }
                //нет багажа
                else
                {
                    //есть животное?
                    if (pass.HavePet())
                    {
                        //крупное?
                        if (pass.Pet.IsBig())
                        {
                            SetImage(Pictures.PassengerBPet);
                        }
                        //мелкое животное
                        else
                        {
                            SetImage(Pictures.PassengerLPet);
                        }
                    }
                    //нет животного
                    else
                    {
                        SetImage(Pictures.Passenger);
                    }
                }
            }

        }

        //Регистрация ручной клади
        public void HandRegImage()
        {
            //Есть багаж
            if(pass.HaveBaggage())
            {
                //Есть животное
                if(pass.HavePet())
                {
                    //Животное крупное
                    if(pass.Pet.IsBig())
                    {
                        SetImage(Pictures.PassengerHandBaggageBPetRegH);
                    }
                    //Мелкое
                    {
                        SetImage(Pictures.PassengerHandBaggageLPetRegH);
                    }
                }
                //Нет животного
                else
                {
                    SetImage(Pictures.PassengerHandBaggageRegH);
                }
            }
            //нет багажа
            else
            {
                //Есть животное
                if (pass.HavePet())
                {
                    //Животное крупное
                    if (pass.Pet.IsBig())
                    {
                        SetImage(Pictures.PassengerHandBPetRegH);
                    }
                    //Мелкое
                    {
                        SetImage(Pictures.PassengerHandLPetRegH);
                    }
                }
                //Нет животного
                else
                {
                    SetImage(Pictures.PassengerHandRegH);
                }
            }
        }

        //Отправка на посадку
        public void BoardImage()
        {
            //Рейс международный
            if(pass.Ticket.Type == FlightType.International)
            {
                //Есть ручная кладь
                if(pass.HandLuggage)
                {
                    //есть багаж
                    if(pass.HaveBaggage())
                    {
                        //Есть животное
                        if (pass.HavePet())
                        {
                            //Животное крупное
                            if (pass.Pet.IsBig())
                            {
                                SetImage(Pictures.PassengerHandBaggageBPetInternational);
                            }
                            //Мелкое
                            {
                                SetImage(Pictures.PassengerHandBaggageLPetInternational);
                            }
                        }
                        //Нет животного
                        else
                        {
                            SetImage(Pictures.PassengerHandBaggageInternational);
                        }
                    }
                    //нет багажа
                    else
                    {
                        //Есть животное
                        if (pass.HavePet())
                        {
                            //Животное крупное
                            if (pass.Pet.IsBig())
                            {
                                SetImage(Pictures.PassengerHandBPetInternational);
                            }
                            //Мелкое
                            {
                                SetImage(Pictures.PassengerHandLPetInternational);
                            }
                        }
                        //Нет животного
                        else
                        {
                            SetImage(Pictures.PassengerHandInternational);
                        }
                    }
                }
                //Нет клади
                else                
                {
                    //есть багаж
                    if (pass.HaveBaggage())
                    {
                        //Есть животное
                        if (pass.HavePet())
                        {
                            //Животное крупное
                            if (pass.Pet.IsBig())
                            {
                                SetImage(Pictures.PassengerBaggageBPetInternational);
                            }
                            //Мелкое
                            {
                                SetImage(Pictures.PassengerBaggageLPetInternational);
                            }
                        }
                        //Нет животного
                        else
                        {
                            SetImage(Pictures.PassengerBaggageInternational);
                        }
                    }
                    //нет багажа
                    else
                    {
                        //Есть животное
                        if (pass.HavePet())
                        {
                            //Животное крупное
                            if (pass.Pet.IsBig())
                            {
                                SetImage(Pictures.PassengerBPetInternational);
                            }
                            //Мелкое
                            {
                                SetImage(Pictures.PassengerLPetInternational);
                            }
                        }
                        //Нет животного
                        else
                        {
                            SetImage(Pictures.PassengerInternational);
                        }
                    }
                }
            }
            //Внутренний
            else
            {
                //Есть ручная кладь
                if (pass.HandLuggage)
                {
                    //есть багаж
                    if (pass.HaveBaggage())
                    {
                        //Есть животное
                        if (pass.HavePet())
                        {
                            //Животное крупное
                            if (pass.Pet.IsBig())
                            {
                                SetImage(Pictures.PassengerHandBaggageBPetDomestic);
                            }
                            //Мелкое
                            {
                                SetImage(Pictures.PassengerHandBaggageLPetDomestic);
                            }
                        }
                        //Нет животного
                        else
                        {
                            SetImage(Pictures.PassengerHandBaggageDomestic);
                        }
                    }
                    //нет багажа
                    else
                    {
                        //Есть животное
                        if (pass.HavePet())
                        {
                            //Животное крупное
                            if (pass.Pet.IsBig())
                            {
                                SetImage(Pictures.PassengerHandBPetDomestic);
                            }
                            //Мелкое
                            {
                                SetImage(Pictures.PassengerHandLPetDomestic);
                            }
                        }
                        //Нет животного
                        else
                        {
                            SetImage(Pictures.PassengerHandDomestic);
                        }
                    }
                }
                //Нет клади
                else
                {
                    //есть багаж
                    if (pass.HaveBaggage())
                    {
                        //Есть животное
                        if (pass.HavePet())
                        {
                            //Животное крупное
                            if (pass.Pet.IsBig())
                            {
                                SetImage(Pictures.PassengerBaggageBPetDomestic);
                            }
                            //Мелкое
                            {
                                SetImage(Pictures.PassengerBaggageLPetDomestic);
                            }
                        }
                        //Нет животного
                        else
                        {
                            SetImage(Pictures.PassengerBaggageDomestic);
                        }
                    }
                    //нет багажа
                    else
                    {
                        //Есть животное
                        if (pass.HavePet())
                        {
                            //Животное крупное
                            if (pass.Pet.IsBig())
                            {
                                SetImage(Pictures.PassengerBPetDomestic);
                            }
                            //Мелкое
                            {
                                SetImage(Pictures.PassengerLPetDomestic);
                            }
                        }
                        //Нет животного
                        else
                        {
                            SetImage(Pictures.PassengerDomestic);
                        }
                    }
                }
            }
        }
  
        //Регистрация багажа
        public void RegBaggageImage()
        {
            //Есть животное
            if(pass.HavePet())
            {
                //Крупное
                if(pass.Pet.IsBig())
                {
                    SetImage(Pictures.BaggageRegBPet);
                }
                //Мелкое
                else
                {
                    SetImage(Pictures.BaggageRegLPet);
                }

            }
            //Нет животного
            else
            {
                SetImage(Pictures.BaggageReg);
            }
        }

        //Упаковка багажа
        public void PackImage()
        {
            //Есть животное
            if (pass.HavePet())
            {
                //Крупное
                if (pass.Pet.IsBig())
                {
                    SetImage(Pictures.BaggageRegBPetPack);
                }
                //Мелкое
                else
                {
                    SetImage(Pictures.BaggageRegLPetPack);
                }

            }
            //Нет животного
            else
            {
                SetImage(Pictures.BaggageRegPack);
            }
        }
        //Регистрация животных
        public void RegPetImage()
        {
            //Крупное
            if (pass.Pet.IsBig())
            {
                SetImage(Pictures.BigPet);
            }
            //Мелкое
            else
            {
                SetImage(Pictures.LittlePet);
            }
        }

        //Успокоительно для животных
        public void TrPetImage()
        {
            //Крупное
            if (pass.Pet.IsBig())
            {
                SetImage(Pictures.BigPetTr);
            }
            //Мелкое
            else
            {
                SetImage(Pictures.LittlePetTr);
            }
        }
        //Установка изображения
        private void SetImage(Pictures num)
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
        BigPetTr,
        //Пустой на международный
        PassengerDomestic

    }
}
