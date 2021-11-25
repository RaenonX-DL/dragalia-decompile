using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthResetPlusConfirmPop : CommonPopup
	{
		public enum ResetPlusType
		{
			None,
			Hp,
			Atk,
			All
		}

		public CraftMaterialCell originCell;

		[SerializeField]
		private Text rupiAlertText;

		[SerializeField]
		private Text afterRupiText;

		[SerializeField]
		private Text beforeRupiText;

		[SerializeField]
		private Text needRupiText;

		[SerializeField]
		private Text resetAlertText;

		[SerializeField]
		private Text messageText;

		public static GrowthResetPlusConfirmPop Create(bool showBlackLayer = true)
		{
			return null;
		}

		public void InitPop(ResetPlusType resetType, GrowthBaseType growthBaseType, ulong targetKeyId)
		{
		}

		private void OnCellPressed(CraftMaterialCellData cellData)
		{
		}
	}
}
