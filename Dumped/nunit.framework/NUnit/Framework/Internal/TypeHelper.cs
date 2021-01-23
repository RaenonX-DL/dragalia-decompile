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
	public class TypeHelper
	{
		// Fields
		public static readonly Type NonmatchingType;
	
		// Nested types
		internal sealed class NonmatchingTypeClass
		{
		}
	
		// Constructors
		static TypeHelper();
	
		// Methods
		public static string GetDisplayName(Type type);
		public static string GetDisplayName(Type type, object[] arglist);
		public static Type BestCommonType(Type type1, Type type2);
		public static bool IsNumeric(Type type);
		public static void ConvertArgumentList(object[] arglist, IParameterInfo[] parameters);
		public static bool CanDeduceTypeArgsFromArgs(Type type, object[] arglist, ref Type[] typeArgsOut);
	}
}
