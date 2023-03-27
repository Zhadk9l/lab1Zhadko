using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.structure_classes
{
    public class Train
    {
        public int TrainId { get; set; }
        public List<TrainMaster> TrainMasters { get; set; }
        public int TrainNumber { get; set; }
        public List<Carriage> Carriages { get; set; }
        

        public Train() 
        { 
            TrainId = 0;
            TrainMasters = new();
            TrainNumber = 0;
            Carriages = new();
        }

        public override string ToString()
        {
            string infoASstring =  $"{TrainId} : {TrainNumber}";
            foreach (TrainMaster Master in TrainMasters)
                infoASstring+= " " + Master.ToString();
            foreach (Carriage Car in Carriages)
                infoASstring += " " + Car.ToString();
            return infoASstring;
        }
    }

}
