/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Interfaces;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public class MethodWrapper : IMethodInfo
	{
		// Fields
		[CompilerGenerated]
		private ITypeInfo _TypeInfo_k__BackingField;
		[CompilerGenerated]
		private MethodInfo _MethodInfo_k__BackingField;
	
		// Properties
		public ITypeInfo TypeInfo { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public MethodInfo MethodInfo { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string Name { get; }
		public bool IsAbstract { get; }
		public bool IsPublic { get; }
		public bool ContainsGenericParameters { get; }
		public bool IsGenericMethodDefinition { get; }
		public ITypeInfo ReturnType { get; }
	
		// Constructors
		public MethodWrapper(Type type, MethodInfo method);
	
		// Methods
		public IParameterInfo[] GetParameters();
		public IMethodInfo MakeGenericMethod(params Type[] typeArguments);
		public T[] GetCustomAttributes<T>(bool inherit)
			where T : class;
		public bool IsDefined<T>(bool inherit);
		public object Invoke(object fixture, params object[] args);
		public override string ToString();
	}
}
