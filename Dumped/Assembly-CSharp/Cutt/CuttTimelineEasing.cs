/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public static class CuttTimelineEasing
	{
		// Fields
		private static int _easeTypeMax;
		private static EasingFunctionDelegate[] _functions;
	
		// Properties
		public static int easeTypeMax { get; }
	
		// Nested types
		public enum Type
		{
			Linear = 0,
			ExpoEaseOut = 1,
			ExpoEaseIn = 2,
			ExpoEaseInOut = 3,
			ExpoEaseOutIn = 4,
			CircEaseOut = 5,
			CircEaseIn = 6,
			CircEaseInOut = 7,
			CircEaseOutIn = 8,
			QuadEaseOut = 9,
			QuadEaseIn = 10,
			QuadEaseInOut = 11,
			QuadEaseOutIn = 12,
			SineEaseOut = 13,
			SineEaseIn = 14,
			SineEaseInOut = 15,
			SineEaseOutIn = 16,
			CubicEaseOut = 17,
			CubicEaseIn = 18,
			CubicEaseInOut = 19,
			CubicEaseOutIn = 20,
			QuartEaseOut = 21,
			QuartEaseIn = 22,
			QuartEaseInOut = 23,
			QuartEaseOutIn = 24,
			QuintEaseOut = 25,
			QuintEaseIn = 26,
			QuintEaseInOut = 27,
			QuintEaseOutIn = 28,
			ElasticEaseOut = 29,
			ElasticEaseIn = 30,
			ElasticEaseInOut = 31,
			ElasticEaseOutIn = 32,
			BounceEaseOut = 33,
			BounceEaseIn = 34,
			BounceEaseInOut = 35,
			BounceEaseOutIn = 36,
			BackEaseOut = 37,
			BackEaseIn = 38,
			BackEaseInOut = 39,
			BackEaseOutIn = 40
		}
	
		private delegate double EasingFunctionDelegate(double t, double b, double c, double d);
	
		// Constructors
		static CuttTimelineEasing();
	
		// Methods
		public static float GetValue(Type type, float t, float b, float c, float d);
		public static double Linear(double t, double b, double c, double d);
		public static double ExpoEaseOut(double t, double b, double c, double d);
		public static double ExpoEaseIn(double t, double b, double c, double d);
		public static double ExpoEaseInOut(double t, double b, double c, double d);
		public static double ExpoEaseOutIn(double t, double b, double c, double d);
		public static double CircEaseOut(double t, double b, double c, double d);
		public static double CircEaseIn(double t, double b, double c, double d);
		public static double CircEaseInOut(double t, double b, double c, double d);
		public static double CircEaseOutIn(double t, double b, double c, double d);
		public static double QuadEaseOut(double t, double b, double c, double d);
		public static double QuadEaseIn(double t, double b, double c, double d);
		public static double QuadEaseInOut(double t, double b, double c, double d);
		public static double QuadEaseOutIn(double t, double b, double c, double d);
		public static double SineEaseOut(double t, double b, double c, double d);
		public static double SineEaseIn(double t, double b, double c, double d);
		public static double SineEaseInOut(double t, double b, double c, double d);
		public static double SineEaseOutIn(double t, double b, double c, double d);
		public static double CubicEaseOut(double t, double b, double c, double d);
		public static double CubicEaseIn(double t, double b, double c, double d);
		public static double CubicEaseInOut(double t, double b, double c, double d);
		public static double CubicEaseOutIn(double t, double b, double c, double d);
		public static double QuartEaseOut(double t, double b, double c, double d);
		public static double QuartEaseIn(double t, double b, double c, double d);
		public static double QuartEaseInOut(double t, double b, double c, double d);
		public static double QuartEaseOutIn(double t, double b, double c, double d);
		public static double QuintEaseOut(double t, double b, double c, double d);
		public static double QuintEaseIn(double t, double b, double c, double d);
		public static double QuintEaseInOut(double t, double b, double c, double d);
		public static double QuintEaseOutIn(double t, double b, double c, double d);
		public static double ElasticEaseOut(double t, double b, double c, double d);
		public static double ElasticEaseIn(double t, double b, double c, double d);
		public static double ElasticEaseInOut(double t, double b, double c, double d);
		public static double ElasticEaseOutIn(double t, double b, double c, double d);
		public static double BounceEaseOut(double t, double b, double c, double d);
		public static double BounceEaseIn(double t, double b, double c, double d);
		public static double BounceEaseInOut(double t, double b, double c, double d);
		public static double BounceEaseOutIn(double t, double b, double c, double d);
		public static double BackEaseOut(double t, double b, double c, double d);
		public static double BackEaseIn(double t, double b, double c, double d);
		public static double BackEaseInOut(double t, double b, double c, double d);
		public static double BackEaseOutIn(double t, double b, double c, double d);
	}
}
