<Query Kind="Statements">
  <Reference Relative="..\References\System.Reactive.dll">..\References\System.Reactive.dll</Reference>
  <Reference Relative="..\References\Microsoft.Reactive.Testing.dll">..\References\Microsoft.Reactive.Testing.dll</Reference>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>Microsoft.Reactive.Testing</Namespace>
</Query>

/* Take 1:
 *
 * Return a subset of the items in the collection.
 */

var input = new[] {1,2,3,4,5,4,3,2,1};
var output = input.Take(5).Select(x => x * 10);

output.Dump();
