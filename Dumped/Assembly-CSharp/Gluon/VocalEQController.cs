/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class VocalEQController
	{
		// Fields
		private static float ThresholdVolume;
		private static bool _isOnVocalEQ;
		private static Tweener _tweener;
	
		// Constructors
		static VocalEQController();
	
		// Methods
		public static void Update();
		private static void OnComplete();
		private static void ToOffVocalEQ(float controlValue);
	}
}
