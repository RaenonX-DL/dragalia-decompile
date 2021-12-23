using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeServitorPassiveBuildUpConfirmPopup : PopupBase, ICustomMessage
	{
		[SerializeField]
		private DmodeServitorPassiveAbilityCell abilitycell;

		[SerializeField]
		private CraftMaterialCell[] materialCell;

		[SerializeField]
		private Button buildButton;

		[SerializeField]
		private Text insufficientMaterialText;

		public const string prefabPath = "Prefabs/OutGame/Dmode/DmodeServitor/DmodeServitorPassiveBuildUpConfirmPopup";

		private DmodeServitorPassiveLevelElement passiveElement;

		public static DmodeServitorPassiveBuildUpConfirmPopup Create(Dictionary<int, int> materialDataDic, DmodeServitorPassiveLevelElement element)
		{
			return null;
		}

		public void SetContent(Dictionary<int, int> needMaterialDataDic, DmodeServitorPassiveLevelElement element)
		{
		}

		private void OnIconPressed(CraftMaterialCellData data)
		{
		}

		public void OnPassiveAbilityLevelRelease()
		{
		}

		public void OnBuildUpServitorPassive()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}
	}
}
