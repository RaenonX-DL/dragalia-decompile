using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventRankingListCell : QuestCommonTableViewCell<EventRankingListCellData>
	{
		[SerializeField]
		private EventRankingListPartyMemberCell[] partyMemberCellArray;

		[SerializeField]
		private UiImageExchanger rankTitleImageExchanger;

		[SerializeField]
		private Text rankText;

		[SerializeField]
		public CommonIconButtonEvent buttonPressed;

		private const int specialImageLowestRank = 3;

		private const int mileStoneRankImageIndex = 3;

		private const int defaultRankImageIndex = 4;

		private const int mileStoneNumberUnit = 10;

		private bool _isNeedToUpdateLoadContent;

		public bool isNeedToUpdateLoadContent
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public override void UpdateContent(EventRankingListCellData data)
		{
		}

		public void UpdateLoadContent(EventRankingListCellData data)
		{
		}

		private bool IsSpecialImageRank(int rank)
		{
			return default(bool);
		}

		private int GetRankTitleImageIndex(int rank)
		{
			return default(int);
		}
	}
}
