using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RaidBoostEventCharaCell : MonoBehaviour
	{
		[SerializeField]
		public Text eventCharaBoostText;

		[SerializeField]
		private EventAbilityCell eventCharaBoostCell;

		[SerializeField]
		private CommonIcon eventCharaIcon;

		public void SetContent(RaidBoostPopup.RaidBoostModel.RaidEventAbilityChara abilityCharaData)
		{
		}
	}
}
