using System.Collections;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using static TestProject.page_objects.HomePage;
using Microsoft.Office.Interop.Excel;
using static TestProject.utils.ExelReader;

namespace TestProject.utils
{
    public class DataProvider
    {
        private static string path = @"D:\Temp\Book1.xlsx";

        public static IEnumerable<TestCaseData> HederBlockText
        {
            get
            {
                yield return new TestCaseData("Explore Bukovel", FirstHedderBaner);
                yield return new TestCaseData("Planner", SecondHedderBaner);
                yield return new TestCaseData("Specials", ThreadHedderBaner);
            }
        }

        public static IEnumerable<TestCaseData> TextEqualText
        {
           get { yield return new TestCaseData(GetExcelData(path)); }
        }
    }
}