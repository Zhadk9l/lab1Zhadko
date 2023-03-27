using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.structure_classes
{
    public class Schedule
    {
        public string DepartureCity { get; set; }
        public string DestinationCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int TrainNumber { get; set; }

        public Schedule() 
        {
            DepartureCity = string.Empty;
            DestinationCity = string.Empty;
            DepartureTime = DateTime.MinValue;
            ArrivalTime = DateTime.MinValue;
            TrainNumber = 0;
        }

        public override string ToString()
        {
            return $"Поїзд: {TrainNumber} | {DepartureCity} - {DestinationCity} | {DepartureTime} : {ArrivalTime}";
            
        }
    }
}
