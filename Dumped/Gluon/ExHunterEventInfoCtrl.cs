using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ExHunterEventInfoCtrl : EventInfoCtrlBase
	{
		public enum BoardAnimationType
		{
			Idle,
			In,
			Out,
			Up,
			Down
		}

		[SerializeField]
		[Header("Exchange")]
		private Text exchangeItem1Text;

		[SerializeField]
		private Text exchangeItem2Text;

		[SerializeField]
		[Header("Components")]
		private Text itemCountText;

		[SerializeField]
		private Text exItemCountText;

		[SerializeField]
		private Text iconCountText;

		[SerializeField]
		private Text hintText;

		[SerializeField]
		[Header("Animation")]
		private Animator boardAnimator;

		public static ExHunterEventInfoCtrl Create(Transform parent)
		{
			return null;
		}

		public override void SetEventInfo()
		{
		}

		private void SetEventHintText()
		{
		}

		public void TriggerBoardAnimation(BoardAnimationType type)
		{
		}

		public void TriggerBoardAnimation_Idle()
		{
		}

		public void TriggerBoardAnimation_In()
		{
		}

		public void TriggerBoardAnimation_Out()
		{
		}

		public void TriggerBoardAnimation_Up()
		{
		}

		public void TriggerBoardAnimation_Down()
		{
		}

		public void OnRaidBoostButtonPressed()
		{
		}
	}
}
