## TypeUtility

`static class` in `AdvancedSceneManager.Editor.UI`### Description

### Static Methods

| Member | Description |
|--------|-------------|
| `string GetFriendlyTypeName(Type type)` | _No documentation available._ |
| `string GetSignature(MemberInfo member, boolean includeAccessModifiers)` | _No documentation available._ |
| `boolean HasNoParameters(MemberInfo member)` | Gets if `member` is a `MethodInfo`, and has no parameters. |
| `boolean HasParameters<T1>(MemberInfo member)` | _No documentation available._ |
| `boolean HasParameters<T1, T2>(MemberInfo member)` | _No documentation available._ |
| `boolean HasParameters<T1, T2, T3>(MemberInfo member)` | _No documentation available._ |
| `boolean HasParameters<T1, T2, T3, T4>(MemberInfo member)` | _No documentation available._ |
| `boolean IsConstructor(MemberInfo member)` | _No documentation available._ |
| `boolean IsField(MemberInfo member)` | _No documentation available._ |
| `boolean IsMethod(MemberInfo member)` | _No documentation available._ |
| `boolean IsMethodAndReturns<T>(MemberInfo member)` | _No documentation available._ |
| `boolean IsProperty(MemberInfo member)` | _No documentation available._ |
| `boolean IsStatic(MemberInfo member)` | _No documentation available._ |
| `boolean IsType(MemberInfo member)` | _No documentation available._ |
| `boolean IsType<T>(MemberInfo member)` | _No documentation available._ |
| `boolean Returns<T>(MemberInfo member)` | _No documentation available._ |
| `boolean Returns(MemberInfo member, Type type)` | Gets if `member` returns `type`. |
| `boolean ReturnsCoroutine(MemberInfo member)` | Gets if `member` returns `IEnumerator`. |
| `boolean ReturnsVoid(MemberInfo member)` | Gets if `member` returns `Void`. |
| `Type ReturnType(MemberInfo member)` | _No documentation available._ |