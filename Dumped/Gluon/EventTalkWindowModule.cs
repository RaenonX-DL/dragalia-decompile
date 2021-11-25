using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventTalkWindowModule : MonoBehaviour
	{
		public enum Type
		{
			Balloon,
			TextWindow
		}

		[SerializeField]
		[Header("Talk")]
		private Text charaNameText;

		[SerializeField]
		private Text contentText;

		[SerializeField]
		[Header("GO")]
		public RectTransform rt;

		[SerializeField]
		[Header("Animations")]
		public AnimationUITalkWindow balloonAnimation;

		public UIAnimationPublisher commonBalloonAnimaiton;

		[SerializeField]
		[Header("Type")]
		public Type type;

		[SerializeField]
		[Header("StatusCtrl")]
		public EventStatusInfoCtrl infoCtrl;

		private float contentAnimationSpeed;

		public void SetCharaName(string charaName)
		{
		}

		public void SetContent(string content)
		{
		}

		public void SetShowHide(bool show)
		{
		}

		public bool IsActiveInHierarchy()
		{
			return default(bool);
		}

		public void SetShowHideWithScale(bool show)
		{
		}

		public bool IsHidingWithScale()
		{
			return default(bool);
		}

		public void StartEnterAnimation()
		{
		}

		public void StartExitAnimation()
		{
		}

		public void StartCloseAndOpenAnimation(string voiceData, [Optional] Action onCloseAndReopen)
		{
		}
	}
}
