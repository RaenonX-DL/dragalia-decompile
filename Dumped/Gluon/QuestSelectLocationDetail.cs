using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestSelectLocationDetail : QuestSelectPageBase, ICustomMessage
	{
		[SerializeField]
		private int _groupId;

		[SerializeField]
		private int _locationId;

		[SerializeField]
		private QuestSelectScene.Difficulty _difficulty;

		[SerializeField]
		private QuestSelectList questMenuList;

		[SerializeField]
		private QuestMenuListTitle questListTitle;

		private Action onOpenCallback;

		private Action onCloseCallback;

		private AnimationUIPart[] animationUIParts;

		private Canvas _myCanvas;

		private Button _backButton;

		private Camera _uiCamera;

		private static bool _isOpenOnCreated;

		private bool _isAlreadyOpened;

		private bool isWaitingQuestListAnimationCompleted;

		private bool isStartMainStoryMissionAction;

		[SerializeField]
		private QuestMainDetailList questMainDetailList;

		private List<QuestCellData> cellDataList;

		[SerializeField]
		private GameObject scrollBarObj;

		public int groupId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int locationId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public QuestSelectScene.Difficulty difficulty
		{
			get
			{
				return default(QuestSelectScene.Difficulty);
			}
			set
			{
			}
		}

		public Camera uiCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Canvas myCanvas => null;

		public Button backButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 selectedLandmarkPos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool isOpenOnCreated
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool isAlreadyOpened => default(bool);

		private void Start()
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		public override void OnPageBecomeInActive()
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		private IEnumerator WaitBgAndOpen()
		{
			return null;
		}

		private void Open()
		{
		}

		public void SetOpenCallback([Optional] Action onOpen)
		{
		}

		public void SetCloseCallback([Optional] Action onClose)
		{
		}

		public void OnClose(bool isDestroyOnCompleted = false, bool isCloseTouchGuard = false)
		{
		}

		private void Close()
		{
		}

		private IEnumerator WaitCloseCompleted(bool isDestroyOnCompleted, bool isCloseTouchGuard)
		{
			return null;
		}

		private void InitializeParts(bool isInitializeLandmarkPosAndBg = true)
		{
		}

		private GameObject GetPrefabInstance(GameObject prefabObj, GameObject parentObj)
		{
			return null;
		}

		public void OnAppear(float waitTime)
		{
		}

		private IEnumerator WaitAndOpen(float waitTime)
		{
			return null;
		}

		public void OnHide()
		{
		}

		private void Appear()
		{
		}

		protected void Hide()
		{
		}

		private void SetPartsActive(bool value)
		{
		}

		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
			return default(bool);
		}

		public virtual bool IsMenuListOnAnimation()
		{
			return default(bool);
		}

		public void SetListActive(bool isActive)
		{
		}

		public void CallWaitQuestListAnimationCompletedCoroutine(bool isActivateOnCalled = true, bool isDeactivateOnCompleted = false, [Optional] UnityAction actionOnCompleted)
		{
		}

		private IEnumerator WaitQuestListAnimationCompletedCoroutine(bool isDeactivateOnCompleted, UnityAction actionOnCompleted)
		{
			return null;
		}

		private void OnClickBackButton()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		public void SetDisp(bool isDisp)
		{
		}

		private void StartMainStoryMission(TouchGuardObject touchGuard)
		{
		}

		private bool CheckMainStoryMission()
		{
			return default(bool);
		}

		private string GetMissionStartBonusText()
		{
			return null;
		}

		private void PlayReleaseStoryMissionEffect(Action playEndCallBack)
		{
		}

		private void StartStoryMissionEffect()
		{
		}

		private void EndStoryMissionEffect()
		{
		}
	}
}
