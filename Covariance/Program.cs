using System;
using System.Collections.Generic;

namespace Covariance
{
    class Program
    {
        static void Main(string[] args)
        {
            //casting a derived type to the base type
            string str = "Hello World!";
            object obj = str;

            var strList = new string[] { "Monday", "Tuesday" };
            //works since Enumerator & Enumerable are read-only, can not modify col.
            //this is why Microsoft allows covariance for them
            IEnumerable<object> objEnum = strList;

            ////List<string> != List<object>
            //List<object> objList = (List<object>)strList;

            ////Array covariance: can cast array of derived type to base type
            ////works for retrieving items from array but breaks when tryingt o 
            ////set items, because not all objects are strings
            //object[] objArray = strArray;
            ////does not work because "int" != "string"
            //objArray[0] = 5;
        }
    }
}
