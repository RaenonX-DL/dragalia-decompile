using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BattleRoyalRecordListCell : MonoBehaviour
	{
		[SerializeField]
		[Header("Content")]
		public Graphic icon;

		public Graphic jobIcon;

		public Text rankText;

		public Text killCountText;

		public Text dateText;

		public void Setup(BattleRoyalModel.BattleRecord record)
		{
		}
	}
}
