/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftGradeupCanvas : MonoBehaviour, ICustomMessage
	{
		// Fields
		public CraftEvolutionBaseFrame gradeupTargetInfoFrame;
		public Transform craftMaterialCellParent;
		public UnityEngine.UI.Text totalCoin;
		public UnityEngine.UI.Text breforeCoin;
		public UnityEngine.UI.Text afterCoin;
		public UnityAction craftButtonPressCallBack;
		public GameObject effectBaseObject;
		public Button craftButton;
		public UnityEngine.UI.Text fortErrorMessage;
		public List<CraftMaterialCellData> materialCellDataList;
		public Sprite craftNormalSprite;
		public Sprite craftBlueSprite;
		public RectTransform gradeupResultButtonsRect;
		public Button toPowerUpButtonForGradeupResult;
		public UnityEngine.UI.Text toPowerTextForGradeupResult;
		public Button closeButtonForGradeupResult;
		public UnityEngine.UI.Text closeTextForGradeupResult;
		private Vector2 gradeupResultButtonsTargetPos;
		private Tweener gradeupResultButtonsTween;
		private List<CraftMaterialCell> materialCellList;
		private bool isWeaponGradeup;
		private bool isClearPreconditionForGradeup;
		private BitArray gradeupConditionArray;
		private long shortageCoin;
		private int needCraftLevel;
		[SerializeField]
		private UnityEngine.UI.Text needCoinText;
		[SerializeField]
		private UnityEngine.UI.Text needMaterialText;
		private WeaponCraftDataElement craftData;
	
		// Nested types
		private enum GradeupConditionError
		{
			None = -1,
			LowCraftLevel = 0,
			NoMaxLimitBreak = 1,
			NoMaxLevel = 2,
			ShortageCoin = 3,
			ShortageMaterial = 4,
			NotBaseWeapon = 5
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0
		{
			// Fields
			public CommonPopup pop;
	
			// Constructors
			public __c__DisplayClass35_0();
	
			// Methods
			internal void _ShowConditionPop_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0
		{
			// Fields
			public CraftMaterialCellData cellData;
			public CraftGradeupCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass36_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_1
		{
			// Fields
			public CraftMaterialWeaponSelectPopup popup;
			public __c__DisplayClass36_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass36_1();
	
			// Methods
			internal void _OnMaterialIconPressed_b__0();
			internal void _OnMaterialIconPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public CraftGradeupCanvas __4__this;
			public UnityAction listCloseAction;
	
			// Constructors
			public __c__DisplayClass37_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_1
		{
			// Fields
			public SelectGradeupMaterialConfirmPopup popup;
			public __c__DisplayClass37_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass37_1();
	
			// Methods
			internal void _SelectListCallBack_b__0();
			internal void _SelectListCallBack_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public CraftGradeupCanvas __4__this;
			public CanvasGroup group;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _ShowGradeupResultButtons_b__0(float value);
			internal void _ShowGradeupResultButtons_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0
		{
			// Fields
			public CraftGradeupCanvas __4__this;
			public CanvasGroup group;
	
			// Constructors
			public __c__DisplayClass42_0();
	
			// Methods
			internal void _HideGradeupResultButtons_b__0(float value);
			internal void _HideGradeupResultButtons_b__1();
		}
	
		// Constructors
		public CraftGradeupCanvas();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		private void Start();
		public void SetupMaterialCellList(WeaponCraftDataElement craftData);
		private void UpdateMaterialCellList();
		public void OnCraftButtonPressed();
		private void ShowConditionPop();
		private void OnMaterialIconPressed(CraftMaterialCellData cellData);
		private void SelectListCallBack(UnityAction listCloseAction);
		public void UpdateView(WeaponCraftDataElement craftData = null);
		public void UpdateCellData();
		private void UpdateCraftButton();
		public void ShowGradeupResultButtons();
		public void HideGradeupResultButtons();
		private void OnDestroy();
		private void UpdateInfo(WeaponCraftDataElement craftData);
		public void OnMessagReceived(CustomMessageType messageType, object data);
	}
}
