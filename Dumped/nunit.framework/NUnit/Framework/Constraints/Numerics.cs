/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Constraints
{
	public class Numerics
	{
		// Methods
		public static bool IsNumericType(object obj);
		public static bool IsFloatingPointNumeric(object obj);
		public static bool IsFixedPointNumeric(object obj);
		public static bool AreEqual(object expected, object actual, ref Tolerance tolerance);
		private static bool AreEqual(double expected, double actual, ref Tolerance tolerance);
		private static bool AreEqual(float expected, float actual, ref Tolerance tolerance);
		private static bool AreEqual(decimal expected, decimal actual, Tolerance tolerance);
		private static bool AreEqual(ulong expected, ulong actual, Tolerance tolerance);
		private static bool AreEqual(long expected, long actual, Tolerance tolerance);
		private static bool AreEqual(uint expected, uint actual, Tolerance tolerance);
		private static bool AreEqual(int expected, int actual, Tolerance tolerance);
	}
}
