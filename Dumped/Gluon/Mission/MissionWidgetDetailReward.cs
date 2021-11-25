using UnityEngine;
using UnityEngine.UI;

namespace Gluon.Mission
{
	public class MissionWidgetDetailReward : MonoBehaviour
	{
		[SerializeField]
		[Header("å\u00a0±é\u0085¬ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³")]
		public MissionWidgetRewardIcon rewardIcon;

		[SerializeField]
		[Header("é\u0081\u0094æ\u0088\u0090æ\u00b8\u0088ã\u0082¹ã\u0082¿ã\u0083³ã\u0083\u0097")]
		public GameObject imageComplete;

		[SerializeField]
		[Header("å\u008f\u0097å\u008f\u0096æ\u00b8\u0088ã\u0082¹ã\u0082¿ã\u0083³ã\u0083\u0097")]
		public GameObject imageReceived;

		[SerializeField]
		[Header("å\u00a0±é\u0085¬ã\u0082¢ã\u0082¤ã\u0083\u0086ã\u0083\u00a0è©³ç\u00b4°")]
		public Text textItemDesc;

		[SerializeField]
		[Header("å\u00a0±é\u0085¬ã\u0082¢ã\u0082¤ã\u0083\u0086ã\u0083\u00a0ã\u0083«ã\u0083\u0093")]
		public Text textItemRuby;

		[SerializeField]
		[Header("é\u0081\u0094æ\u0088\u0090åº¦")]
		public MissionWidgetAchievement achievement;
	}
}
