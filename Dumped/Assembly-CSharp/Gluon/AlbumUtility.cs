/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumUtility : MonoBehaviour
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass0_0
		{
			// Fields
			public CommonPopup popup;
			public bool isLoading;
			public UnityAction closeCallback;
			public UnityAction __9__2;
	
			// Constructors
			public __c__DisplayClass0_0();
	
			// Methods
			internal void _CreateAlbumBonusPopup_b__0();
			internal void _CreateAlbumBonusPopup_b__2();
			internal void _CreateAlbumBonusPopup_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__0_3;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _CreateAlbumBonusPopup_b__0_3();
		}
	
		// Constructors
		public AlbumUtility();
	
		// Methods
		public static void CreateAlbumBonusPopup(UnityAction closeCallback = null, bool isLoading = false);
		public static bool IsAlbumMedalCondition();
	}
}
