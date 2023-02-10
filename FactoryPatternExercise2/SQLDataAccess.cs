using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
	public class SQLDataAccess : IDataAccess
	{
		public SQLDataAccess()
		{
		}


        public void LoadData()
        {
            Console.WriteLine("Accessing your SQL Database. . .");
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to your SQL Database. . .");
        }

        
        
     

        
    }
}

