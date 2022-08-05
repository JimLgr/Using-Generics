using UsingGenerics;
using ClassLibraryTime;

TheRange<double> myTemp = new (25.2, 38.4);
double tempTest = 39.5;

bool result = myTemp.IsIncluded(tempTest);
Console.WriteLine(result);

TheRange<int> myRangeInt = new(12, 38);
Console.WriteLine(myRangeInt.IsIncluded(10));

List<double> listDbl = new List<double> { 3.2, 5.4, 4 };

foreach (var i in listDbl)
{
    Console.WriteLine(i);
}

System.Collections.Stack test = new System.Collections.Stack();
test.Push(5.4);
test.Push(3);
test.Push("string");
test.Push(null);
System.Collections.Generic.Stack<object> test2 = new System.Collections.Generic.Stack<object>();
test2.Push(5.4);
test2.Push(3);
test2.Push(" ");


TheRange <Time> rangeTime = new(new Time(8, 30), new Time(17, 00));
result = rangeTime.IsIncluded(new Time(17, 30));
Console.WriteLine(result);


object objTime = new Time(16, 30);
Time aTime = new Time(16, 30);
int resultat = aTime.CompareTo(objTime);
Console.WriteLine(resultat);

IComparable<Time> aComparable = aTime as IComparable<Time>;
resultat = aComparable.CompareTo(aTime);
Console.WriteLine(resultat);