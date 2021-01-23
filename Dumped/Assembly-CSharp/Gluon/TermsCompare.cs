/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class TermsCompare
	{
		// Fields
		private static string[] _compareTbl;
	
		// Nested types
		public enum eCompare
		{
			largeEqual = 0,
			smallEqual = 1,
			repudiation = 2,
			equal = 3,
			large = 4,
			small = 5,
			none = 6
		}
	
		// Constructors
		static TermsCompare();
	
		// Methods
		public static string CompareStr(eCompare type);
		public static string[] TermsSplit(string str);
		public static eCompare CompareType(string str);
		public static bool Compare<T>(eCompare type, T val0, T val1)
			where T : IComparable<T>;
	}
}
