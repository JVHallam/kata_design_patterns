using practise_area.Models;
using practise_area.Utility;
using System.Collections.Generic;
using System.Linq;

var ATestCase = new List<bool>(){ true, false };
var BTestCase = new List<bool>(){ true, false };
var CTestCase = new List<bool>(){ true, false };

List<TestCase> testCases = ATestCase
                    .Select( boolCase => new TestCase(){ A = boolCase } )
                    .SelectMany( testCase => BTestCase.Select( boolCase => {
                                    var copy = testCase.Clone();
                                    copy.B = boolCase;
                                    return copy;
                                }))
                    .SelectMany( testCase => BTestCase.Select( boolCase => {
                                    var copy = testCase.Clone();
                                    copy.C = boolCase;
                                    return copy;
                                }))
                    .ToList();

Console.WriteLine("---- ---- ----");
foreach(var testCase in testCases)
{
    Printer.Print(testCase);
}

Console.WriteLine("---- ---- ----");
foreach(var testCase in testCases)
{
    Printer.Print(testCase);
}
