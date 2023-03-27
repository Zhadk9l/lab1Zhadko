using System;
using lab1.data;
namespace lab1.main
{
    public class PrintAndQueriesConnector
    {
        private Queries _qryExecutor;
        private ConsoleQueriesPrinter _printer;
        private DataList _dataLists;

        public PrintAndQueriesConnector(Queries qryExecutor, ConsoleQueriesPrinter printer,
               DataList dataLists)
        {
            this._qryExecutor = qryExecutor;
            this._printer = printer;
            this._dataLists = dataLists;
        }

        public void PrintAllSchedule()
        {
            _printer.Print("Розклад потягів", _qryExecutor.GetAllSchedule(_dataLists.Schedules));
        }
        public void PrintAllScheduleWhereDepartCityStart()
        {
            _printer.Print("Розклад потягів за назвою міста відправлення яке починається на К", _qryExecutor.GetAllScheduleWhereDepartCityStart(_dataLists.Schedules));
        }

        public void PrintScheduleSortedByDepartTime()
        {
            _printer.Print("Розклад потягів сортований за датою відправки", _qryExecutor.GetScheduleSortedByDepartTime(_dataLists.Schedules));
        }

        public void PrintScheduleSortedByPlaces()
        {
            _printer.Print("Розклад потягів за весь час з Київа до Запоріжжя", _qryExecutor.GetScheduleSortedByPlaces(_dataLists.Schedules));
        }

        public void PrintTrainByTrainMasterName() 
        {
            _printer.Print("Потяг", _qryExecutor.GetTrainByTrainMasterName(_dataLists.Trains, "Бойко Сергій Сергійович"));
        }

        public void PrintTrainByCarrigeCount()
        {
            _printer.Print("Cписок всіх потягів, які мають певну кількість вагонів", _qryExecutor.GetTrainByCarrigeCount(_dataLists.Trains));
        }
        public void PrintCarriagesByType()
        {
            _printer.Print("Список всіх вагонів певного типу певного поїзду (С,1002)", _qryExecutor.GetCarriagesByType(_dataLists.Carriages, "С", 1002));
        }
        public void PrintTrainTownAndTime()
        {
            _printer.Print("Cписок всіх потягів, які прибувають до певного міста пізніше певного часу(Київ, 2 бер)", _qryExecutor.GetTrainTownAndTime(_dataLists.Schedules, new DateTime(2023, 03, 1, 5, 44, 0), "Київ"));
        }
        public void PrintAllCarriagesSortedByTrainNumber()
        {
            _printer.Print("Список всіх вагонів сортована за номером поїзда", _qryExecutor.GetAllCarriagesSortedByTrainNumber(_dataLists.Carriages));
        }
        public void PrintCarriagesSortedByType()
        {
            _printer.Print("Список всіх вагонів сортована за типом вагона", _qryExecutor.GetCarriagesSortedByType(_dataLists.Carriages));
        }
        public void PrintCarrigeByCountSeats()
        {
            _printer.Print("Список всіх вагонів по колову місць > 19", _qryExecutor.GetCarrigeByCountSeats(_dataLists.Carriages));
        }
        public void PrintCarrigeWithNumberCont()
        {
            _printer.Print("Список вагонів в номері яких присутня цифра 0", _qryExecutor.GetCarrigeWithNumberCont(_dataLists.Carriages));
        }
        public void PrintScheduleSortedByDestinationTime()
        {
            _printer.Print("Розклад потягів сортований за датою приїзду", _qryExecutor.GetScheduleSortedByDestinationTime(_dataLists.Schedules));
        }
        public void PrintSchheduleFirstAndLast()
        {
            _printer.Print("Отримати перший і останній маршрут в розкладі", _qryExecutor.GetSchheduleFirstAndLast(_dataLists.Schedules));
        }
        public void PrintCarrigeWithHigherAndLowestNumber()
        {
            _printer.Print("Отримати вагони з більшим і меньшим номером вагона", _qryExecutor.GetCarrigeWithHigherAndLowestNumber(_dataLists.Carriages));
        }
        public void PrintEvenCarrigeNumber()
        {
            _printer.Print("Отримати парні вагони", _qryExecutor.GetEvenCarrigeNumber(_dataLists.Carriages));
        }
        public void PrintScheduleWithMaxDestLenght()
        {
            _printer.Print("Отримати маршрут з найдовшою довжиною місця призначення", _qryExecutor.GetScheduleWithMaxDestLenght(_dataLists.Schedules));
        }
        public void PrintTrainWithMaxSchedule()
        {
            _printer.Print("Отримати потяг з найбільшим коловом маршрутів", _qryExecutor.GetTrainWithMaxSchedule(_dataLists.Trains,_dataLists.Schedules));
        }
        public void PrintMinSchedule()
        {
            _printer.Print("Отримати найкоротший маршрут за часом", _qryExecutor.GetMinSchedule(_dataLists.Schedules));
        }
        public void PrintNotEvenTrainCapId()
        {
            _printer.Print("Отримати потяг у якого id головного потягу не парне", _qryExecutor.GetNotEvenTrainCapId(_dataLists.Trains));
        }

    }
}

