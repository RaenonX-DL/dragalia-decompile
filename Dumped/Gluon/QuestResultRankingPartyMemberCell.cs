using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultRankingPartyMemberCell : MonoBehaviour
	{
		[SerializeField]
		private CommonIcon charaIcon;

		[SerializeField]
		private Image anotherNameIcon;

		[SerializeField]
		private Text usernameText;

		[SerializeField]
		private Text playerLevelText;

		[SerializeField]
		private Image youTextImage;

		public void SetContent(int charaId, int emblemId, string userName, int level, bool isShowYouImage)
		{
		}
	}
}
