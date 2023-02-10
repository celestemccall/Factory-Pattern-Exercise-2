using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise2
{
	public class MongoDataAccess : IDataAccess
	{
		public MongoDataAccess()
		{
		}

        public void LoadData()
        {
            Console.WriteLine("Accessing your Mongo Database. . .");
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to your Mongo Database. . .");
        }

       

        

       
    }
}

