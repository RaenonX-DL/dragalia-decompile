using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumStoryReviewScene : SceneBase
	{
		[SerializeField]
		private Camera mainCamera;

		[SerializeField]
		private Canvas commonUICanvas;

		private string charaVoiceGroupName;

		private UnityAction backButtonSoundAction;

		private AlbumStoryReviewStatusInfoCtrl _statusInfo;

		public static SceneNameDefine.PageName firstPage;

		public static SceneNameDefine.PageName previousPage;

		public static int questGroupId;

		public static AlbumStoryGroupType eventType;

		public Button backButton
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public AlbumStoryReviewStatusInfoCtrl statusInfo => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private IEnumerator WaitPrevSceneExit()
		{
			return null;
		}

		private void LoadEventStatus()
		{
		}

		private void BackButtonPressed()
		{
		}

		public void BindBackButtonCallback(UnityAction callback, bool showExitAnimationWhenClick)
		{
		}

		public override void StartExitAnimation()
		{
		}

		public void ForceMoveBackButton(bool isIn)
		{
		}

		public override void OnBeforeLeaving()
		{
		}
	}
}
