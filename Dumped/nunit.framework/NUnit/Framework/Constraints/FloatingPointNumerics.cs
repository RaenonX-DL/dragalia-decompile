/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Constraints
{
	public class FloatingPointNumerics
	{
		// Nested types
		private struct FloatIntUnion
		{
			// Fields
			public float Float;
			public int Int;
			public uint UInt;
		}
	
		private struct DoubleLongUnion
		{
			// Fields
			public double Double;
			public long Long;
			public ulong ULong;
		}
	
		// Methods
		public static bool AreAlmostEqualUlps(float left, float right, int maxUlps);
		public static bool AreAlmostEqualUlps(double left, double right, long maxUlps);
	}
}
