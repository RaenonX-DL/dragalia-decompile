/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttLayer
	{
		// Nested types
		public enum Type
		{
			Default = -1,
			Common0 = 0,
			Common1 = 1,
			Common2 = 2
		}
	
		// Constructors
		public CuttLayer();
	
		// Methods
		public static int GetLayer(Type type);
		public static void SetLayer(GameObject obj, Type type);
		public static void SetLayer(GameObject obj, int layer);
	}
}
