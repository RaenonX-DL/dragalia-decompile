using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventTopPageBase : EventQuestPageBase
	{
		[SerializeField]
		[Header("LeftTop Parts")]
		protected Image titleImage;

		[SerializeField]
		protected Text durationText;

		[SerializeField]
		protected GameObject eventEndDescription;

		[SerializeField]
		[Header("General QuestButtons")]
		protected Button questListButton;

		[SerializeField]
		protected Button multiButton;

		[SerializeField]
		[Header("Button Parent")]
		protected GameObject buttonsParent;

		[SerializeField]
		protected GameObject buttonsParent4;

		[SerializeField]
		[Header("ButtonCtrl")]
		protected EventCommonButtonCtrl commonButtonCtrl;

		[SerializeField]
		protected EventCommonButtonCtrl commonButtonCtrl4;

		[SerializeField]
		[Header("work around")]
		protected bool workaroundRefs271047;

		protected string voiceData;

		protected void OnMissionButtonTouched()
		{
		}

		public override void OnPageBecomeActive(object data)
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void SetDurationText()
		{
		}

		public virtual void OnQuestButtonTouched()
		{
		}

		public void OnBackButtonTouched()
		{
		}

		public void OnMultiButtonTouched()
		{
		}

		private void ShowMultiJoinPopup()
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override void OnPageEnterAnimationEnded()
		{
		}

		protected virtual void OnBeginningPopupShown()
		{
		}

		public string UpdateVoiceData()
		{
			return null;
		}

		protected virtual IEnumerator WaitForStatusInfoInitilizing(AnimationPattern pattern)
		{
			return null;
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override bool IsOnAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1)
		{
			return default(bool);
		}

		private void GoPrepareScene(int questId, QuestAutoTransitionUtil.GuestEnterRoomFromType enterFromType)
		{
		}

		private void SetParentUiQuestPrepareMode()
		{
		}
	}
}
