/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class VocalTrackController
	{
		// Fields
		private static readonly Dictionary<VocalTrack, string> _vocalAisacControlDict;
		private static VocalTrack _vocalType;
		private static Tweener _tweener;
	
		// Nested types
		private class VocalTrackCompare : IEqualityComparer<VocalTrack>
		{
			// Constructors
			public VocalTrackCompare();
	
			// Methods
			public bool Equals(VocalTrack track1, VocalTrack track2);
			public int GetHashCode(VocalTrack track);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public string fadeInAisacControl;
			public string fadeOutAisacControl;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _SetVocalType_b__0(float value);
		}
	
		// Constructors
		static VocalTrackController();
	
		// Methods
		public static void Initialize();
		public static VocalTrack GetVocalType();
		public static void SetVocalType(VocalTrack vocalType);
		private static void OnComplete();
	}
}
