# Gilded Rose starting position in C# xUnit

## Performed refactoring:

* **SOLID:** Each update strategy is implemented in a separate class; `Item` does not contain all conditional logic.
* **DRY:** Common operations like `DecreaseSellIn`, `IncreaseQuality`, and `DecreaseQuality` are encapsulated within `Item`.
* **KISS:** Each strategy performs only its specific behavior.
* **DDD:** `Item` is an aggregate with its own behavior, and the factory creates the appropriate strategies.
* All Unit and Approval tests passed successfully.

## Build the project

Use your normal build tools to build the projects in Debug mode.
For example, you can use the `dotnet` command line tool:

``` cmd
dotnet build GildedRose.sln -c Debug
```

## Run the Gilded Rose Command-Line program

For e.g. 10 days:

``` cmd
./GildedRose/bin/Debug/net8.0/GildedRose 10
```

## Run all the unit tests

``` cmd
dotnet test
```

