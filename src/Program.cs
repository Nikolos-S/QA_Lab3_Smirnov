using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Buildingcompany {
/// <summary>
/// класс Program Иницилизация проекта
/// </summary>
    class Program {
/// <summary>
/// Публичный метод Main иницилизирующий программу
/// </summary>
/// \code
        public static void Main(string[] args) {
// иницилизируем класс
            Company company = new Company("MyCompany", 1, 59, 87, 98, 99);
            company.DisplayFirstBuild();
            company.DisplaySecondBuild();
            System.Console.WriteLine("Суммарная стоимость двух помещений равна:" + company.TotalCost());
        }
/// \endcode
    }
}