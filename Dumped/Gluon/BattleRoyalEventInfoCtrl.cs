using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BattleRoyalEventInfoCtrl : EventInfoCtrlBase
	{
		[SerializeField]
		private Text totalPointText;

		[SerializeField]
		private Text currentPointText;

		[SerializeField]
		private Text hintText;

		[SerializeField]
		private Text hintTitle;

		public static BattleRoyalEventInfoCtrl Create(Transform parent)
		{
			return null;
		}

		public override void SetEventInfo()
		{
		}

		private void SetEventHintText()
		{
		}
	}
}
