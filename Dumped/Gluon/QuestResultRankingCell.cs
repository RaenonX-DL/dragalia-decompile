using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultRankingCell : MonoBehaviour
	{
		[SerializeField]
		private CommonIcon[] commonIcons;

		[SerializeField]
		private GameObject[] emptyIcons;

		[SerializeField]
		private Transform[] charaListSortDecoTrans;

		[SerializeField]
		private GameObject newIcon;

		[SerializeField]
		private Text rankingFactorText;

		[SerializeField]
		private Image bgFront;

		[SerializeField]
		private float fadeInTime;

		[SerializeField]
		private float fadeOutTime;

		[SerializeField]
		[Header("ç\u00b4\u00afè\u00a8\u0088ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8ã\u0082¤ã\u0083\u0099ã\u0083³ã\u0083\u0088")]
		private Text currentDamageText;

		private CommonIconListSortDeco[] charaListSortDeco;

		private const int fontSizeUseIntergerClearTime = 40;

		private const int fontSizeUseFloatClearTime = 31;

		public void InitSetting(TimeAttackRanking.RankingInfo data)
		{
		}

		public void InitSetting(TotalDamageEventRankingData.RankingInfo rankingData)
		{
		}

		[ContextMenu("RankInAnimation")]
		public void RankInAnimation()
		{
		}
	}
}
