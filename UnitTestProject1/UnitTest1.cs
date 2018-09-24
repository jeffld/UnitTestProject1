

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

using System.Linq;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;


//using SimpleJson;



namespace UnitTestProject1
{


    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void Test01()
        {
            var myList = new List<string>(0);

            myList.Add("INDIANRED");
            myList.Add("LIGHTCORAL");
            myList.Add("SALMON");
            myList.Add("DARKSALMON");
            myList.Add("LIGHTSALMON");

            int i = 1;
            var EnumerateList = from currRow in myList
                                select new { Record = i++, value = currRow };

            foreach (var EnumeratedItem in EnumerateList)
            {
                Console.WriteLine("EnumerateList: {0} {1}", EnumeratedItem.value, EnumeratedItem.Record);
            }


            i = 1;
            var SelectList = from EnumRow in EnumerateList
                             where EnumRow.value != "SALMON"
                             select EnumRow;

            foreach (var SelectedItem in SelectList)
            {
                Console.WriteLine("SelectList: {0} {1}", SelectedItem.value, SelectedItem.Record);
            }

        }



        [TestMethod]
        public void Test02()
        {
            Console.WriteLine("Nothin to see here");


        }

    }




}
