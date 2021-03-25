Strings are immutable in C#:
Mutable means can be changed whereas Immutable means can not be changed. C# strings are immutable means C# strings cannot be changed.

 When the first statement executed, it will create one object and assign the value DotNet.
But when the second statement executed, it will not override the first object,
it lets the first object to be their for garbage collection and creates a fresh object and assign the value Tutorials.

Strings are immutable in C#

So, when the above two statements executed, internally two memory locations are created.
 One with the value DotNet and the current one with the value Tutorials and the current one is going to be referred in the program. So, each time,
 you assign a new value to the string variable, a new object is created and this is the reason why strings are immutable.

NB:  this is not the case with value type.

String Interning in C#:
if you are running a for loop and assigning the same value again and again, then it uses string interning to improve the performance.
In this case rather than creating new object, it uses the same memory location.

StringBuilder for concatenation:
In order to solve the above string concatenation problem, the .NET Framework provides StringBuilder class. As the name itself saying everything,
the string builder class is used to build a string. If you use string builder then fresh objects are not going to created.

Why they made C# String as Immutable?
They made Strings as Immutable for Thread Safety
