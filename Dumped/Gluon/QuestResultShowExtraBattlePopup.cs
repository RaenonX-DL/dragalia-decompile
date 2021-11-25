using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultShowExtraBattlePopup : PopupBase
	{
		[SerializeField]
		private Image bannerImage;

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text infoText;

		private const string ShowExtraBattlePopupPath = "Prefabs/OutGame/QuestResult/Popup/QuestResultShowExtraBattlePopup";

		public static QuestResultShowExtraBattlePopup Create(QuestEventMenuElement menuElement)
		{
			return null;
		}

		public void SetContent(QuestEventMenuElement menuElement)
		{
		}
	}
}
