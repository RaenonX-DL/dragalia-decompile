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
	public class BattleRoyalCharaSkinPickupPopup : CommonPopup
	{
		// Fields
		public GameObject originCell;
		public Transform cellParentTransform;
		private List<BattleRoyalCharaSkinPickupListCell> listCells;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public BattleRoyalReleaseCharaSkinConfirmPopup popup;
			public int charaSkinId;
			public BattleRoyalCharaSkinPickupPopup __4__this;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _ShowReleaseCharaSkinPopup_b__0();
			internal void _ShowReleaseCharaSkinPopup_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public BattleRoyalReleaseCharaSkinResultPopup popup;
			public BattleRoyalCharaSkinPickupPopup __4__this;
			public int charaSkinId;
			public Predicate<BattleRoyalCharaSkinPickupListCell> __9__1;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _ShowSkinReleaseResultPopup_b__0();
			internal bool _ShowSkinReleaseResultPopup_b__1(BattleRoyalCharaSkinPickupListCell cell);
		}
	
		// Constructors
		public BattleRoyalCharaSkinPickupPopup();
	
		// Methods
		public static BattleRoyalCharaSkinPickupPopup Create();
		public void InitPopup(int[] charaSkinIds);
		private void GoSummonScene();
		private void ShowReleaseCharaSkinPopup(int charaSkinId);
		private void ShowSkinReleaseResultPopup(int charaSkinId);
	}
}
