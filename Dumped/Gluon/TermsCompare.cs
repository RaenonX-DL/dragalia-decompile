using System;

namespace Gluon
{
	public static class TermsCompare
	{
		public enum eCompare
		{
			largeEqual,
			smallEqual,
			repudiation,
			equal,
			large,
			small,
			none
		}

		private static string[] _compareTbl;

		public static string CompareStr(eCompare type)
		{
			return null;
		}

		public static string[] TermsSplit(string str)
		{
			return null;
		}

		public static eCompare CompareType(string str)
		{
			return default(eCompare);
		}

		public static bool Compare<T>(eCompare type, T val0, T val1) where T : IComparable<T>
		{
			return default(bool);
		}
	}
}
