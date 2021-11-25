using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class AlbumStoryReviewStatusInfoCtrl : AnimationUIObject
	{
		[SerializeField]
		private OutGameBgChara chara;

		[SerializeField]
		private RectTransform charaRectTransform;

		[SerializeField]
		private AnimationUITalkWindow balloon;

		[SerializeField]
		private AlbumCharaTalkSelector charaTalkSelector;

		[SerializeField]
		private Text talkName;

		[SerializeField]
		private Text talkText;

		private string charaVoiceGroupName;

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
	}
}
