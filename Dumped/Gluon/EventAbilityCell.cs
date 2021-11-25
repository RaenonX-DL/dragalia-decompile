using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventAbilityCell : MonoBehaviour
	{
		[SerializeField]
		private Image icon;

		[SerializeField]
		private Text nameText;

		private int dataId;

		public void SetAbilityInfo(AbilityDataElement ade)
		{
		}

		public void OnCellPressed()
		{
		}
	}
}
