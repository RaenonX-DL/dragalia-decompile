using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BattleRoyalRecordInfoPopup : PopupBase
	{
		[SerializeField]
		[Header("Content")]
		public Text totalTop1CountText;

		public Text totalTop4CountText;

		public Text mostUsedJobText;

		public Text killTotalCountText;

		public Text maxKillCountPerGameText;

		public Text totalPointText;

		public static BattleRoyalRecordInfoPopup Create()
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void ApplyTopCountLocalize(Text text, int c)
		{
		}

		public void OnRecordListButtonPressed()
		{
		}
	}
}
