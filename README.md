# CLSS.Constants.NoOp

### Problem

How do you initialize a `System.Action`? If you do this:

```csharp
Action OnEvent = null;
```

You will have to null-check this delegate on every invocation.

To avoid null-checks, you can initialize it to a lambda that does nothing (in other word, a "No-Op"):

```csharp
Action OnEvent = delegate { };
```

But everytime you write an anonymous method, there is an allocation. So this will allocate 4 different runtime methods, all doing nothing:

```csharp
Action OnEvent1 = delegate { };
Action OnEvent2 = delegate { };
Action OnEvent3 = delegate { };
Action OnEvent4 = delegate { };
```

### Solution

`CLSS.Constants.NoOp` is a collection of statically-defined No-Op methods that can be used in any place you would want to use a no-op anonymous method to avoid unnecessary memory allocations.

**Example**:

```csharp
using CLSS;

Action OnEvent1 = NoOp.Method;
Action OnEvent2 = NoOp.Method;
Action OnEvent3 = NoOp.Method;
Action OnEvent4 = NoOp.Method;
```

Multi-argument No-Op:

```csharp
using CLSS;

Action<float, int> OnEvent = NoOp.Method<float, int>;
```

##### This package is a part of the [C# Language Syntactic Sugar suite](https://github.com/tonygiang/CLSS).