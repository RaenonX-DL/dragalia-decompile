using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class RecoverStaminaDonePopup : PopupBase
	{
		[SerializeField]
		[Header("Contents")]
		public GameObject[] iconFrames;

		public CommonIcon[] icons;

		public Text commentText;

		public Text titleText;

		[SerializeField]
		[Header("BeforeAfter")]
		public Text beforeStaminaText;

		public Text afterStaminaText;

		public Text beforeStoneText;

		public Text afterStoneText;

		public GameObject stoneLineGO;

		public Text staminaTabText;

		public Text stoneText;

		public GameObject freeStoneGO;

		public GameObject paidStoneGO;

		public static RecoverStaminaDonePopup Create(int beforeStamina, int afterStamina, bool isMulti, int beforeStone = -1, int afterStone = -1, [Optional] EntityData[] usedItem)
		{
			return null;
		}

		private void Setup(int beforeStamina, int afterStamina, bool isMulti, int beforeStone = -1, int afterStone = -1, [Optional] EntityData[] usedItem)
		{
		}

		public void OnCloseButtonPressed()
		{
		}
	}
}
