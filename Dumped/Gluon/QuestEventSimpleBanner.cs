using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestEventSimpleBanner : MonoBehaviour
	{
		[SerializeField]
		private PointerEventHandler simpleExchangeButton;

		[SerializeField]
		private PointerEventHandler simpleHowToButton;

		[SerializeField]
		private ButtonWithSelectedImage simpleHowToButtonWithSelected;

		[SerializeField]
		private Text simpleViewTime;

		[SerializeField]
		private SimpleEventItem[] simpleEventItemRoot;

		[SerializeField]
		private UIAnimationPublisher uiAnimationPublisher;

		private int eventId;

		public void Initialize(int eventId)
		{
		}

		public void PlayEnterAnimation(Action onFinished, [Optional] Action onHalfFinished)
		{
		}

		public void PlayExitAnimation(Action onFinished, [Optional] Action onHalfFinished)
		{
		}

		public void OnSimpleExchangeButtonClick()
		{
		}

		public void OnSimpleHowToButtonClick()
		{
		}
	}
}
