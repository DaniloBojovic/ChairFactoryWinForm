using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aups.Manager;
using Dal.Repositories;

namespace Aups.TestingApp
{
    class Program
    {
        static void Main(string[] args)

        {
            var unitOfWork = new UnitOfWork();
            var manager = new ProductionManager(unitOfWork);

            var items = unitOfWork.Items.GetAllFinalItems();
            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
    }
}
