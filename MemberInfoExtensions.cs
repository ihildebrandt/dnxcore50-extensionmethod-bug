using System;
using System.Reflection;
using System.Linq;

namespace BugDemo
{
    public static class MemberInfoExtensions
    {
        public static TAttribute[] GetCustomAttributes<TAttribute>(this MemberInfo methodInfo, Func<TAttribute, bool> predicate, bool inherit)
        {
            return methodInfo.GetCustomAttributes(typeof(TAttribute), inherit)
                .Cast<TAttribute>().ToArray();
        }
    }
}
