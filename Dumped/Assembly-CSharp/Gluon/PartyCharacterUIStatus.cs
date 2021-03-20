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

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyCharacterUIStatus : MonoBehaviour
	{
		// Fields
		public PartyCharacterUICanvas canvas;
		public int myIndex;
		public CanvasGroup activeCanvasGroup;
		public UnityEngine.UI.Text lvText;
		public Image elementIcon;
		public Image weaponTypeIcon;
		public Image dragonIcon;
		public Image dragonBlankPlusIcon;
		public Image weaponIcon;
		public Image[] crestIcons;
		public Button[] crestIconButtons;
		public Image[] crestBlankPlusIcons;
		public Image[] crestLockIcons;
		public CommonUnionIcon[] crestUnionIcons;
		public Image charaStatusUIBase;
		public GameObject skinIconObj;
		public Image skill3Icon;
		public Image skill4Icon;
		public Image supportSkillIcon;
		public GameObject[] rarityIcons;
		[SerializeField]
		private ThemeColorImageSwitcher statusImageSwithcer;
		[SerializeField]
		private UnityEngine.UI.Text emptyText;
		[SerializeField]
		private Button emptyButton;
		[SerializeField]
		private Image baseImage;
		[SerializeField]
		private Image baseImageEmpty;
		public GameObject emptyEditSkillBaseObject;
		[SerializeField]
		private GameObject disabledImage;
		[SerializeField]
		private GameObject normalModeParent;
		[SerializeField]
		private GameObject crestModeParent;
		[SerializeField]
		private GameObject crestEmptyMessageObject;
		public GameObject[] attributeMatchEffects;
		private bool[] isFinishSettingAttributeMatchEffect;
		private FlRoot[] _attributeMatchEffectsFlRoot;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public PartyCharacterUIStatus __4__this;
			public CharaDataElement masterCharaData;
	
			// Constructors
			public __c__DisplayClass37_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_1
		{
			// Fields
			public PartyUIStatus.AttributeMatchEffectParentType parentType;
			public __c__DisplayClass37_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass37_1();
	
			// Methods
			internal void _Reload_b__0();
			internal void _Reload_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_2
		{
			// Fields
			public PartyUIStatus.AttributeMatchEffectParentType parentType;
			public __c__DisplayClass37_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass37_2();
	
			// Methods
			internal void _Reload_b__2();
			internal void _Reload_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0
		{
			// Fields
			public PartyCrestSlockLockedPopup popup;
	
			// Constructors
			public __c__DisplayClass43_0();
	
			// Methods
			internal void _OnLockedSlotPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass46_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass46_0();
	
			// Methods
			internal void _CreatePartyShareSkillSetNoReaderPopupTitle_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0
		{
			// Fields
			public SkillAbilityDetailPopup popup;
	
			// Constructors
			public __c__DisplayClass47_0();
	
			// Methods
			internal void _OnSupportSkillIconPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public PartyCharacterUIStatus __4__this;
			public PartyUIStatus.AttributeMatchEffectParentType parentType;
			public bool isStay;
			public bool isSync;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal void _CreateAttributeMatchEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public PartyCharacterUIStatus __4__this;
			public AutoPartyConfigData selectData;
			public UnityAction __9__0;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _SyncAttributeMatchEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_0
		{
			// Fields
			public FlRoot flRoot;
			public PartyCharacterUIStatus __4__this;
			public PartyUIStatus.AttributeMatchEffectParentType parentType;
	
			// Constructors
			public __c__DisplayClass57_0();
	
			// Methods
			internal bool _WaitExistFlRootMotion_b__0();
			internal bool _WaitExistFlRootMotion_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _WaitExistFlRootMotion_d__57 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyCharacterUIStatus __4__this;
			public PartyUIStatus.AttributeMatchEffectParentType parentType;
			private __c__DisplayClass57_0 __8__1;
			public bool withWaitSetAttributeMatchEffect;
			public UnityAction callback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitExistFlRootMotion_d__57(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public PartyCharacterUIStatus();
	
		// Methods
		private void Awake();
		public void ShowNormalUI();
		public void ShowCrestUI();
		public void Reload();
		public void Reload(int charaId, ulong dragonKeyId, ulong weaponBodyId, int type1Crest1Id, int type1Crest2Id, int type1Crest3Id, int type2Crest1Id, int type2Crest2Id, int skill3CharaId = 0, int skill4CharaId = 0);
		private void SetCrestIconState(Image icon, Image plusIcon, Image lockIcon, Button crestButton, int slotIndex, int baseSlotCount, int maxSlotCount, int unlockedSlotCount);
		public void OnStatusPressed();
		public void DragonEquipIconPressed(int tag);
		public void WeaponEquipIconPressed(int tag);
		public void OnCrestIconPressed(int index);
		public void OnLockedSlotPressed();
		public void Skill3EquipIconPressed();
		public void Skill4EquipIconPressed();
		private void CreatePartyShareSkillSetNoReaderPopupTitle();
		public void OnSupportSkillIconPressed();
		public void OnDragonIconLongPressed();
		public void OnWeaponIconLongPressed();
		public void OnCrestIconLongPressed(int crestIndex);
		public void OnSkill3IconLongPressed();
		public void OnSkill4IconLongPressed();
		private void SetEquipMode(PartyModel.EquipMode equipMode);
		private void CreateAttributeMatchEffect(ElementalType elementalType, PartyUIStatus.AttributeMatchEffectParentType parentType, bool isSync, bool isStay);
		private void SetAttributeMatchEffect(PartyUIStatus.AttributeMatchEffectParentType parentType);
		public void SyncAttributeMatchEffect(AutoPartyConfigData selectData = null);
		[IteratorStateMachine]
		public IEnumerator WaitExistFlRootMotion(UnityAction callback, PartyUIStatus.AttributeMatchEffectParentType parentType, bool withWaitSetAttributeMatchEffect = false);
		public FlRoot GetAttributeMatchEffectsFlRoot(PartyUIStatus.AttributeMatchEffectParentType parentType);
		private void DestroyAttributeMatchEffect(PartyUIStatus.AttributeMatchEffectParentType parentType);
		private void OnDestroy();
		public void SetCrestIcon(int keyId, int slotIndex, IconLoader.Size iconSize, Image iconImage, Image plusIcon, CommonUnionIcon unionIcon);
		private void OneUnitQuestSetting(bool isOneUnit);
	}
}
