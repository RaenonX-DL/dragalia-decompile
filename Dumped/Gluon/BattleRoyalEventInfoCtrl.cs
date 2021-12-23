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

		public static BattleRoyalEventInfoCtrl Create(Transform parent)
		{
			return null;
		}

		public override void SetEventInfo()
		{
		}
	}
}
