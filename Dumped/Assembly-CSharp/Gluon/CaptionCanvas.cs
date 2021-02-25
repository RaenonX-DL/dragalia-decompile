/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CaptionCanvas : AnimationUICanvas
	{
		// Fields
		public GameObject[] bg;
		public Image icon;
		public UnityEngine.UI.Text title;
		private ThemeColor currentThemeColor;
	
		// Nested types
		public enum IconType
		{
			Top_Title_Mypage = 0,
			Top_Title_Menu = 1,
			Player_Title_Menu = 2,
			Record_Title_Menu = 3,
			Friend_Title_Menu = 4,
			Profile_Title_Menu = 5,
			Stamp_Title_Menu = 6,
			Result_Title_Menu = 7,
			Main_Title_Friend = 8,
			Search_Title_Friend = 9,
			Request_Title_Friend = 10,
			Consent_Title_Friend = 11,
			Support_Title_Friend = 12,
			Story_Title_Record = 13,
			Unit_Title_Record = 14,
			Enemy_Title_Record = 15,
			Library_Title_Record = 16,
			Quest_Title_Mypage = 17,
			Multi_Title_Mypage = 18,
			Top_Title_Growth = 19,
			Chara_Title_Growth = 20,
			Mana_Title_Growth = 21,
			Dragon01_Title_Growth = 22,
			Dragon02_Title_Growth = 23,
			Weapon01_Title_Growth = 24,
			Weapon02_Title_Growth = 25,
			Amulet01_Title_Growth = 26,
			Amulet02_Title_Growth = 27,
			Top_Title_Party = 28,
			List_Title_Party = 29,
			Top_Title_Fort = 30,
			Main_Title_Fort = 31,
			Knights_Title_Fort = 32,
			Dragon_Title_Fort = 33,
			Castle_Title_Fort = 34,
			Top_Title_Summon = 35,
			Episode_Title_Summon = 36,
			RollOnly_Title_Summon = 37,
			Roll01_Title_Summon = 38,
			Roll10_Title_Summon = 39,
			Shop_Title_Menu = 40,
			BuyStone_Title_Record = 41,
			BuyItem_Title_Shop = 42,
			ItemTrade_Title_Shop = 43,
			TreasureTrade_Title_Shop = 44,
			MoonTrade_Title_Shop = 45,
			Exchange_Title_Shop = 46,
			UseItem_Title_Shop = 47,
			Emblem_Title_Event = 48,
			MedalReward_Title_Event = 49,
			Exchange_Title_Event = 50,
			LimitedQuest_Title_Shop = 51,
			Summon_Title_Event = 52,
			SummonResult_Title_Event = 53,
			Sizuku_Title_Shop = 54,
			Event_Quest_Title = 55,
			Pack_Title_Shop = 56,
			Pack2_Title_Shop = 57,
			Item1_Title_Shop = 58,
			Item2_Title_Shop = 59,
			Item3_Title_Shop = 60,
			Item4_Title_Shop = 61,
			Trade_Title_Shop = 62,
			Craft_Title_Growth = 63,
			Amulet_Title_Shop = 64,
			MissionDrill_Title = 65
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public AnimationUICaption animation;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal bool _SetTypeCoroutine_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _SetTypeCoroutine_d__6 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CaptionCanvas __4__this;
			private __c__DisplayClass6_0 __8__1;
			public string titleText;
			public ThemeColor themeColor;
			public IconType iconType;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetTypeCoroutine_d__6(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CaptionCanvas();
	
		// Methods
		public void SetContent(string titleText, ThemeColor themeColor, IconType iconType);
		[IteratorStateMachine]
		private IEnumerator SetTypeCoroutine(string titleText, ThemeColor themeColor, IconType iconType);
		private void SetTypeImpl(string titleText, ThemeColor themeColor, IconType iconType);
		public void SlideOut(Action onDone = null);
		public bool IsSameTitle(string titleText, ThemeColor themeColor);
	}
}
