using lab1.structure_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.main
{
    public class Queries
    {
        public IEnumerable<Schedule> GetAllSchedule(IEnumerable<Schedule> schedules)
        {
            return schedules;
        }
        public IEnumerable<Schedule> GetAllScheduleWhereDepartCityStart(IEnumerable<Schedule> schedules)
        {
            return schedules.Where(schedules => schedules.DepartureCity.Contains('К'));
        }

        public IEnumerable<Schedule> GetScheduleSortedByDepartTime(IEnumerable<Schedule> schedules)
        {
            return from schedule in schedules
                   orderby schedule.DepartureTime
                   select schedule;
        }

        public IEnumerable<Schedule> GetScheduleSortedByPlaces(IEnumerable<Schedule> schedules)
        {
            return schedules
                    .Where(schedules => schedules.DepartureCity == "Київ" && schedules.DestinationCity == "Запоріжжя"
                    );
        }

        public IEnumerable<Train> GetTrainByTrainMasterName(IEnumerable<Train> trains,
            string specificName)
        {
            return trains
                   .Where(trains => trains.TrainMasters
                   .Any(TrainMaster => TrainMaster.TrainMasterName == specificName));
        }

        public IEnumerable<Train> GetTrainByCarrigeCount(IEnumerable<Train> trains)
        {
            return trains
                   .Where(trains => trains.Carriages.Count == 3);
        }

        public IEnumerable<Carriage> GetCarriagesByType(IEnumerable<Carriage> carriages, string typecarm, int trnumb)
        {
            return carriages
                   .Where(carriages => carriages.CarriageType ==typecarm && carriages.TrainNumber == trnumb);
        }

        public IEnumerable<Schedule> GetTrainTownAndTime(IEnumerable<Schedule> schedules, DateTime TimeArrive, string TownArrive)
        {
            return schedules
                   .Where(schedules => schedules.ArrivalTime > TimeArrive && schedules.DestinationCity == TownArrive);
        }
        public IEnumerable<Carriage> GetAllCarriagesSortedByTrainNumber(IEnumerable<Carriage> carriages)
        {
            return from carriage in carriages
                   orderby carriage.TrainNumber
                   select carriage;
        }
        public IEnumerable<Carriage> GetCarriagesSortedByType(IEnumerable<Carriage> carriages)
        {
            return from carriage in carriages
                   orderby carriage.CarriageType
                   select carriage;
        }
        public IEnumerable<Carriage> GetCarrigeByCountSeats(IEnumerable<Carriage> carriages)
        {
            return carriages
                   .Where(carriages => carriages.NumberOfSeats > 19);
        }
        public IEnumerable<Carriage> GetCarrigeWithNumberCont(IEnumerable<Carriage> carriages)
        {
            return carriages.Where(carriages => carriages.CarriageNumber.ToString().Contains('0'));
        }
        public IEnumerable<Schedule> GetScheduleSortedByDestinationTime(IEnumerable<Schedule> schedules)
        {
            return from schedule in schedules
                   orderby schedule.ArrivalTime
                   select schedule;
        }
        public IEnumerable<Schedule> GetSchheduleFirstAndLast(IEnumerable<Schedule> schedules)
        {
            DateTime? MaxDepData = schedules.Max(schedules => schedules.DepartureTime);
            DateTime? MinDepData = schedules.Min(schedules => schedules.DepartureTime);

            IEnumerable<Schedule> FirstSch = schedules
                .Where(schedules => schedules.DepartureTime == MinDepData);

            IEnumerable<Schedule> LastSch = schedules
                .Where(schedules => schedules.DepartureTime == MaxDepData);

            return FirstSch.Concat(LastSch);
        }
        public IEnumerable<Carriage> GetCarrigeWithHigherAndLowestNumber(IEnumerable<Carriage> carriages)
        {
            int? MAXNumber = carriages.Max(carriages => carriages.CarriageNumber);
            int? MINNumber = carriages.Min(carriages => carriages.CarriageNumber);

            IEnumerable<Carriage> maxcarrigenumber = carriages
                .Where(carriages => carriages.CarriageNumber == MAXNumber);

            IEnumerable<Carriage> mincarrigenumber = carriages
                .Where(carriages => carriages.CarriageNumber == MINNumber);

            return maxcarrigenumber.Concat(mincarrigenumber);
        }
        public IEnumerable<Carriage> GetEvenCarrigeNumber(IEnumerable<Carriage> carriages)
        {
            return carriages
                   .Where(carriages => carriages.CarriageNumber % 2 == 0);
        }
        public IEnumerable<Schedule> GetScheduleWithMaxDestLenght(IEnumerable<Schedule> schedules)
        {
            int? Maxschedules = schedules.Max(schedules => schedules.DestinationCity.Length);
            IEnumerable<Schedule> MaxScheduleRet = schedules
                .Where(schedules => schedules.DestinationCity.Length == Maxschedules);
            return MaxScheduleRet;
        }
        public IEnumerable<Train> GetTrainWithMaxSchedule(IEnumerable<Train> trains,
            IEnumerable<Schedule> schedules)
        {
            int maxCount = schedules
                .GroupBy(s => s.TrainNumber)
                .Max(g => g.Count());

            int trainNumber = schedules
                .GroupBy(s => s.TrainNumber)
                .First(g => g.Count() == maxCount)
                .Key;

            IEnumerable<Train> Train = trains
                .Where(trains => trains.TrainNumber == trainNumber);
            return Train;
        }
        public IEnumerable<Schedule> GetMinSchedule(IEnumerable<Schedule> schedules)
        {
            var shortestSchedule = schedules
                .OrderBy(s => s.ArrivalTime - s.DepartureTime).First();
            IEnumerable<Schedule> minSchedule = schedules
                .Where(schedules => schedules == shortestSchedule);
            return minSchedule;
        }
        public IEnumerable<Train> GetNotEvenTrainCapId(IEnumerable<Train> trains)
        {
            return trains
                    .Where(trains => trains.TrainMasters
                    .Any(TrainMaster => TrainMaster.TrainMasterId % 2 != 0));
        }
    }
}
