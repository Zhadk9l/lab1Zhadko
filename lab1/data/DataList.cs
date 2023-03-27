using lab1.structure_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.data
{
    public class DataList
    {
        public List<Train> Trains { get; set; } = new()
        {
            new()
            {
                TrainId = 1,
                TrainNumber = 1001,
                Carriages = new ()
                {
                    new()
                    {
                        CarriageNumber = 101,
                        CarriageType = "П",
                        NumberOfSeats = 25,
                        TrainNumber = 1001
                    },
                    new()
                    {
                        CarriageNumber = 102,
                        CarriageType = "К",
                        NumberOfSeats = 20,
                        TrainNumber = 1001
                    },
                    new()
                    {
                        CarriageNumber = 103,
                        CarriageType = "К",
                        NumberOfSeats = 20,
                        TrainNumber = 1001
                    },
                    },
                TrainMasters = new()
                {
                    new()
                    {
                        TrainMasterName = "Бойко Сергій Сергійович",
                        TrainMasterId = 1001023405,
                    }
                }

            },
            new()
            {
                TrainId = 2,
                TrainNumber = 1002,
                Carriages = new()
                {
                    new()
                    {
                        CarriageNumber = 104,
                        CarriageType = "П",
                        NumberOfSeats = 25,
                        TrainNumber = 1002
                    },
                    new()
                    {
                        CarriageNumber = 105,
                        CarriageType = "К",
                        NumberOfSeats = 20,
                        TrainNumber = 1002
                    },
                    new()
                    {
                        CarriageNumber = 106,
                        CarriageType = "К",
                        NumberOfSeats = 20,
                        TrainNumber = 1002
                    },
                    new()
                    {
                        CarriageNumber = 107,
                        CarriageType = "С",
                        NumberOfSeats = 10,
                        TrainNumber = 1002
                    },
                    },
                TrainMasters = new()
                {
                    new()
                    {
                        TrainMasterName = "Катруша Андрій Сергійович",
                        TrainMasterId = 1001054386,
                    }
                }

            },
            new()
            {
                TrainId = 3,
                TrainNumber = 1003,
                Carriages = new()
                {
                    new()
                    {
                        CarriageNumber = 108,
                        CarriageType = "К",
                        NumberOfSeats = 20,
                        TrainNumber = 1003
                    },
                    new()
                    {
                        CarriageNumber = 109,
                        CarriageType = "С",
                        NumberOfSeats = 10,
                        TrainNumber = 1003
                    },
                    new()
                    {
                        CarriageNumber = 110,
                        CarriageType = "С",
                        NumberOfSeats = 10,
                        TrainNumber = 1003
                    },
                    },
                TrainMasters = new()
                {
                    new()
                    {
                        TrainMasterName = "Біденко Ілля Володимирович",
                        TrainMasterId = 1001023405,
                    }
                }

            },
        };

        

        public List<Schedule> Schedules { get; set; } = new()
        {
            new()
            {
                DepartureCity = "Київ",
                DestinationCity = "Запоріжжя",
                DepartureTime = new DateTime(2023,02,27,15,0,0),
                ArrivalTime = new DateTime(2023,02,28,5,20,0),
                TrainNumber = 1001,
            },
            new()
            {
                DepartureCity = "Київ",
                DestinationCity = "Львів",
                DepartureTime = new DateTime(2023,03,15,15,0,0),
                ArrivalTime = new DateTime(2023,03,16,2,20,0),
                TrainNumber = 1001,
            },
            new()
            {
                DepartureCity = "Львів",
                DestinationCity = "Київ",
                DepartureTime = new DateTime(2023,03,1,17,12,0),
                ArrivalTime = new DateTime(2023,03,2,5,44,0),
                TrainNumber = 1002,
            },
            new()
            {
                DepartureCity = "Умань",
                DestinationCity = "Дніпро",
                DepartureTime = new DateTime(2023,02,26,21,12,0),
                ArrivalTime = new DateTime(2023,02,27,5,20,0),
                TrainNumber = 1003,
            },
        };

        public List<Carriage> Carriages { get; set; } = new()
        {
            new()
                    {
                        CarriageNumber = 101,
                        CarriageType = "П",
                        NumberOfSeats = 25,
                        TrainNumber = 1001
                    },
                    new()
                    {
                        CarriageNumber = 102,
                        CarriageType = "К",
                        NumberOfSeats = 20,
                        TrainNumber = 1001
                    },
                    new()
                    {
                        CarriageNumber = 103,
                        CarriageType = "К",
                        NumberOfSeats = 20,
                        TrainNumber = 1001
                    },
                    new()
                    {
                        CarriageNumber = 104,
                        CarriageType = "П",
                        NumberOfSeats = 25,
                        TrainNumber = 1002
                    },
                    new()
                    {
                        CarriageNumber = 105,
                        CarriageType = "К",
                        NumberOfSeats = 20,
                        TrainNumber = 1002
                    },
                    new()
                    {
                        CarriageNumber = 106,
                        CarriageType = "К",
                        NumberOfSeats = 20,
                        TrainNumber = 1002
                    },
                    new()
                    {
                        CarriageNumber = 107,
                        CarriageType = "С",
                        NumberOfSeats = 10,
                        TrainNumber = 1002
                    },
                    new()
                    {
                        CarriageNumber = 108,
                        CarriageType = "К",
                        NumberOfSeats = 20,
                        TrainNumber = 1003
                    },
                    new()
                    {
                        CarriageNumber = 109,
                        CarriageType = "С",
                        NumberOfSeats = 10,
                        TrainNumber = 1003
                    },
                    new()
                    {
                        CarriageNumber = 110,
                        CarriageType = "С",
                        NumberOfSeats = 10,
                        TrainNumber = 1003
                    },
        };
    }
}
