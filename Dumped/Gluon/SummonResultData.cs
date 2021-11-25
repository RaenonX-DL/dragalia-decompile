using System.Collections.Generic;
using Gluon.Http;

namespace Gluon
{
	public class SummonResultData
	{
		public List<SummonResultItemData> items;

		public List<SummonResultPrize> summonResultPrizeList;

		public bool hasAutoPresentBoxItems;

		public SummonResultExchangeData summonPointData;

		public int tutorialSummonItemStartIndex;

		public readonly int tutorialSummonCurItemCount;

		public int tutorialSummonCurItemMaxCount;

		public void UpdateDataFromTutorial(int id)
		{
		}

		public void UpdateDataFromResponse()
		{
		}

		public void UpdateDataFromResponse(AtgenBoxSummonResult result, int startIndex, int itemCount)
		{
		}

		public void TutorialSummonReset()
		{
		}

		public bool hasNextItems()
		{
			return default(bool);
		}

		public void UpdateDataFromTutorialSummonResponse(UserRedoableSummonData result)
		{
		}

		public void UpdateBoxSummonResultData(AtgenBoxSummonResult result, int startIndex, int itemCount)
		{
		}

		private void ParseBoxSummonData(AtgenBoxSummonResult result, int i, ref Rarity maxViewRarity, bool addToItems = true)
		{
		}
	}
}
