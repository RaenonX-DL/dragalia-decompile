/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public static class MathUtils
	{
		// Fields
		public const float PI = 3.1415927f;
		public const float PI2 = 6.2831855f;
		public const float RadDeg = 57.295776f;
		public const float DegRad = 0.017453292f;
		private const int SIN_BITS = 14;
		private const int SIN_MASK = 16383;
		private const int SIN_COUNT = 16384;
		private const float RadFull = 6.2831855f;
		private const float DegFull = 360f;
		private const float RadToIndex = 2607.5945f;
		private const float DegToIndex = 45.511112f;
		private static float[] sin;
	
		// Constructors
		static MathUtils();
	
		// Methods
		public static float Sin(float radians);
		public static float Cos(float radians);
		public static float SinDeg(float degrees);
		public static float CosDeg(float degrees);
		public static float Atan2(float y, float x);
		public static float Clamp(float value, float min, float max);
	}
}
