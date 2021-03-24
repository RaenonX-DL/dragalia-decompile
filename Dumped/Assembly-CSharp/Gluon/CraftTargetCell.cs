/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftTargetCell : TableViewCell<Gluon.CraftTargetSelectCellData>
	{
		// Fields
		public Image newIcon;
		public Image weaponIcon;
		public Image eventIcon;
		public Image skillIcon;
		public Image[] abilityIcons;
		public Image craftButtonImage;
		public Image specialCraftButtonImage;
		public Image treeButtonImage;
		public UnityEngine.UI.Text weaponName;
		public UnityEngine.UI.Text needLevelText;
		public UnityEngine.UI.Text needLevelTextOnBlink;
		public UnityEngine.UI.Text possessionCount;
		public UnityEngine.UI.Text hpParam;
		public UnityEngine.UI.Text atkParam;
		public Sprite craftButtonSprite;
		public Sprite emptyMaterialSprite;
		public UnityAction<int> craftCallBack;
		public UnityAction<int> treeCallBack;
		public UnityEngine.UI.Text craftButtonText;
		public UnityEngine.UI.Text specialCraftButtonText;
		public UnityEngine.UI.Text treeButtonText;
		public CanvasGroup skillAbilityRootGroup;
		public GameObject skillBase;
		public GameObject abilityBase;
		public GameObject needLevelTextBase;
		public UnityEngine.UI.Text hpParamText;
		public UnityEngine.UI.Text atkParamText;
		public UnityEngine.UI.Text plusParam;
		public GameObject sortDecoAttachNode;
		public CraftTargetSelectListController listController;
		public Animator blinkAnimator;
		public CanvasGroup skillAbilityInfoBaseGroup;
		public CanvasGroup needLevelTextGroupOnBlink;
		public Transform skillAbilityInfoBaseParent;
		public Transform skillAbilityInfoBaseParentOnBlink;
		[SerializeField]
		private Transform craftBaseTransform;
		[SerializeField]
		private Transform rootBaseTransform;
		[SerializeField]
		private Image[] abilityIcon;
		[SerializeField]
		private UnityEngine.UI.Text[] abilityName;
		[SerializeField]
		private GameObject[] abilityTextBase;
		[SerializeField]
		private Image[] elementIcon;
		[SerializeField]
		private Toggle[] elementToggles;
		private int[] rootIds;
		[SerializeField]
		private UnityEngine.UI.Text seriesLabel;
		[SerializeField]
		private GameObject labelBaseObj;
		[SerializeField]
		private GameObject infoBaseObj;
		[SerializeField]
		private Image voidWeaponEnemyIcon;
		[SerializeField]
		private Image hgCraftBgImage;
		[SerializeField]
		private UnityEngine.UI.Text hgCraftName;
		[SerializeField]
		private UnityEngine.UI.Text hgCraftPosCount;
		[SerializeField]
		private UnityEngine.UI.Text hgCraftNeedWeaponText;
		private int targetId;
		private int skillLv;
		private WeaponDataElement weaponData;
		private int statusHpPlusCount;
		private int statusAtkPlusCount;
		private RectTransform[] skillRects;
		private RectTransform[] abilityRects;
		private CraftTargetSelectCellData targetData;
	
		// Nested types
		[CompilerGenerated]
		private sealed class _WaitMoment_d__71 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public UnityAction callback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitMoment_d__71(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CraftTargetCell();
	
		// Methods
		protected override void Awake();
		public override void UpdateContent(CraftTargetSelectCellData data);
		private void SetupSpecialCraftInfo(CraftTargetSelectCellData data);
		private void SetupCraftInfo(CraftTargetSelectCellData data);
		private void SetupRootInfo(CraftTargetSelectCellData data);
		private void SetupRootInfoCellUI(int weaponId);
		public void OnCraftButtonPressed();
		public void OnTreeButtonPressed();
		public void OnIconButtonPressed();
		public void OnSkillButtonPressed();
		public void OnAbilityButtonPressed(int intex);
		private Vector2 GetScaleFromVisible(bool visible);
		[IteratorStateMachine]
		private IEnumerator WaitMoment(UnityAction callback);
		public void OnElementTogglePressed(bool isOn);
		private void UpdateCraftButton(ref Image buttonImage, ref UnityEngine.UI.Text buttonText, bool isCraft);
		[CompilerGenerated]
		private void _SetupCraftInfo_b__62_0();
	}
}
