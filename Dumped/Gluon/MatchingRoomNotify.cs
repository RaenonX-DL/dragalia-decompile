using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MatchingRoomNotify : MonoBehaviour
	{
		[SerializeField]
		private Text message;

		[SerializeField]
		private RectTransform rectTransform;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private float notifyFadeInTime;

		[SerializeField]
		private float notifyFadeInBeginY;

		[SerializeField]
		private float notifyFadeInEndY;

		[SerializeField]
		private Ease notifyFadeInEase;

		[SerializeField]
		private float notifyIdleTime;

		[SerializeField]
		private float notifyIdleEndY;

		[SerializeField]
		private Ease notifyIdleEase;

		[SerializeField]
		private float notifyFadeOutTime;

		[SerializeField]
		private float notifyFadeOutEndY;

		[SerializeField]
		private Ease notifyFadeOutEase;

		private Sequence sequence;

		public void SetMessege(string str)
		{
		}

		[ContextMenu("PlayAnimation")]
		public void PlayAnimation()
		{
		}

		public bool IsPlaying()
		{
			return default(bool);
		}
	}
}
