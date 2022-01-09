using practise_area.Models;
using practise_area.Utility;
using System.Linq;
using System.Collections.Generic;

var boolCases = new List<bool>(){
    true, 
    false
};

var testCases = Enumerable
                    .Repeat(new TestCase(), 1)
                    .SelectMany(testCase => {
                        return boolCases.Select(boolCase => {
                                var newCase = testCase.Clone();
                                newCase.A = boolCase;
                                return newCase;
                        });
                    })
                    .SelectMany(testCase => {
                        return boolCases.Select(boolCase => {
                                var newCase = testCase.Clone();
                                newCase.B = boolCase;
                                return newCase;
                        });
                    })
                    .SelectMany(testCase => {
                        return boolCases.Select(boolCase => {
                                var newCase = testCase.Clone();
                                newCase.C = boolCase;
                                return newCase;
                        });
                    })
                    .ToList();

foreach(var testCase in testCases)
{
    Printer.Print(testCase);
}
