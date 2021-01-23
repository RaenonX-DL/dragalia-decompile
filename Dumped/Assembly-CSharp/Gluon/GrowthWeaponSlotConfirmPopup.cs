/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponSlotConfirmPopup : CommonPopup, ICustomMessage
	{
		// Fields
		public GameObject originCell;
		public Transform cellParentTransform;
		public UnityEngine.UI.Text needRupiText;
		public UnityEngine.UI.Text beforeRupiText;
		public UnityEngine.UI.Text afterRupiText;
		public Image[] slotIconsTypeA;
		public Image[] slotIconsTypeB;
		public GameObject[] selectImages;
		public GameObject[] blackMaskImages;
		public GameObject needMaterialTextObject;
		public Action reloadCanvasUICallBack;
		[CompilerGenerated]
		private int _slotType1SelectCount_k__BackingField;
		[CompilerGenerated]
		private int _slotType2SelectCount_k__BackingField;
		private GrowthUnitEnhanceModel model;
		private List<CraftMaterialCell> materialCells;
		private List<SlotData> slotDataList;
		private List<int> selectSlotIndexList;
		private GameObject[] releasableEffectObjects;
		private bool isDesabledReleaseButton;
		private bool existsReleasableSlot;
		private bool isMaterialComplete;
		private bool isShortageRupi;
		private int totalNeedRupi;
	
		// Properties
		public int slotType1SelectCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int slotType2SelectCount { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		private class SlotData
		{
			// Fields
			public BuildupPieceType pieceType;
			public bool isReleased;
			public bool canRelease;
			public BuildupPieceType conditionPieceType;
			public int conditionParam;
			public int slotIndex;
	
			// Constructors
			public SlotData();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _ShowConditionPopup_b__0();
		}
	
		// Constructors
		public GrowthWeaponSlotConfirmPopup();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		public static GrowthWeaponSlotConfirmPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model);
		public void OnSlotIconPressed(int slotIconIndex);
		private void SetupRupi();
		private void SetupMaterialCell();
		private void CreateSlotDataList();
		private void SetupSlot();
		private void UpdateSlotIcon();
		private void UpdateMaterialCell();
		private void UpdateOkButtonState();
		private void ShowConditionPopup(int dataIndex);
		private void PlayReleasablePieceEffect(int index, Transform effectParentTransform);
		private void DestroyReleasablePieceEffect(int index);
		private Image GetSlotIconImage(SlotData slotData);
		private void OnMaterialIconPressed(CraftMaterialCellData cellData);
		public void OnMessagReceived(CustomMessageType messageType, object data);
	}
}
