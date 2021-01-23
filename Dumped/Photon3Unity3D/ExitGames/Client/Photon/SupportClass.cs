/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 42: Photon3Unity3D.dll - Assembly: Photon3Unity3D, Version=4.1.1.2, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon
{
	public class SupportClass
	{
		// Fields
		protected internal static IntegerMillisecondsDelegate IntegerMilliseconds;
	
		// Nested types
		public delegate int IntegerMillisecondsDelegate();
	
		public class ThreadSafeRandom
		{
			// Fields
			private static readonly Random _r;
	
			// Constructors
			static ThreadSafeRandom();
	
			// Methods
			public static int Next();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public int millisecondsInterval;
			public Func<bool> myThread;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _CallInBackground_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _.cctor_b__15_0();
		}
	
		// Constructors
		static SupportClass();
	
		// Methods
		public static uint CalculateCrc(byte[] buffer, int length);
		public static int GetTickCount();
		public static void CallInBackground(Func<bool> myThread);
		public static void CallInBackground(Func<bool> myThread, int millisecondsInterval);
		public static void WriteStackTrace(Exception throwable, TextWriter stream);
		public static void WriteStackTrace(Exception throwable);
		public static string DictionaryToString(IDictionary dictionary);
		public static string DictionaryToString(IDictionary dictionary, bool includeTypes);
	}
}
