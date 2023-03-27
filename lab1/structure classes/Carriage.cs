using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.structure_classes
{
    public class Carriage
    {
        public int CarriageNumber { get; set; }
        public string CarriageType { get; set; }
        public int NumberOfSeats { get; set; }
        public int TrainNumber { get; set; }
        public Carriage()
        {
            CarriageNumber = 0;
            CarriageType = string.Empty;
            NumberOfSeats = 0;
            TrainNumber = 0;
        }

        public override string ToString()
        {
            return $"Номер Вагона: {CarriageNumber}, Тип: {CarriageType}, Колово місць: {NumberOfSeats}, {TrainNumber}";
        }
    }
}
