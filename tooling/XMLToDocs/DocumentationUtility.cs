using System;
using System.Linq.Expressions;
using System.Reflection;

namespace AdvancedSceneManager.Documentation
{

    public static partial class DocumentationUtility
    {

        public static MemberDocumentation GetDocumentation<T>() =>
            GetDocumentation(typeof(T));

        public static MemberDocumentation GetDocumentation(Type type) =>
            GetDocumentation(member: type);

        public static MemberDocumentation GetDocumentation(Expression<Action> func)
        {
            var member = GetMemberInfo(func.Body);
            return GetDocumentation(member);
        }

        private static MemberInfo GetMemberInfo(Expression expr)
        {
            return expr switch
            {
                MethodCallExpression callExpr => callExpr.Method,
                MemberExpression memberExpr => memberExpr.Member,
                UnaryExpression unaryExpr => GetMemberInfo(unaryExpr.Operand),
                _ => throw new NotSupportedException($"Unsupported expression type {expr.GetType().Name}")
            };
        }

    }

}
