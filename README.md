**Rules for Static Class
Static classes cannot be instantiated.
All the members of a static class must be static; otherwise the compiler will give an error.
A static class can contain static variables, static methods, static properties, static operators, static events, and static constructors.
A static class cannot contain instance members and constructors.
Indexers and destructors cannot be static
var cannot be used to define static members. You must specify a type of member explicitly after the static keyword.
Static classes are sealed class and therefore, cannot be inherited.
A static class cannot inherit from other classes.
Static class members can be accessed using ClassName.MemberName.
A static class remains in memory for the lifetime of the application domain in which your program resides.


**Static Members in Non-static Class
The normal class (non-static class) can contain one or more static methods, fields, properties, events and other non-static members.
It is more practical to define a non-static class with some static members, than to declare an entire class as static.


**Static Fields
Static fields in a non-static class can be defined using the static keyword.
Static fields of a non-static class is shared across all the instances. So, changes done by one instance would reflect in others.



**Rules for Static Methods
Static methods can be defined using the static keyword before a return type and after an access modifier.
Static methods can be overloaded but cannot be overridden.
Static methods can contain local static variables.
Static methods cannot access or call non-static variables unless they are explicitly passed as parameters.



**Rules for Static Constructors
The static constructor is defined using the static keyword and without using access modifiers public, private, or protected.
A non-static class can contain one parameterless static constructor. Parameterized static constructors are not allowed.
Static constructor will be executed only once in the lifetime. So, you cannot determine when it will get called in an application if a class is being used at multiple places.
A static constructor can only access static members. It cannot contain or access instance members.