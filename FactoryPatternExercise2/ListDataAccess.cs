using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
	public class ListDataAccess : IDataAccess
	{


        public void LoadData()
        {
            Console.WriteLine("Accessing your List Database. . .");
        }

        public void SaveData()
        {
            Console.WriteLine("Saving your List Database. . .");
        }

       
    }
}

