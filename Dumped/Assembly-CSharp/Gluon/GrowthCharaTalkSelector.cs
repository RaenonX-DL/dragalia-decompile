/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthCharaTalkSelector : OutGameTopCharaTalkSelector
	{
		// Fields
		public GrowthScene.CharaType charaType;
		public static Queue<int> myLastPlayedQueue;
	
		// Constructors
		public GrowthCharaTalkSelector();
		static GrowthCharaTalkSelector();
	
		// Methods
		public static void ClearLastPlayedQueue();
		public void Init(GrowthScene.CharaType charaType);
	}
}
