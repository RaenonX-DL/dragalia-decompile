using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventRankingListPartyMemberCell : MonoBehaviour
	{
		[SerializeField]
		private CommonIcon charaIcon;

		[SerializeField]
		private Image anotherNameIcon;

		[SerializeField]
		private Text usernameText;

		[SerializeField]
		private Text playerLevelText;

		public void SetContent(int charaId, int emblemId, string userName, int level)
		{
		}
	}
}
