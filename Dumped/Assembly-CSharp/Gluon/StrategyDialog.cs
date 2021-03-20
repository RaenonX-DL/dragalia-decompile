/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StrategyDialog : InGameDialogBase
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform headRt;
		[SerializeField]
		private RectTransform frameRt;
		[SerializeField]
		private RectTransform infoRt;
		[SerializeField]
		private RectTransform infoDetailRt;
		[SerializeField]
		private RectTransform[] infoDetailItemRt;
		[SerializeField]
		private RectTransform missionRt;
		[SerializeField]
		private RectTransform missionDetailRt;
		[SerializeField]
		private RectTransform itemRt;
		[SerializeField]
		private RectTransform itemDetailRt;
		[SerializeField]
		private Image frameImage;
		[SerializeField]
		private Image elementImage;
		[SerializeField]
		private Sprite[] elementSprite;
		[SerializeField]
		private UnityEngine.UI.Text title;
		[SerializeField]
		private RectTransform buttonBaseRt;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text retryButtonText;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text retireButtonText;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text closeButtonText;
		[SerializeField]
		[Tooltip]
		private Button retryButton;
		[SerializeField]
		[Tooltip]
		private Button retireButton;
		[SerializeField]
		[Tooltip]
		private Button closeButton;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text clearText;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text failureText;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text exConditionTitleText;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text exConditionDetailText;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text exCondition2TitleText;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text exCondition2DetailText;
		[SerializeField]
		[Tooltip]
		private RectTransform exCondition2Rt;
		[SerializeField]
		private UnityEngine.UI.Text[] missionText;
		[SerializeField]
		private Image[] missionIcon;
		[SerializeField]
		private Sprite missionIconOn;
		[SerializeField]
		private Sprite missionIconOff;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text manaText;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text coinText;
		[SerializeField]
		private UnityEngine.UI.Text[] itemText;
		[SerializeField]
		private Image[] itemImage;
		[Header]
		[SerializeField]
		private Color32 selectedColor;
		[SerializeField]
		private float continueImpossibleMergin;
		[SerializeField]
		private float gameWallDetailOffsetY;
		[SerializeField]
		private float gameWallInfoDetailItemOffsetY;
		[SerializeField]
		private float gameWallItemOffsetY;
		[SerializeField]
		private float gameBRHeadOffsetY;
		[SerializeField]
		private float gameBRFrameOffsetY;
		[SerializeField]
		private float gameBRFrameOffsetH;
		[SerializeField]
		private float gameBRItemOffsetY;
		[SerializeField]
		private float gameBRButtonOffsetY;
		private Action<StrategyDialog> retryButtonFunction;
		private Action<StrategyDialog> retireButtonFunction;
		private Action<StrategyDialog> closeButtonFunction;
		private RectTransform rootRt;
		private CommonDialog performanceModeDialog;
		private CommonDialog.Param performanceModeDialogParam;
		private Vector3 orgHeadPos;
		private Vector3 orgFramePos;
		private Vector3 orgInfoPos;
		private Vector3 orgInfoDetailPos;
		private Vector3[] orgInfoDetailItemPos;
		private Vector3 orgMissionPos;
		private Vector3 orgMissionDetailPos;
		private Vector3 orgItemPos;
		private Vector3 orgItemDetailPos;
		private Vector3 orgButtonBasePos;
		private Vector3 orgRetryButtonPos;
		private float orgFrameHeight;
		private const int numKind = 2;
		private const int numElement = 6;
		private const int numStrategy = 4;
		private const int numMission = 3;
		private const int numItem = 6;
		private InGameOptionPopup optionPopup;
		private bool isSwap;
	
		// Nested types
		public enum ItemType
		{
			Sack_N = 0,
			Sack_R = 1,
			Weapon_N = 2,
			Weapon_R = 3,
			Amulet_N = 4,
			Amulet_R = 5,
			Max = 6
		}
	
		public enum ExConditionType
		{
			Continue = 0,
			Reborn = 1
		}
	
		public class Param
		{
			// Fields
			public Action<StrategyDialog> retryButtonFunction;
			public Action<StrategyDialog> retireButtonFunction;
			public Action<StrategyDialog> closeButtonFunction;
	
			// Constructors
			public Param();
		}
	
		// Constructors
		public StrategyDialog();
	
		// Methods
		public static StrategyDialog Create(GameObject parent);
		private void Initialize();
		private void LoadEventSackMaterial(int type);
		public void Update();
		public void Open(Param param);
		private void SetupLayout();
		public void Close(bool isPlayCloseSE = false);
		private void UpdateItemCount(ref UnityEngine.UI.Text uiText, int count);
		public void OnRetryButtonPressed();
		public void OnRetireButtonPressed();
		public void OnCloseButtonPressed();
		private void ExecCloseButtonPressed();
		public void OnOptionButtonPressed();
		private void OnClosedButtonPressedFromOptionDialog();
		private void OnClosedButtonPressedFromPerformanceModeDialog(CommonDialog dlg);
		private Sprite GetElementSprite(ElementalType type);
		private bool IsEnablePress();
		private void SetEnableButtons(bool b);
		private string GetExConditionTitle(ExConditionType type);
		public static string GetExConditionDetail(ExConditionType type, bool isStrategy);
		[CompilerGenerated]
		private void _Initialize_b__74_0();
		[CompilerGenerated]
		private void _Open_b__77_0();
		[CompilerGenerated]
		private void _Close_b__79_0();
		[CompilerGenerated]
		private void _OnOptionButtonPressed_b__85_0(InGameOptionPopup optionPopup);
	}
}
