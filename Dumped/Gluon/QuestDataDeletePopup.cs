using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestDataDeletePopup : CommonPopup
	{
		private enum DeleteType
		{
			ClearedQuest,
			AllQuest
		}

		public Text allQuestSizeNum;

		public Text clearedQuestSizeNum;

		public Text descText;

		private HashSet<string> clearedQuestAssets;

		private HashSet<string> allQuestAssets;

		private const int yieldStep = 3;

		private DeleteType deleteType;

		public static QuestDataDeletePopup CreateQuestDataDeletePopup()
		{
			return null;
		}

		public IEnumerator CollectDeleteAssets()
		{
			return null;
		}

		private void SetDeleteSize(long allQuestSize, long clearedQuestSize)
		{
		}

		private void SetDeleteType(DeleteType type)
		{
		}

		public void OnAllQuestToggled(bool arg)
		{
		}

		public void OnClearedQuestToggled(bool arg)
		{
		}

		public void OnDeleteButtonPressed()
		{
		}

		private static IEnumerator CollectDeleteAsset(HashSet<string> targetQuestAssets, HashSet<string> reservedQuestAssets)
		{
			return null;
		}

		private IEnumerator DeleteQuestData(DeleteType type)
		{
			return null;
		}
	}
}
