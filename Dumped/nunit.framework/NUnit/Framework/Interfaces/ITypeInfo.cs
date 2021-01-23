/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Interfaces
{
	public interface ITypeInfo : IReflectionInfo
	{
		// Properties
		Type Type { get; }
		ITypeInfo BaseType { get; }
		string FullName { get; }
		Assembly Assembly { get; }
		string Namespace { get; }
		bool IsAbstract { get; }
		bool IsGenericType { get; }
		bool ContainsGenericParameters { get; }
		bool IsGenericTypeDefinition { get; }
		bool IsSealed { get; }
		bool IsStaticClass { get; }
	
		// Methods
		bool IsType(Type type);
		string GetDisplayName();
		string GetDisplayName(object[] args);
		Type GetGenericTypeDefinition();
		ITypeInfo MakeGenericType(Type[] typeArgs);
		bool HasMethodWithAttribute(Type attrType);
		IMethodInfo[] GetMethods(BindingFlags flags);
		ConstructorInfo GetConstructor(Type[] argTypes);
		bool HasConstructor(Type[] argTypes);
		object Construct(object[] args);
	}
}
