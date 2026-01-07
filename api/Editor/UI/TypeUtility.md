## TypeUtility

`static class` in `AdvancedSceneManager.Editor.UI`### Description
Contains utility functions for working with types.

### Static Methods

| Member | Description |
|--------|-------------|
| `string GetFriendlyTypeName(Type type)` | Gets the friendly name of this type. |
| `string GetSignature(MemberInfo member, boolean includeAccessModifiers)` | Gets the signature of this member. |
| `boolean HasNoParameters(MemberInfo member)` | Gets if `member` is a `MethodInfo`, and has no parameters. |
| `boolean HasParameters<T1>(MemberInfo member)` | _No documentation available._ |
| `boolean HasParameters<T1, T2>(MemberInfo member)` | _No documentation available._ |
| `boolean HasParameters<T1, T2, T3>(MemberInfo member)` | _No documentation available._ |
| `boolean HasParameters<T1, T2, T3, T4>(MemberInfo member)` | _No documentation available._ |
| `boolean IsConstructor(MemberInfo member)` | Determines whether the specified `MemberInfo` represents a constructor. |
| `boolean IsField(MemberInfo member)` | Determines whether the specified `MemberInfo` represents a field. |
| `boolean IsMethod(MemberInfo member)` | Determines whether the specified `MemberInfo` represents a method. |
| `boolean IsMethodAndReturns<T>(MemberInfo member)` | _No documentation available._ |
| `boolean IsProperty(MemberInfo member)` | Determines whether the specified `MemberInfo` represents a property. |
| `boolean IsStatic(MemberInfo member)` | Determines whether the specified `MemberInfo` represents a static member. |
| `boolean IsType(MemberInfo member)` | Determines whether the specified `MemberInfo` represents a type. |
| `boolean IsType<T>(MemberInfo member)` | Determines whether the specified `MemberInfo` represents a type. |
| `boolean Returns<T>(MemberInfo member)` | _No documentation available._ |
| `boolean Returns(MemberInfo member, Type type)` | Gets if `member` returns `type`. |
| `boolean ReturnsCoroutine(MemberInfo member)` | Gets if `member` returns `IEnumerator`. |
| `boolean ReturnsVoid(MemberInfo member)` | Gets if `member` returns `Void`. |
| `Type ReturnType(MemberInfo member)` | Gets the return or value type of the specified `MemberInfo`. |