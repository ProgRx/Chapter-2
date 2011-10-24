<Query Kind="Statements">
  <Reference Relative="..\References\System.Reactive.dll">..\References\System.Reactive.dll</Reference>
  <Reference Relative="..\References\Microsoft.Reactive.Testing.dll">..\References\Microsoft.Reactive.Testing.dll</Reference>
  <Namespace>System.Reactive</Namespace>
  <Namespace>System.Reactive.Linq</Namespace>
  <Namespace>Microsoft.Reactive.Testing</Namespace>
</Query>

/* Distinct 1:
 *
 * Distinct returns the set of unique items in a collection, removing any
 * duplicate items.
 */

var input = new[] {1,2,3,2,1,2,3,2,1,2,3,2,1};
input.Distinct().Dump();
