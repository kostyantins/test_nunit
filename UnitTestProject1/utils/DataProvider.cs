using System.Collections;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using static TestProject.page_objects.HomePage;

namespace TestProject.utils
{
    public class DataProvider
    {
        public static IEnumerable<TestCaseData> HederBlockText
        {
            get
            {
                yield return new TestCaseData("Explore Bukovel", FirstHedderBaner);
                yield return new TestCaseData("Planner", SecondHedderBaner);
                yield return new TestCaseData("Specials", ThreadHedderBaner);
            }
        }
    }
}