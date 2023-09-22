// See https://aka.ms/new-console-template for more information
using Coure_Assessment_Question_1;

Console.WriteLine("Hello, World!");

var testCase1 = new int[] { 1, 2, 3, 4, 5 };
var testCase2 = new int[] { 15, 25, 35 };
var testCase3 = new int[] { 8, 8 };
var testCase4 = new int[] { 9, 9, 32, 6, 2, 7, 15, 12, 16, 181, 8 };
Console.WriteLine(Solution.TotalScore(testCase4));