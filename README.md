**Passing Value Type Variables
When you pass a value-type variable from one method to another, the system creates a separate copy of a variable in another method.
 If value got changed in the one method, it wouldn't affect the variable in another method.

**Passing Reference Type Variables
When you pass a reference type variable from one method to another, it doesn't create a new copy; instead, it passes the variable's address.
 So, If we change the value of a variable in a method, it will also be reflected in the calling method.

String is a reference type, but it is immutable. It means once we assigned a value, it cannot be changed. If we change a string value,
then the compiler creates a new string object in the memory and point a variable to the new memory location.
So, passing a string value to a function will create a new variable in the memory,
and any change in the value in the function will not be reflected in the original value