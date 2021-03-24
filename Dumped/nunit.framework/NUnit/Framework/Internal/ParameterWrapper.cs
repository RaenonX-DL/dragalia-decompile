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
	public class ParameterWrapper : IParameterInfo
	{
		// Fields
		[CompilerGenerated]
		private IMethodInfo _Method_k__BackingField;
		[CompilerGenerated]
		private ParameterInfo _ParameterInfo_k__BackingField;
	
		// Properties
		public bool IsOptional { get; }
		private IMethodInfo Method { [CompilerGenerated] set; }
		public ParameterInfo ParameterInfo { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Type ParameterType { get; }
	
		// Constructors
		public ParameterWrapper(IMethodInfo method, ParameterInfo parameterInfo);
	
		// Methods
		public T[] GetCustomAttributes<T>(bool inherit)
			where T : class;
		public bool IsDefined<T>(bool inherit);
	}
}
