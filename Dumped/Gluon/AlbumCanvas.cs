using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumCanvas : AnimationUICanvas
	{
		[SerializeField]
		private OutGameBgChara chara;

		[SerializeField]
		private AnimationUITalkWindow balloon;

		[SerializeField]
		private AlbumCharaTalkSelector charaTalkSelector;

		[SerializeField]
		private Text talkName;

		[SerializeField]
		private Text talkText;

		[SerializeField]
		private ButtonWithSelectedImage howToReset;

		private string charaVoiceGroupName;

		private const int eventPopId = 999999;

		private const int eventPopCount = 3;

		private const int eventPopCountAdd = 4;

		private static readonly string EventPrologueName;

		public void OnPressedPlayRecordButton()
		{
		}

		public void OnPressedPictureBookButton()
		{
		}

		public void OnHowToButton()
		{
		}

		public void Talk(string charaVoiceGroupName, string voiceName)
		{
		}

		public void StartBalloonAnimation(OutGameTopCharaTalkSelector.TalkData talkData, bool dontRunCloseAnimation = false, bool ignoreDelay = false)
		{
		}

		public void SetTalkTextString(string text)
		{
		}

		public void SetTalkNameString(string text)
		{
		}

		public void SetChara()
		{
		}

		public void SetcharaVoiceGroupName(string charaVoiceGroupName)
		{
		}

		public void FirstVoiceStart()
		{
		}

		public void OnCharaPressed()
		{
		}

		public override void StartEnterAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}

		public override void StartExitAnimation(AnimationPattern pattern = AnimationPattern.Pattern_1, [Optional] Action onAnimationDone, [Optional] Action onCutOff)
		{
		}
	}
}
