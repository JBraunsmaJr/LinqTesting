# LINQ

LINQ is a powerful library, and we all know how the saying goes. With great power comes great responsibility. If we misuse the LINQ methods we can suffer from multi-enumeration problems
to inefficient code.

## Setup

```csharp
var numbers = new int[10] { 399, 895, 319, 946, 339, 948, 807, 520, 643, 312 };
var search = 895;
```

## Scenario 1 - Do I Have?

Some might create the `where` clause and then use `any` to see if the result-set contains more than zero items.

```csharp
var iHas = numbers.Where(x => x == search).Any();
```

