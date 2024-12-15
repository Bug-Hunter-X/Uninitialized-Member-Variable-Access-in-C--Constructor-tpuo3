# Uninitialized Member Variable Access in C# Constructor

This repository demonstrates a common error in C# where a member variable is accessed within a constructor before it has been initialized. This can lead to unexpected behavior or runtime exceptions. The `BuggyConstructor.cs` file showcases the problematic code, while `FixedConstructor.cs` provides a corrected version.

## Problem

Accessing a member variable before initialization can result in the variable holding a default value (e.g., 0 for integers, null for objects), potentially leading to unexpected calculations, incorrect logic, or exceptions.