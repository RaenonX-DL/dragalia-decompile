using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CraftGradeupCanvas : MonoBehaviour, ICustomMessage
	{
		private enum GradeupConditionError
		{
			None = -1,
			LowCraftLevel,
			NoMaxLimitBreak,
			NoMaxLevel,
			ShortageCoin,
			ShortageMaterial,
			NotBaseWeapon
		}

		public CraftEvolutionBaseFrame gradeupTargetInfoFrame;

		public Transform craftMaterialCellParent;

		public Text totalCoin;

		public Text breforeCoin;

		public Text afterCoin;

		public UnityAction craftButtonPressCallBack;

		public GameObject effectBaseObject;

		public Button craftButton;

		public Text fortErrorMessage;

		public List<CraftMaterialCellData> materialCellDataList;

		public Sprite craftNormalSprite;

		public Sprite craftBlueSprite;

		public RectTransform gradeupResultButtonsRect;

		public Button toPowerUpButtonForGradeupResult;

		public Text toPowerTextForGradeupResult;

		public Button closeButtonForGradeupResult;

		public Text closeTextForGradeupResult;

		private Vector2 gradeupResultButtonsTargetPos;

		private Tweener gradeupResultButtonsTween;

		private List<CraftMaterialCell> materialCellList;

		private bool isWeaponGradeup;

		private bool isClearPreconditionForGradeup;

		private BitArray gradeupConditionArray;

		private long shortageCoin;

		private int needCraftLevel;

		[SerializeField]
		private Text needCoinText;

		[SerializeField]
		private Text needMaterialText;

		private WeaponCraftDataElement craftData;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		public void SetupMaterialCellList(WeaponCraftDataElement craftData)
		{
		}

		private void UpdateMaterialCellList()
		{
		}

		public void OnCraftButtonPressed()
		{
		}

		private void ShowConditionPop()
		{
		}

		private void OnMaterialIconPressed(CraftMaterialCellData cellData)
		{
		}

		private void SelectListCallBack(UnityAction listCloseAction)
		{
		}

		public void UpdateView([Optional] WeaponCraftDataElement craftData)
		{
		}

		public void UpdateCellData()
		{
		}

		private void UpdateCraftButton()
		{
		}

		public void ShowGradeupResultButtons()
		{
		}

		public void HideGradeupResultButtons()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateInfo(WeaponCraftDataElement craftData)
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
