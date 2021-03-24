/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventTopPageBattleRoyal : EventTopPageBase
	{
		// Fields
		[Header]
		[SerializeField]
		protected Button enterBattleButton;
		[SerializeField]
		protected Button selectSkinButton;
		[SerializeField]
		protected Button recordButton;
		[SerializeField]
		protected Button pickupButton;
		[Header]
		[SerializeField]
		protected GameObject lockButton;
		[SerializeField]
		protected Color disabledColor;
		private bool isAvailable;
		private DateTime startDT;
		private DateTime endDT;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public List<GameObject> ignoreSetColorChildren;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _Start_b__0(Transform x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public BattleRoyalCharaSkinPickupPopup popup;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _OnPickupButtonPressed_b__0();
		}
	
		// Constructors
		public EventTopPageBattleRoyal();
	
		// Methods
		protected override void SetDurationText();
		protected override void Start();
		public void OnLockButtonPressed();
		public void OnEnterBattleButtonPressed();
		public void OnSelectSkinButtonPressed();
		public void OnRecordButtonPressed();
		public void OnPickupButtonPressed();
		private int[] GetSpecialSkillPickupCharaSkinIds();
		[CompilerGenerated]
		private void _OnEnterBattleButtonPressed_b__12_0();
		[CompilerGenerated]
		private void _OnRecordButtonPressed_b__14_0();
	}
}
