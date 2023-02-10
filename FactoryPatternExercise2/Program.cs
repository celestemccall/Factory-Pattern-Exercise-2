using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of database do you want to use???");
            Console.WriteLine("Please enter: list, sql, or mongo.");
            
            
            string ?dbType = Console.ReadLine();

            IDataAccess da = DataAccessFactory.GetDataAccess(dbType);

            var data = DataAccessFactory.GetDataAccess(dbType);
            data.LoadData();
            data.SaveData();            

           

           
        }

       
    }
}
