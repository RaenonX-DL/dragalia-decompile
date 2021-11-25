using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponSlotConfirmPopup : CommonPopup, ICustomMessage
	{
		private class SlotData
		{
			public BuildupPieceType pieceType;

			public bool isReleased;

			public bool canRelease;

			public BuildupPieceType conditionPieceType;

			public int conditionParam;

			public int slotIndex;
		}

		public GameObject originCell;

		public Transform cellParentTransform;

		public Text needRupiText;

		public Text beforeRupiText;

		public Text afterRupiText;

		public Image[] slotIconsTypeA;

		public Image[] slotIconsTypeB;

		public Image[] slotIconsTypeC;

		public GameObject[] selectImages;

		public GameObject[] blackMaskImages;

		public GameObject needMaterialTextObject;

		public Action reloadCanvasUICallBack;

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

		public int slotType1SelectCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int slotType2SelectCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int slotType3SelectCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public static GrowthWeaponSlotConfirmPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model)
		{
		}

		public void OnSlotIconPressed(int slotIconIndex)
		{
		}

		private void SetupRupi()
		{
		}

		private void SetupMaterialCell()
		{
		}

		private void CreateSlotDataList()
		{
		}

		private void SetupSlot()
		{
		}

		private void UpdateSlotIcon()
		{
		}

		private void UpdateMaterialCell()
		{
		}

		private void UpdateOkButtonState()
		{
		}

		private void ShowConditionPopup(int dataIndex)
		{
		}

		private void PlayReleasablePieceEffect(int index, Transform effectParentTransform)
		{
		}

		private void DestroyReleasablePieceEffect(int index)
		{
		}

		private Image GetSlotIconImage(SlotData slotData)
		{
			return null;
		}

		private void OnMaterialIconPressed(CraftMaterialCellData cellData)
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
