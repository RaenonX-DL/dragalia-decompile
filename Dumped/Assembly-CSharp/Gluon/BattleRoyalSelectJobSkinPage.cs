/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BattleRoyalSelectJobSkinPage : EventQuestPageBase
	{
		// Fields
		public RectTransform layoutParent;
		public BattleRoyalJobCell templateCell;
		private Dictionary<WeaponType, BattleRoyalJobCell> cellList;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<WeaponType, bool> __9__3_0;
			public static Action<bool> __9__5_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _OnPageBecomeActive_b__3_0(WeaponType x);
			internal void _OnDecided_b__5_0(bool v);
		}
	
		// Constructors
		public BattleRoyalSelectJobSkinPage();
	
		// Methods
		public override void OnPageBecomeActive(object data);
		public override void OnPageEnterAnimationEnded();
		private void OnDecided(WeaponType wt, bool isValid);
		private void OnBackButtonTouched();
	}
}
