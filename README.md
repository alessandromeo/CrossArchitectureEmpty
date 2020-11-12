# Cross Architecture Example Application (nearly empty)

This repository contains an example of "nearly empty" .NET Core 3.1 application structured following the
**[Cross Architecture](https://alessandromeo.github.io/cross-architecture)** approach; in particular:

* each *Logical Area* is implemented by a single .NET Core project;
* each *Unit Composition Ring* and *Integration Composition Ring* is implemented by a single .NET Core project;
* the *Application Host* is implemented by a single ASP.NET Core (web API) project;
* the projects contain a set of very simple classes, whose only aim is to show the relation (injections and execution flow) between *Logical Areas*.

## Cross Architecture

The **Cross Architecture** is a flexible approach for designing the architecture of a SW over the actual application needs,
while respecting a set of basic constraints providing good decoupling, testability and logical organization of code.

More information about the **Cross Architecture** approach [can be found here](https://alessandromeo.github.io/cross-architecture).

## How to run

To start the application simply open the solution in Visual Studio 2019 and hit F5 ("Start Debugging") or CTRL+F5 ("Start Without Debugging"):
a web browser will open showing the JSON result of a test web API action.

Also, you can start the application by running the following command from the solution folder:
```
dotnet run --project CrossArchitecture.ApplicationHost
```
Then, browsing to https://localhost:5001 you will be redirected to the test web API action.

*Remarks*: the test web API action triggers a call traversing all the SW blocks of the application and creating the temporary file indicated in the
returned JSON data; this is in order to show a complete execution flow across the various SW blocks, also producing a side effect into an external
system (in this case the file system).
