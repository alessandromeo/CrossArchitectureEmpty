# Cross Architecture Example Solution (Empty)

This repository contains an example .NET Core solution structured following the **[Cross Architecture](https://alessandromeo.github.io/cross-architecture)** approach; in particular:

* each *Logical Area* is implemented by a single .NET Standard project;
* each *"U" Composition Ring* and *"I" Composition Ring* is implemented by a single .NET Standard project;
* the *Application Host* is implemented by a single ASP.NET Core (web API) project;
* the projects contain a set of very simple classes, whose only aim is to show the relation (injections and execution flow) between *Logical Areas*.

More information about the **Cross Architecture** approach [can be found here](https://alessandromeo.github.io/cross-architecture).
