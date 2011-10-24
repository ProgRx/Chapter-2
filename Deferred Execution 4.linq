<Query Kind="Statements">
  <Reference Relative="..\References\System.Reactive.dll">..\References\System.Reactive.dll</Reference>
  <Reference Relative="..\References\Microsoft.Reactive.Testing.dll">..\References\Microsoft.Reactive.Testing.dll</Reference>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>Microsoft.Reactive.Testing</Namespace>
</Query>

<Query Kind="Statements">
  <Reference Relative="..\RxBookLinqpadHelper\ext\System.Reactive.dll">D:\ProgrammingRx\Demo Code For Chapters\RxBookLinqpadHelper\ext\System.Reactive.dll</Reference>
  <Reference Relative="..\RxBookLinqpadHelper\ext\Microsoft.Reactive.Testing.dll">D:\ProgrammingRx\Demo Code For Chapters\RxBookLinqpadHelper\ext\Microsoft.Reactive.Testing.dll</Reference>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
</Query>

var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var query = from num in list 
			where num < 7
			select num;
			
foreach ( var num in query )
{
	Console.WriteLine(num);
}
			