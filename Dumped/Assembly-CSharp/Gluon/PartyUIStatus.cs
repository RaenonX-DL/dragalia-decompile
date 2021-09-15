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
	public class PartyUIStatus : MonoBehaviour
	{
		// Fields
		protected const int maxNameFrameStrLength = 10;
		protected const int maxNameFrameEnStrLength = 20;
		public PartyUICanvas canvas;
		public RawImage render3dImage;
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
		public UnityEngine.UI.Text equipEditText;
		public Button emptyFrameButton;
		public UnityEngine.UI.Text SizeControllText;
		public UnityEngine.UI.Text NameText;
		public Image baseImage;
		public Image baseImageEmpty;
		public UnityEngine.UI.Text totalPlusText;
		public GameObject skinIconObj;
		public Image skill3Icon;
		public Image skill4Icon;
		[SerializeField]
		protected GameObject emptyEditSkillBaseObject;
		[SerializeField]
		protected GameObject[] crestEmptyMessageObject;
		[SerializeField]
		private GameObject normalModeParent;
		[SerializeField]
		private GameObject crestMode1Parent;
		[SerializeField]
		private GameObject crestMode2Parent;
		private int _curCharaId;
		public GameObject[] rarityIcons;
		public GameObject[] attributeMatchEffects;
		public bool[] isFinishSettingAttributeMatchEffect;
		private FlRoot[] _attributeMatchEffectsFlRoot;
		public const string attributeMatchEffectPathBase = "Prefabs/OutGame/Party/Flash/pf_AttributeMatchEffect";
	
		// Properties
		protected int curCharaId { get; set; }
	
		// Nested types
		public enum AttributeMatchEffectParentType
		{
			Weapon = 0,
			Dragon = 1,
			Max = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0
		{
			// Fields
			public PartyUIStatus __4__this;
			public CharaDataElement masterCharaData;
	
			// Constructors
			public __c__DisplayClass48_0();
	
			// Methods
			internal void _Reload_b__1(Material dragonIconMaterial);
			internal void _Reload_b__0(Material dragonIconMaterial);
			internal void _Reload_b__4(Material weaponIconMaterial);
			internal void _Reload_b__7(Material weaponIconMaterial);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_1
		{
			// Fields
			public AttributeMatchEffectParentType parentType;
			public __c__DisplayClass48_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass48_1();
	
			// Methods
			internal void _Reload_b__2();
			internal void _Reload_b__3();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_2
		{
			// Fields
			public AttributeMatchEffectParentType parentType;
			public __c__DisplayClass48_0 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass48_2();
	
			// Methods
			internal void _Reload_b__5();
			internal void _Reload_b__6();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass56_0
		{
			// Fields
			public PartyCrestSlockLockedPopup popup;
	
			// Constructors
			public __c__DisplayClass56_0();
	
			// Methods
			internal void _OnLockedSlotPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass66_0
		{
			// Fields
			public Transform parent;
			public PartyUIStatus __4__this;
			public AttributeMatchEffectParentType parentType;
			public bool isStay;
			public bool isSync;
			public UnityAction __9__1;
	
			// Constructors
			public __c__DisplayClass66_0();
	
			// Methods
			internal void _CreateAttributeMatchEffect_b__0(UnityEngine.Object prefab);
			internal void _CreateAttributeMatchEffect_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass68_0
		{
			// Fields
			public PartyUIStatus __4__this;
			public AutoPartyConfigData selectData;
			public UnityAction __9__0;
	
			// Constructors
			public __c__DisplayClass68_0();
	
			// Methods
			internal void _SyncAttributeMatchEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass69_0
		{
			// Fields
			public FlRoot flRoot;
			public PartyUIStatus __4__this;
			public AttributeMatchEffectParentType parentType;
	
			// Constructors
			public __c__DisplayClass69_0();
	
			// Methods
			internal bool _WaitExistFlRootMotion_b__0();
			internal bool _WaitExistFlRootMotion_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _WaitExistFlRootMotion_d__69 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyUIStatus __4__this;
			public AttributeMatchEffectParentType parentType;
			private __c__DisplayClass69_0 __8__1;
			public bool withWaitSetAttributeMatchEffect;
			public UnityAction callback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitExistFlRootMotion_d__69(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public PartyUIStatus();
	
		// Methods
		private void Awake();
		public void ShowNormalUI();
		public void ShowCrestUI(PartyModel.PartySceneUnitStatusMode statusMode);
		public void Reload();
		protected virtual void SetEmptyStatus();
		public virtual void Reload(int charaId, ulong dragonKeyId, ulong weaponBodyId, int type1Crest1Id, int type1Crest2Id, int type1Crest3Id, int type2Crest1Id, int type2Crest2Id, int type3Crest1Id, int type3Crest2Id, int skill3CharaId = 0, int skill4CharaId = 0);
		protected void SetCrestIconState(Image icon, Image plusIcon, Image lockIcon, Button crestButton, int slotIndex, int baseSlotCount, int maxSlotCount, int unlockedSlotCount);
		private void EquipChangeSetting();
		public virtual void OnEquipChangeButtonPressed();
		public void OnStatusPressed();
		public void DragonEquipIconPressed(int tag);
		public void WeaponEquipIconPressed(int tag);
		public void OnCrestIconPressed(int crestIndex);
		public void OnLockedSlotPressed();
		public void Skill3EquipIconPressed();
		public void Skill4EquipIconPressed();
		public void OnShareSkillPopupEnd();
		public void EmptyFramePressed(int tag);
		public void OnDragonIconLongPressed();
		public void OnWeaponIconLongPressed();
		public void OnCrestIconLongPressed(int crestIndex);
		public void OnSkill3IconLongPressed();
		public void OnSkill4IconLongPressed();
		protected void CreateAttributeMatchEffect(ElementalType elementalType, AttributeMatchEffectParentType parentType, bool isSync, bool isStay);
		private void SetAttributeMatchEffect(AttributeMatchEffectParentType parentType);
		public virtual void SyncAttributeMatchEffect(AutoPartyConfigData selectData = null);
		[IteratorStateMachine]
		public IEnumerator WaitExistFlRootMotion(UnityAction callback, AttributeMatchEffectParentType parentType, bool withWaitSetAttributeMatchEffect = false);
		public FlRoot GetAttributeMatchEffectsFlRoot(AttributeMatchEffectParentType parentType);
		protected void DestroyAttributeMatchEffect(AttributeMatchEffectParentType parentType);
		private void OnDestroy();
		public static string GetMotionLabel(AttributeMatchEffectParentType parentType);
		public static string GetAttributePathAdder(ElementalType element);
		public static void CorrectDisplayAttributeMatchEffect(AttributeMatchEffectParentType parentType, int charaId, int parentTargetId, UnityAction createCallback, UnityAction destroyCallback);
		public static bool IsAutoPartySelectTargetAttributeMatchEffect(AutoPartyConfigData selectData, AttributeMatchEffectParentType parentType);
	}
}
