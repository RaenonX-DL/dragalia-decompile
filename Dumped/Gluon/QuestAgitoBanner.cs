using System;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class QuestAgitoBanner : MonoBehaviour
	{
		[SerializeField]
		private ButtonWithSelectedImage detailButtonWithSelectedImage;

		[SerializeField]
		private UIAnimationPublisher uiAnimationPublisher;

		private QuestEventGroupElement groupElement;

		public void Initialize(QuestEventGroupElement element)
		{
		}

		public void PlayEnterAnimation(Action onFinished, [Optional] Action onHalfFinished)
		{
		}

		public void PlayExitAnimation(Action onFinished, [Optional] Action onHalfFinished)
		{
		}

		public void OnQuestDetail()
		{
		}
	}
}
