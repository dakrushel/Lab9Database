using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Database
{
    public class Constants
    {
        //Setting up the database file stuff
        public const string DatabaseFilename = "Courses.db3";
        //This relativev path should put it in the solution folder
        public static string DatabasePath => Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, DatabaseFilename);

        public Constants()
        {

        }
    }
}
