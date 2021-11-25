using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultEventRewardGetPopup : PopupBase
	{
		[SerializeField]
		private CommonIcon commonIcon;

		[SerializeField]
		private Text nameText;

		public void Set(MazeEventRewardElement reward)
		{
		}

		public void Set(BuildEventRewardElement reward)
		{
		}
	}
}
