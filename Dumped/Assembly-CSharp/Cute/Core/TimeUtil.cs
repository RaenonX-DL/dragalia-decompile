/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class TimeUtil
	{
		// Fields
		private static string dateTimeFormat;
		public static readonly DateTime UNIX_EPOCH;
		public const int DAY_HOUR = 24;
		public const int DAY_SECOND = 86400;
		public const int HOUR_SECOND = 3600;
		public const int MINUTE_SECOND = 60;
		public static readonly TimeSpan localTimeSpan;
		private static DateTime serverTime;
	
		// Properties
		public static DateTime ServerUtcNow { get; set; }
	
		// Nested types
		public struct TimeLeftParam
		{
			// Fields
			public int day;
			public int hour;
			public int minute;
			public int second;
			public int count;
			public bool isEnd;
			public bool isCharge;
	
			// Constructors
			public TimeLeftParam(long unixTime, long consumingTime);
	
			// Methods
			public override string ToString();
		}
	
		// Constructors
		public TimeUtil();
		static TimeUtil();
	
		// Methods
		public static void SetDateTimeFormat(string format);
		public static long ToUnixTime(DateTime dateTime);
		public static DateTime FromUnixTimeToJst(long unixTime);
		public static DateTime FromUnixTimeToUtc(long unixTime);
		public static DateTime ParseJst(string str);
		public static DateTime? TryParseJst(string str);
		public static bool TryParseJst(string str, out DateTime date);
		public static DateTime ParseUtc(string str);
		public static DateTime? TryParseUtc(string str);
		public static bool TryParseUtc(string str, out DateTime date);
		public static TimeLeftParam GetTimeLeft(long nowTime, long endTime, long consumingTime = 0);
	}
}
