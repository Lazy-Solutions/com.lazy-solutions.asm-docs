using System;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEditor;

namespace AdvancedSceneManager.Documentation
{
    static class TypeUtility
    {

        #region Friendly type name

        public static string GetSignature(this MemberInfo member, bool includeAccessModifiers = true, bool includeStaticIndicator = true)
        {
            return member switch
            {
                Type t => GetTypeSignature(t, includeAccessModifiers, includeStaticIndicator),
                FieldInfo f => GetFieldSignature(f, includeAccessModifiers, includeStaticIndicator),
                PropertyInfo p => GetPropertySignature(p, includeAccessModifiers, includeStaticIndicator),
                MethodInfo m => GetMethodSignature(m, includeAccessModifiers, includeStaticIndicator),
                EventInfo e => GetEventSignature(e, includeAccessModifiers, includeStaticIndicator),
                _ => member.Name
            };
        }

        private static string GetTypeSignature(Type type, bool includeAccessModifiers, bool includeStaticIndicator)
        {
            var sb = new StringBuilder();

            if (includeAccessModifiers)
                sb.Append(GetAccessModifier(type));

            if (type.IsAbstract && type.IsSealed) sb.Append("static ");
            else if (type.IsAbstract) sb.Append("abstract ");
            else if (type.IsSealed) sb.Append("sealed ");

            if (type.IsClass) sb.Append("class ");
            else if (type.IsInterface) sb.Append("interface ");
            else if (type.IsEnum) sb.Append("enum ");
            else if (type.IsValueType) sb.Append("struct ");

            sb.Append(GetFriendlyTypeName(type));
            return sb.ToString();
        }


        private static string GetFieldSignature(FieldInfo field, bool includeAccessModifiers, bool includeStaticIndicator)
        {
            var sb = new StringBuilder();

            if (includeAccessModifiers)
                sb.Append(GetAccessModifier(field));

            if (field.IsStatic && includeStaticIndicator) sb.Append("static ");
            if (field.IsInitOnly) sb.Append("readonly ");

            sb.Append(GetFriendlyTypeName(field.FieldType)).Append(" ").Append(field.Name);
            return sb.ToString();
        }

        private static string GetPropertySignature(PropertyInfo prop, bool includeAccessModifiers, bool includeStaticIndicator)
        {
            var sb = new StringBuilder();

            if (includeAccessModifiers)
                sb.Append(GetAccessModifier(prop.GetMethod ?? prop.SetMethod));

            if ((prop.GetMethod ?? prop.SetMethod)?.IsStatic == true && includeStaticIndicator)
                sb.Append("static ");

            sb.Append(GetFriendlyTypeName(prop.PropertyType)).Append(" ").Append(prop.Name);

            // only show accessor info if interesting
            var hasGetter = prop.CanRead && prop.GetMethod?.IsPublic == true;
            var hasSetter = prop.CanWrite && prop.SetMethod != null;

            if (hasSetter && (prop.SetMethod?.IsPublic ?? false) == false)
            {
                sb.Append(" { get; }");
            }
            else if (includeAccessModifiers && (hasGetter || hasSetter))
            {
                sb.Append(" { ");
                if (hasGetter) sb.Append("get; ");
                if (hasSetter) sb.Append("set; ");
                sb.Append("}");
            }

            return sb.ToString().Trim();
        }

        private static string GetMethodSignature(MethodInfo method, bool includeAccessModifiers, bool includeStaticIndicator)
        {
            var sb = new StringBuilder();

            if (includeAccessModifiers)
                sb.Append(GetAccessModifier(method));

            if (method.IsStatic && includeStaticIndicator) sb.Append("static ");
            if (method.IsAbstract) sb.Append("abstract ");
            if (method.IsVirtual && !method.IsFinal) sb.Append("virtual ");

            sb.Append(GetFriendlyTypeName(method.ReturnType)).Append(" ").Append(method.Name);

            if (method.IsGenericMethod)
            {
                var args = string.Join(", ", method.GetGenericArguments().Select(GetFriendlyTypeName));
                sb.Append("<").Append(args).Append(">");
            }

            var parameters = string.Join(", ",
                method.GetParameters().Select(p => GetFriendlyTypeName(p.ParameterType) + " " + p.Name));
            sb.Append("(").Append(parameters).Append(")");

            return sb.ToString();
        }

        private static string GetEventSignature(EventInfo evt, bool includeAccessModifiers, bool includeStaticIndicator)
        {
            var sb = new StringBuilder();

            if (includeAccessModifiers)
                sb.Append(GetAccessModifier(evt.AddMethod));

            if (evt.AddMethod.IsStatic && includeStaticIndicator) sb.Append("static ");

            sb.Append("event ").Append(GetFriendlyTypeName(evt.EventHandlerType)).Append(" ").Append(evt.Name);
            return sb.ToString();
        }

        private static string GetAccessModifier(FieldInfo field)
        {
            if (field.IsPublic) return "public ";
            if (field.IsFamily) return "protected ";
            if (field.IsAssembly) return "internal ";
            if (field.IsPrivate) return "private ";
            return "";
        }

        private static string GetAccessModifier(Type type)
        {
            if (type.IsPublic || type.IsNestedPublic) return "public ";
            if (type.IsNestedFamily) return "protected ";
            if (type.IsNotPublic || type.IsNestedAssembly) return "internal ";
            if (type.IsNestedPrivate) return "private ";
            return "";
        }

        private static string GetAccessModifier(EventInfo evt) =>
            GetAccessModifier(evt.AddMethod);

        private static string GetAccessModifier(PropertyInfo prop) =>
            GetAccessModifier(prop.GetMethod ?? prop.SetMethod);

        private static string GetAccessModifier(MethodBase method)
        {
            if (method == null) return "";
            if (method.IsPublic) return "public ";
            if (method.IsFamily) return "protected ";
            if (method.IsAssembly) return "internal ";
            if (method.IsPrivate) return "private ";
            return "";
        }

        public static string GetFriendlyTypeName(this Type type)
        {
            if (type.IsGenericParameter)
                return type.Name;

            if (type.IsGenericType)
            {
                var backtick = type.Name.IndexOf('`');
                var genericTypeName = backtick >= 0 ? type.Name.Substring(0, backtick) : type.Name;
                var genericArgs = string.Join(", ", type.GetGenericArguments().Select(GetFriendlyTypeName));
                return $"{genericTypeName}<{genericArgs}>";
            }

            if (type.IsArray)
                return GetFriendlyTypeName(type.GetElementType()) + "[]";

            // Map CLR names to C# keywords
            return type.Name switch
            {
                "Void" => "void",
                "String" => "string",
                "Object" => "object",
                "Decimal" => "decimal",
                _ => type.IsPrimitive ? type.Name.ToLower() : type.Name
            };
        }

        #endregion

        public static bool IsStatic(this MemberInfo member) => member switch
        {
            MethodInfo m => m.IsStatic,
            PropertyInfo p => p.GetGetMethod(true)?.IsStatic ?? false,
            FieldInfo f => f.IsStatic,
            _ => false
        };

        public static Type ReturnType(this MemberInfo member) => member switch
        {
            MethodInfo m => m.ReturnType,
            PropertyInfo p => p.PropertyType,
            FieldInfo f => f.FieldType,
            Type t => t,
            EventInfo e => e.EventHandlerType,
            _ => null
        };

    }

}
