/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ConeshellInitializer
	{
		// Fields
		private static bool encryptFuncInitialized;
		private static string baasId;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<byte[], byte[]> __9__2_0;
			public static Func<byte[], byte[]> __9__2_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal byte[] _InitializeConeshell_b__2_0(byte[] data);
			internal byte[] _InitializeConeshell_b__2_1(byte[] data);
		}
	
		// Constructors
		public ConeshellInitializer();
		static ConeshellInitializer();
	
		// Methods
		public static void InitializeConeshell(string udid);
	}
}
