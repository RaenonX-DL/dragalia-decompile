/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultPlayerLevelUpPage : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text uiBeforeLevelText;
		public UnityEngine.UI.Text uiAfterLevelText;
		[SerializeField]
		private GameObject textPanel;
		[Header]
		[SerializeField]
		public Button nextButton;
		public UnityEngine.UI.Text nextButtonText;
		[Header]
		[SerializeField]
		public Transform lowerPanel;
		public Transform nextButtonPanel;
		[Header]
		[SerializeField]
		private RectTransform wholeFrameRectTrans;
		[SerializeField]
		private float wholeFrameVerticalSpacing;
		[SerializeField]
		private float wholeFrameHeightMax;
		[SerializeField]
		private RectTransform viewFrameRectTrans;
		[SerializeField]
		private float viewFrameHeightMax;
		[SerializeField]
		private int maxRowCount;
		[SerializeField]
		private GameObject[] validViewObjs;
		[HideInInspector]
		public Action onCloseDone;
		[SerializeField]
		private Canvas levelUpCanvasObj;
		[SerializeField]
		private GameObject flashCanvasObj;
		private GridLayoutGroup gridLayoutGroup;
		[CompilerGenerated]
		private QuestResultScene _sceneObj_k__BackingField;
		[SerializeField]
		private Canvas questResultPlayerLevelUpTopCanvas;
		[SerializeField]
		private GameObject fortObject;
		[SerializeField]
		private QuestResultRankUpRewardController fortTableViewCrl;
		[SerializeField]
		private GameObject friendObject;
		[SerializeField]
		private UnityEngine.UI.Text beforeFriendText;
		[SerializeField]
		private UnityEngine.UI.Text afterFriendText;
		[SerializeField]
		private GameObject staminaObject;
		[SerializeField]
		private UnityEngine.UI.Text beforeStaminaText;
		[SerializeField]
		private UnityEngine.UI.Text afterStaminaText;
		[SerializeField]
		private GameObject upperBonusObject;
		[SerializeField]
		private Transform commonIconTrans;
		[SerializeField]
		private RectTransform popupBackGroundTrans;
		private UnityEvent backKeyEvent;
		private const int popupHeightL = 808;
		private const int popupHeightM = 400;
		private const int popupHeightS = 270;
		private const string seLvUpSlideOut = "SE_OUT_COMMON_0035";
		private RankUpType rankUpType;
		private FlashPlayer flashPlayer;
	
		// Properties
		public QuestResultScene sceneObj { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		private enum RankUpType
		{
			RankUpOnly = 0,
			Upper = 1,
			Fort = 2
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static UnityAction __9__42_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _InitByData_b__42_1();
		}
	
		// Constructors
		public QuestResultPlayerLevelUpPage();
	
		// Methods
		public static QuestResultPlayerLevelUpPage Create(Transform parent, Action onCloseDone);
		public void InitByData(int toLevel);
		private void Awake();
		public void OnCloseButtonClicked();
		private void DoRankupPanelAnimation();
		public void PlayLevelUpPanelAnimation(int toLevel);
		private void OnFadeInAnimation();
		private void OnFadeOutAnimation();
		private void ViewSizeAdjust();
		[CompilerGenerated]
		private void _InitByData_b__42_0();
		[CompilerGenerated]
		private void _DoRankupPanelAnimation_b__46_0();
		[CompilerGenerated]
		private void _OnFadeOutAnimation_b__49_0();
	}
}
