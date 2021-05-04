using System;
using System.Reflection;

namespace _5951071068_NguyenNhan_Buoi2.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}