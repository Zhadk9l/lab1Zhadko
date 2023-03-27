using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.structure_classes
{
    public class TrainMaster
    {
        public string TrainMasterName { get; set; }
        public int TrainMasterId { get; set; }

        public TrainMaster()
        {
            TrainMasterName = string.Empty;
            TrainMasterId = 0;
        }

        public override string ToString()
        {
            return $"Ім'я: {TrainMasterName}, Id: {TrainMasterId}";
        }
    }
}
