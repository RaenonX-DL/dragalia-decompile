/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public class ActionsHelper
	{
		// Methods
		public static ITestAction[] GetActionsFromTestAssembly(TestAssembly testAssembly);
		public static ITestAction[] GetActionsFromTestMethodInfo(IMethodInfo testAssembly);
		public static ITestAction[] GetActionsFromAttributeProvider(ICustomAttributeProvider attributeProvider);
		public static ITestAction[] GetActionsFromTypesAttributes(Type type);
		private static Type[] GetDeclaredInterfaces(Type type);
		private static int SortByTargetDescending(ITestAction x, ITestAction y);
	}
}
