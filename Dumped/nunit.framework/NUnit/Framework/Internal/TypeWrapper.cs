/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Interfaces;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public class TypeWrapper : ITypeInfo
	{
		// Fields
		[CompilerGenerated]
		private Type _Type_k__BackingField;
	
		// Properties
		public Type Type { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ITypeInfo BaseType { get; }
		public string FullName { get; }
		public Assembly Assembly { get; }
		public string Namespace { get; }
		public bool IsAbstract { get; }
		public bool IsGenericType { get; }
		public bool ContainsGenericParameters { get; }
		public bool IsGenericTypeDefinition { get; }
		public bool IsSealed { get; }
		public bool IsStaticClass { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1
		{
			// Fields
			public Type[] argTypes;
	
			// Constructors
			public __c__DisplayClass1();
	
			// Methods
			public bool _GetConstructor_b__0(ConstructorInfo c);
		}
	
		// Constructors
		public TypeWrapper(Type type);
	
		// Methods
		public bool IsType(Type type);
		public string GetDisplayName();
		public string GetDisplayName(object[] args);
		public ITypeInfo MakeGenericType(Type[] typeArgs);
		public Type GetGenericTypeDefinition();
		public T[] GetCustomAttributes<T>(bool inherit)
			where T : class;
		public bool IsDefined<T>(bool inherit);
		public bool HasMethodWithAttribute(Type attributeType);
		public IMethodInfo[] GetMethods(BindingFlags flags);
		public ConstructorInfo GetConstructor(Type[] argTypes);
		public bool HasConstructor(Type[] argTypes);
		public object Construct(object[] args);
		public override string ToString();
	}
}
