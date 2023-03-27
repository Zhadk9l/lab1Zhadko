using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;
using lab1.data;

namespace lab1.main
{
    class Program
    {

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Queries qryExecutor = new();
            ConsoleQueriesPrinter printer = new();
            DataList dataLists = new();

            PrintAndQueriesConnector printQryCon = new(qryExecutor, printer, dataLists);

            while (true)
            {
                string caseR = Console.ReadLine();
                switch (caseR)
                {
                    case "1":
                        printQryCon.PrintAllSchedule();
                        break;
                    case "2":
                        printQryCon.PrintAllScheduleWhereDepartCityStart();
                        break;
                    case "3":
                        printQryCon.PrintScheduleSortedByDepartTime();
                        break;
                    case "4":
                        printQryCon.PrintTrainByTrainMasterName();
                        break; 
                    case "5":
                        printQryCon.PrintScheduleSortedByPlaces();
                        break;
                    case "6":
                        printQryCon.PrintTrainByCarrigeCount();
                        break;
                    case "7":
                        printQryCon.PrintCarriagesByType();
                        break;
                    case "8":
                        printQryCon.PrintTrainTownAndTime();
                        break;
                    case "9":
                        printQryCon.PrintAllCarriagesSortedByTrainNumber();
                        break;
                    case "10":
                        printQryCon.PrintCarriagesSortedByType();
                        break;
                    case "11":
                        printQryCon.PrintCarrigeByCountSeats();
                        break;
                    case "12":
                        printQryCon.PrintCarrigeWithNumberCont();
                        break;
                    case "13":
                        printQryCon.PrintScheduleSortedByDestinationTime();
                        break;
                    case "14":
                        printQryCon.PrintSchheduleFirstAndLast();
                        break;
                    case "15":
                        printQryCon.PrintCarrigeWithHigherAndLowestNumber();
                        break;
                    case "16":
                        printQryCon.PrintEvenCarrigeNumber();
                        break;
                    case "17":
                        printQryCon.PrintScheduleWithMaxDestLenght();
                        break;
                    case "18":
                        printQryCon.PrintTrainWithMaxSchedule();
                        break;
                    case "19":
                        printQryCon.PrintMinSchedule();
                        break;
                    case "20":
                        printQryCon.PrintNotEvenTrainCapId();
                        break;
                    case "e":
                        return;
                    default:
                        Console.WriteLine(
                            "1 - Розклад потягів" +
                            "\n2 - Розклад потягів за назвою міста відправлення яке починається на К" +
                            "\n3 - Розклад потягів сортованих за датою відпарвки" + 
                            "\n4 - Потяг за Ім'ям голови потяга(Бойко Сергій)" +
                            "\n5 - Розклад потягів за весь час з Київа до Запоріжжя" +
                            "\n6 - Cписок всіх потягів, які мають певну кількість вагонів(3)" +
                            "\n7 - Список всіх вагонів певного типу певного поїзду (С,1002)" +
                            "\n8 - Список всіх потягів, які прибувають до певного міста пізніше певного часу(Київ, 2 бер)" +
                            "\n9 - Список всіх вагонів сортована за номером поїзда" +
                            "\n10 - Список всіх вагонів сортована за типом вагона" +
                            "\n11 - Список всіх вагонів по колову місць > 19" +
                            "\n12 - Список вагонів в номері яких присутня цифра 0" +
                            "\n13 - Розклад потягів сортованих за датою приїзду" +
                            "\n14 - Отримати перший і останній маршрут в розкладі" +
                            "\n15 - Отримати вагони з більшим і меньшим номером вагона" +
                            "\n16 - Отримати парні вагони" +
                            "\n17 - Отримати маршрут з найдовшою довжиною місця призначення" +
                            "\n18 - Отримати потяг з найбільшим коловом маршрутів" +
                            "\n19 - Отримати найкоротший маршрут за часом" +
                            "\n20 - Отримати потяг у якого id головного потягу не парне" +
                            "\ne - exit");
                        break;
                }
            }

        }

    }
}