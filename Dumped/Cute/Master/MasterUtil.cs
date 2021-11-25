using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Cute.Master
{
	public static class MasterUtil
	{
		public class EnumCache<T>
		{
			private static Dictionary<string, T> cache;

			public static T Get(string s)
			{
				return (T)null;
			}
		}

		public static Func<string, string> Localize;

		private static readonly char[] separator;

		private static readonly NumberStyles intStyle;

		private static readonly NumberStyles floatStyle;

		private static readonly CultureInfo culture;

		private static readonly Regex groupMatch;

		public static bool IsStrictImport
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static string SnakeToUpperCamel(string src)
		{
			return null;
		}

		public static bool IsGroupInstance(string path, out string baseName, out int id)
		{
			return default(bool);
		}

		public static string[] ToStringArray(string src)
		{
			return null;
		}

		public static int[] ToIntArray(string src)
		{
			return null;
		}

		public static long[] ToLongArray(string src)
		{
			return null;
		}

		public static float[] ToFloatArray(string src)
		{
			return null;
		}

		public static bool[] ToBoolArray(string src)
		{
			return null;
		}

		public static object[] ToEnumArray(string src, Type enumType)
		{
			return null;
		}

		public static int ToInt(string[] values, int[] indexes, int index)
		{
			return default(int);
		}

		public static long ToLong(string[] values, int[] indexes, int index)
		{
			return default(long);
		}

		public static float ToFloat(string[] values, int[] indexes, int index)
		{
			return default(float);
		}

		public static string ToString(string[] values, int[] indexes, int index)
		{
			return null;
		}

		public static bool ToBool(string[] values, int[] indexes, int index)
		{
			return default(bool);
		}

		public static T ToEnum<T>(string[] values, int[] indexes, int index) where T : struct
		{
			return (T)null;
		}

		public static int[] ToIntArray(string[] values, int[] indexes, int index)
		{
			return null;
		}

		public static float[] ToFloatArray(string[] values, int[] indexes, int index)
		{
			return null;
		}

		public static string[] ToStringArray(string[] values, int[] indexes, int index)
		{
			return null;
		}

		public static bool[] ToBoolArray(string[] values, int[] indexes, int index)
		{
			return null;
		}

		public static T[] ToEnumArray<T>(string[] values, int[] indexes, int index) where T : struct
		{
			return null;
		}
	}
}
