using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RaidBoostCell : MonoBehaviour
	{
		[SerializeField]
		[Header("Cell")]
		public RawImage icon;

		public Text itemName;

		public Text processText;

		public Slider slider;

		public Transform flashAttachNode;

		private RaidBoostPopup.RaidBoostModel.CellData data;

		public void SetupByData(RaidBoostPopup.RaidBoostModel.CellData data)
		{
		}

		public void OnDetailButtonPressed()
		{
		}
	}
}
