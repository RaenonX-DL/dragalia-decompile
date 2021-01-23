/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public class GenericMethodHelper
	{
		// Fields
		[CompilerGenerated]
		private MethodInfo _Method_k__BackingField;
		[CompilerGenerated]
		private Type[] _TypeParms_k__BackingField;
		[CompilerGenerated]
		private Type[] _TypeArgs_k__BackingField;
		[CompilerGenerated]
		private Type[] _ParmTypes_k__BackingField;
	
		// Properties
		private MethodInfo Method { [CompilerGenerated] get; [CompilerGenerated] set; }
		private Type[] TypeParms { [CompilerGenerated] get; [CompilerGenerated] set; }
		private Type[] TypeArgs { [CompilerGenerated] get; [CompilerGenerated] set; }
		private Type[] ParmTypes { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public GenericMethodHelper(MethodInfo method);
	
		// Methods
		public Type[] GetTypeArguments(object[] argList);
		private void TryApplyArgType(Type parmType, Type argType);
		private void ApplyArgType(Type parmType, Type argType);
		private bool IsAssignableToGenericType(Type givenType, Type genericType);
	}
}
