using System.Windows.Forms;
using System.Collections.Generic;

namespace airport_reg
{
    public partial class RegForm : Form
    {
        MyHookClass simpr;
        public RegForm()
        {
            InitializeComponent();
            //генерация списка рейсов
            Schedule sch = new Schedule(5);
            //Выводим список на форму
            for(int i=0; i<sch.FlightList.Count;i++)
            {
                lbFlightSchedule.Items.Add(sch.FlightList[i].Number.ToString() + " "+sch.FlightList[i].GetTypeString()+" "+ sch.FlightList[i].GetDestinationString() + " "+sch.FlightList[i].GetStatusString());
            }

        }
    }
}
