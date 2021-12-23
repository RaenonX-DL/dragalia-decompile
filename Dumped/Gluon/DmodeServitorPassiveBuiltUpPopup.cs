using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class DmodeServitorPassiveBuiltUpPopup : CommonPopup
	{
		[SerializeField]
		private CommonIcon commonIcon;

		public const string prefabPath = "Prefabs/OutGame/Dmode/DmodeServitor/DmodeServitorPassiveBuiltUpPopup";

		private DmodeServitorPassiveLevelElement passiveLevelElement;

		public static DmodeServitorPassiveBuiltUpPopup Create(DmodeServitorPassiveLevelElement element)
		{
			return null;
		}

		public void SetContent(DmodeServitorPassiveLevelElement element)
		{
		}

		public void OnPassiveGrowthEnd()
		{
		}

		public void OnPassiveGrowthAgain()
		{
		}

		public void OnAbilityIcon()
		{
		}
	}
}
