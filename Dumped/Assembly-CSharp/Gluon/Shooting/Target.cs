/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class Target
	{
		// Fields
		public const int TARGETMAX = 64;
		public static Info[] tar;
	
		// Nested types
		public class Info
		{
			// Fields
			public float x;
			public float y;
	
			// Constructors
			public Info();
		}
	
		// Constructors
		public Target();
		static Target();
	
		// Methods
		public static void SetValue(int index, float x, float y);
		public static void ClearAll();
	}
}
