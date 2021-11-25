using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventInfoCtrlBase : MonoBehaviour
	{
		[SerializeField]
		[Header("Howto")]
		public Button howtoButton;

		[SerializeField]
		[Header("WebView")]
		public Button scheduleButton;

		[SerializeField]
		[Header("Publisher")]
		public UIAnimationPublisher innerMovePublisher;

		[SerializeField]
		[Header("SyncTopMask")]
		public RectTransform syncTopMask;

		protected virtual void Start()
		{
		}

		public virtual void SetEventInfo()
		{
		}

		public virtual void OnResetTopImageAndTalk()
		{
		}

		public void OnHowtoButtonTouched()
		{
		}

		public void OnScheduleButtonTouched()
		{
		}

		protected virtual void ResetSpecialHelpButtonPressedState()
		{
		}

		public void AdjustMoveOffset(float moveOffset)
		{
		}
	}
}
