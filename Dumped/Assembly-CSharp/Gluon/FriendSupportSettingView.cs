/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FriendSupportSettingView : FriendPanelBase
	{
		// Fields
		private static Action onHttpDone;
		public GameObject[] attributeMatchEffects;
		private bool[] isFinishSettingAttributeMatchEffect;
		private FlRoot[] _attributeMatchEffectsFlRoot;
		[SerializeField]
		private FriendSupportListBase listBase;
		[SerializeField]
		private FriendSupportListController listController;
		[Header]
		[SerializeField]
		private CommonUnitIcon charaIcon;
		[SerializeField]
		private CommonIconListSortDeco sortDeco;
		[SerializeField]
		private CommonIcon skillIcon;
		[SerializeField]
		private CommonIcon dragonIcon;
		[SerializeField]
		private GameObject noDragonIcon;
		[SerializeField]
		private CommonIcon weaponIcon;
		[SerializeField]
		private CommonIcon[] amuletIcon;
		[SerializeField]
		private GameObject[] noAmuletMark;
		[SerializeField]
		private GameObject[] amuletLockIcon;
		[SerializeField]
		private Material blankMaterial;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text characterNameText;
		[SerializeField]
		private UnityEngine.UI.Text skillDescText;
		[SerializeField]
		private TabBase typeTab;
		[SerializeField]
		private GameObject listButtonObj;
		[SerializeField]
		private UnityEngine.UI.Text totalPlusText;
		[SerializeField]
		private PartyEquipCrestList crestList;
		[SerializeField]
		private GameObject weaponAndDragonListGameObject;
		private Type currentType;
		private int prevCharaId;
		private const float descTextBaseWidthSize = 346f;
		private const float adjustAttributeMatchEffectScale = 0.86206895f;
	
		// Properties
		public Type GetCurrentType { get; }
	
		// Nested types
		public enum Type
		{
			None = -1,
			Character = 0,
			Dragon = 1,
			Weapon = 2,
			Amulet1 = 3,
			Amulet2 = 4,
			Amulet3 = 5,
			Amulet4 = 6,
			Amulet5 = 7,
			Amulet6 = 8,
			Amulet7 = 9,
			Max = 10
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass32_0
		{
			// Fields
			public string tabName;
			public Footer.MenuTab tabType;
	
			// Constructors
			public __c__DisplayClass32_0();
	
			// Methods
			internal void _OnFooterButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _LoadBaseListData_d__34 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FriendSupportSettingView __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadBaseListData_d__34(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ReloadParam_d__35 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FriendSupportSettingView __4__this;
			public bool isFirstSetup;
			private int _charaId_5__2;
			private CharaDataElement _masterCharaData_5__3;
			private int _totalPlus_5__4;
			private int _totalMaxPlus_5__5;
			private bool _isAllEquip_5__6;
			private CharaDataElement _charaMasterData_5__7;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ReloadParam_d__35(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass44_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass44_0();
	
			// Methods
			internal void _OnIconButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0
		{
			// Fields
			public CommonIconListCellData data;
			public FriendSupportSettingView __4__this;
	
			// Constructors
			public __c__DisplayClass47_0();
	
			// Methods
			internal void _IconButtonLongPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass52_0
		{
			// Fields
			public FriendSupportSettingView __4__this;
			public PartyUIStatus.AttributeMatchEffectParentType parentType;
			public bool isSync;
	
			// Constructors
			public __c__DisplayClass52_0();
	
			// Methods
			internal void _CreateAttributeMatchEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass55_0
		{
			// Fields
			public FlRoot flRoot;
			public FriendSupportSettingView __4__this;
			public PartyUIStatus.AttributeMatchEffectParentType parentType;
	
			// Constructors
			public __c__DisplayClass55_0();
	
			// Methods
			internal bool _WaitExistFlRootMotion_b__0();
			internal bool _WaitExistFlRootMotion_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _WaitExistFlRootMotion_d__55 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FriendSupportSettingView __4__this;
			public PartyUIStatus.AttributeMatchEffectParentType parentType;
			private __c__DisplayClass55_0 __8__1;
			public bool withWaitSetAttributeMatchEffect;
			public UnityAction callback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitExistFlRootMotion_d__55(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass59_0
		{
			// Fields
			public FriendSupportSettingView __4__this;
			public CharaDataElement masterCharaData;
			public PartyUIStatus.AttributeMatchEffectParentType parentType;
			public bool isSync;
	
			// Constructors
			public __c__DisplayClass59_0();
	
			// Methods
			internal void _CorrectDisplayAttributeMatchEffectForKeyId_b__0();
			internal void _CorrectDisplayAttributeMatchEffectForKeyId_b__1();
			internal void _CorrectDisplayAttributeMatchEffectForKeyId_b__2();
			internal void _CorrectDisplayAttributeMatchEffectForKeyId_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public PartyCrestSlockLockedPopup popup;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal void _OnLockedSlotPressed_b__0();
		}
	
		// Constructors
		public FriendSupportSettingView();
	
		// Methods
		public static FriendSupportSettingView Create(Transform parent, FriendScene scene);
		private void Start();
		private void OnFooterButtonPressed(string tabName, Footer.MenuTab tabType);
		private void ChangeSceneCallback(UnityAction changeScene);
		[IteratorStateMachine]
		private IEnumerator LoadBaseListData();
		[IteratorStateMachine]
		public IEnumerator ReloadParam(bool isFirstSetup = false);
		private void SetAmulet(int amuletNum, Type type, int slotNum, int slotCount, int maxSlotCount, ref int totalPlus, ref int totalMaxPlus, ref bool isAllEquip);
		public void OnSettingIconPressed(int typeIndex);
		public void OnSettingIconLongPressed(int typeIndex);
		public void LoadListData();
		private void OnSelectedTypeTab(int typeIndex);
		public void OnSortButtonClicked();
		public void OnSortApplied();
		private ulong[] CreateDataIdList(out GiftType giftType);
		private void OnIconButtonPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void OnOutButtonLongPressed();
		private void IconButtonLongPressed(CommonIconListCellData data, TableViewCell<CommonIconListCellData> cell);
		private void IconButtonLongPressed(CommonIconListCellData data);
		private void OnOutButtonPressed();
		public override void RefreshCurrentPage();
		public static void RequestForEntryHttp(Action onHttpDoneCallback);
		public static void OnEntryHttpSuccess();
		private void CreateAttributeMatchEffect(ElementalType elementalType, PartyUIStatus.AttributeMatchEffectParentType parentType, bool isSync);
		private void SetAttributeMatchEffect(PartyUIStatus.AttributeMatchEffectParentType parentType);
		public void SyncAttributeMatchEffect();
		[IteratorStateMachine]
		public IEnumerator WaitExistFlRootMotion(UnityAction callback, PartyUIStatus.AttributeMatchEffectParentType parentType, bool withWaitSetAttributeMatchEffect = false);
		public FlRoot GetAttributeMatchEffectsFlRoot(PartyUIStatus.AttributeMatchEffectParentType parentType);
		private void DestroyAttributeMatchEffect(PartyUIStatus.AttributeMatchEffectParentType parentType);
		private void OnDestroy();
		private void CorrectDisplayAttributeMatchEffectForKeyId(PartyUIStatus.AttributeMatchEffectParentType parentType, int charaId, ulong keyId, bool isSync);
		public void OnListChangeButtonPressed();
		public void OnLockedSlotPressed();
		[CompilerGenerated]
		private void _OnSelectedTypeTab_b__40_0();
	}
}
