/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonOddsPopup : CommonPopup
	{
		// Fields
		[Header]
		[SerializeField]
		public TabBase tabController;
		public TabBase tabControllerWithPrize;
		[Header]
		[SerializeField]
		public Transform normalTableViewParent;
		public Transform guaranteedTableViewParent;
		public Transform prizeTableViewParent;
		[Header]
		[SerializeField]
		public CanvasGroup contentAlphaGroup;
		[Header]
		[SerializeField]
		public GameObject tabParent;
		public RectTransform contentRect;
		private const float singleViewContentRectTop = -2f;
		private List<SummonOddsTableViewData> sortedNormalData;
		private List<SummonOddsTableViewData> sortedGuaranteedData;
		private List<SummonPrizeOddsTableViewData> sortedPrizeData;
		private OddsRateList oddsData;
		private SummonPrizeOddsRateList prizeData;
		private RedoableSummonOddsRateList redoableSummonoddsData;
		private SummonOddsTableViewController normalTableView;
		private SummonOddsTableViewController guaranteedTableView;
		private SummonPrizeOddsTableViewController prizeTableView;
		private const float listSpaceOffset = 16f;
		private bool isTutorialSummon;
		private SummonType summonType;
		private bool isExcludeSelected;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _LateSetLayout_d__28 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SummonOddsPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LateSetLayout_d__28(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<SummonOddsTableViewData, ElementalType> __9__34_0;
			public static Func<SummonOddsTableViewData, WeaponType> __9__34_1;
			public static Func<SummonOddsTableViewData, int> __9__34_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal ElementalType _SetupBunch_b__34_0(SummonOddsTableViewData p);
			internal WeaponType _SetupBunch_b__34_1(SummonOddsTableViewData p);
			internal int _SetupBunch_b__34_2(SummonOddsTableViewData p);
		}
	
		// Constructors
		public SummonOddsPopup();
	
		// Methods
		public static SummonOddsPopup Create(Canvas uiCanvas, OddsRateList oddsData, SummonType summonType);
		public static SummonOddsPopup Create(Canvas uiCanvas, RedoableSummonOddsRateList oddsData, SummonType summonType);
		public static SummonOddsPopup CreateWithPrize(Canvas uiCanvas, OddsRateList oddsData, SummonPrizeOddsRateList prizeData, SummonType summonType, bool isExcludeSelected = false);
		protected override void Start();
		private void InitTableViews();
		private void InitTableViewWithPrize();
		[IteratorStateMachine]
		private IEnumerator LateSetLayout();
		private void SetupByOddsData(OddsRateList oddsData, SummonType summonType);
		private void SetupByOddsData(OddsRateList oddsData, SummonPrizeOddsRateList prizeData, SummonType summonType);
		private void SetupByOddsData(RedoableSummonOddsRateList oddsData, SummonType summonType);
		private void SetupByItemData(OddsRate oddsData, bool isNormal);
		private void SetupByPrizeData(SummonPrizeOddsRateList prizeData);
		private void SetupBunch(OddsUnitDetail[] odds, Rarity rarity, bool isNormal, string countTemplate, GiftType giftType);
		public void OnCloseButtonClicked();
		public void ClosePopup();
		[CompilerGenerated]
		private void _ClosePopup_b__36_0();
	}
}
