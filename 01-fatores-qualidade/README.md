# Software Quality Factors

This module explores some fundamental software quality factos through pratical C# examples.

The goal is to understand how code structure, naming conventions, modularity, and maintainability can affect the quality of a software solution.

## Concepts

- Code readability
- Naming conventions
- Modularity
- Maintainability
- Separation of responsabilities

## Examples

The examples in this module show the evolution of the same calculation through different approaches:

- `ExemploCodigoPoucoLegivel.cs` — demonstrates code with unclear naming
  and structure.
- `ExemploCodigoLegivel.cs` — improves readability through descriptive
  variable names.
- `ExemploCodigoNaoModular.cs` — demonstrates a solution where the
  calculation logic is concentrated in a single place.
- `ExemploCodigoManutenivel.cs` — separates calculation responsibilities
  into reusable methods.

## Modularization

The `CalculoPreco.cs` class contains reusable calculation methods,
allowing the main example to focus on the flow of the operation rather
than the implementation details of each calculation.

This separation makes the code easier to maintain and allows individual
rules to be changed without unnecessarily affecting the rest of the
application.

  ## What I Learned

  The main lesson from this module is the code quality is not only about making a program work.

  Readable and maintanable code makes it easier to understand, modify, test, and extend a software solution without unncessarily affecting other parts of the system.