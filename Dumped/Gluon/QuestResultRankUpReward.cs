using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultRankUpReward : MonoBehaviour
	{
		public enum plantUp
		{
			plantNumUp,
			plantLevlUp
		}

		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text beforeNumText;

		[SerializeField]
		private Text afterNumText;

		public void SetUp(plantUp en, int beforeNum, int afterNum)
		{
		}
	}
}
