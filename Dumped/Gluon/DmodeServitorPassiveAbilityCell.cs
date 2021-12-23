using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeServitorPassiveAbilityCell : MonoBehaviour
	{
		[SerializeField]
		private CommonIcon commonIcon;

		[SerializeField]
		private Text nameText;

		[SerializeField]
		private Text detailText;

		[SerializeField]
		private Text passiveLevelText;

		private DmodeServitorPassiveLevelElement dmodeServitorPassiveElement;

		public void SetContet(DmodeServitorPassiveLevelElement dsple)
		{
		}

		public void OnAbilityIcon()
		{
		}
	}
}
