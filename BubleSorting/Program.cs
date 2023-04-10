using BubleSorting.Helper;
using System.Diagnostics;


#region MOCKDATA
int[] list = new int[7] { 5, 7, 2, 9, 6, 1, 1 }; //Random assign int[] list

int[] list2 = new int[20] {6,4,21,1,7,9,0,14,34,33,46,6,101,4,65,43,67,12,48,53};

int[] list3 = new int[10] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

#endregion MOCKDATA



var sortedList = Sorting.BubleSortingProcessor(list2); // we sorted int[] list with bublesort 
Writer.WriteListConsole(sortedList);



Console.ReadLine();