using System;

namespace Cute.Core
{
	public class TimeUtil
	{
		public struct TimeLeftParam
		{
			public int day;

			public int hour;

			public int minute;

			public int second;

			public int count;

			public bool isEnd;

			public bool isCharge;

			public TimeLeftParam(long unixTime, long consumingTime)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		private static string dateTimeFormat;

		public static readonly DateTime UNIX_EPOCH;

		public const int DAY_HOUR = 24;

		public const int DAY_SECOND = 86400;

		public const int HOUR_SECOND = 3600;

		public const int MINUTE_SECOND = 60;

		public static readonly TimeSpan localTimeSpan;

		private static DateTime serverTime;

		public static DateTime ServerUtcNow
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public static void SetDateTimeFormat(string format)
		{
		}

		public static long ToUnixTime(DateTime dateTime)
		{
			return default(long);
		}

		public static DateTime FromUnixTimeToJst(long unixTime)
		{
			return default(DateTime);
		}

		public static DateTime FromUnixTimeToUtc(long unixTime)
		{
			return default(DateTime);
		}

		public static DateTime ParseJst(string str)
		{
			return default(DateTime);
		}

		public static DateTime? TryParseJst(string str)
		{
			return null;
		}

		public static bool TryParseJst(string str, out DateTime date)
		{
			return default(bool);
		}

		public static DateTime ParseUtc(string str)
		{
			return default(DateTime);
		}

		public static DateTime? TryParseUtc(string str)
		{
			return null;
		}

		public static bool TryParseUtc(string str, out DateTime date)
		{
			return default(bool);
		}

		public static TimeLeftParam GetTimeLeft(long nowTime, long endTime, long consumingTime = 0L)
		{
			return default(TimeLeftParam);
		}
	}
}
