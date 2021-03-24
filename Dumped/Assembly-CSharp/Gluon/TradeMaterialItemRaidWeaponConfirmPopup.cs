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
	public class TradeMaterialItemRaidWeaponConfirmPopup : TradeMaterialItemConfirmPopup
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text hpText;
		public UnityEngine.UI.Text atkText;
		[Header]
		[SerializeField]
		public Sprite[] limitBreakStateSprites;
		public Image[] limitBreakImages;
		[Header]
		[SerializeField]
		public Image[] skillAbilityIcons;
		public UnityEngine.UI.Text[] skillAbilityNames;
		public GameObject[] skillAbilitySingleLines;
		private List<Action> onIconTouchedCallbacks;
	
		// Nested types
		public enum LimitBreakSpriteIndex
		{
			Off = 0,
			On = 1,
			Max = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public UnitDetailModel model;
	
			// Constructors
			public __c__DisplayClass12_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_1
		{
			// Fields
			public UnitDetailModel.DetailDataBase.SkillAbilityInfo skill;
	
			// Constructors
			public __c__DisplayClass12_1();
	
			// Methods
			internal void _Start_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_2
		{
			// Fields
			public UnitDetailModel.DetailDataBase.SkillAbilityInfo ability;
			public __c__DisplayClass12_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass12_2();
	
			// Methods
			internal void _Start_b__1();
		}
	
		// Constructors
		public TradeMaterialItemRaidWeaponConfirmPopup();
	
		// Methods
		public void OnSkillAbilityPressed(int i);
		public void OnTradeButtonPressed();
		protected override void OnTradeDone();
		protected override void Start();
		[CompilerGenerated]
		private void _OnTradeButtonPressed_b__10_0();
		[CompilerGenerated]
		private void _OnTradeDone_b__11_0();
	}
}
