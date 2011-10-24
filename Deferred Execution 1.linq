<Query Kind="Statements">
  <Reference Relative="..\References\System.Reactive.dll">..\References\System.Reactive.dll</Reference>
  <Reference Relative="..\References\Microsoft.Reactive.Testing.dll">..\References\Microsoft.Reactive.Testing.dll</Reference>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>Microsoft.Reactive.Testing</Namespace>
</Query>

/* Deferred Execution 1:
 *
 * Demonstrate that execution occurs when a collection is enumerated, *not*
 * when the expression is evaluated, which is sometimes really useful!
 */

var thisShouldTakeALongTime = Enumerable.Range(0, 1000 * 1000).Select(x => {
    Thread.Sleep(1000);
    return x * 10;
});

Console.WriteLine("The 1st number is " + thisShouldTakeALongTime.First());
