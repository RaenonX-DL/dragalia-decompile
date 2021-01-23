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
	public interface IMethodInfo : IReflectionInfo
	{
		// Properties
		ITypeInfo TypeInfo { get; }
		MethodInfo MethodInfo { get; }
		string Name { get; }
		bool IsAbstract { get; }
		bool IsPublic { get; }
		bool ContainsGenericParameters { get; }
		bool IsGenericMethodDefinition { get; }
		ITypeInfo ReturnType { get; }
	
		// Methods
		IParameterInfo[] GetParameters();
		IMethodInfo MakeGenericMethod(params Type[] typeArguments);
		object Invoke(object fixture, params object[] args);
	}
}
