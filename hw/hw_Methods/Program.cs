

// create a welcome method,
// a method to ask the user's name,
// and another to tell the user "Hello, <name>".
// call these methods from program.cs

using hw_Methods;

Helper helper = new();

helper.Welcome(helper.GetName());

Console.ReadKey();