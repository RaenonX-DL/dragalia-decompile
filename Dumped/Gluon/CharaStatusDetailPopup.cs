using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CharaStatusDetailPopup : CommonPopup
	{
		public Text charaHpParam;

		public Text charaAtkParam;

		public Text dragonHpParam;

		public Text dragonAtkParam;

		public Text weaponHpParam;

		public Text weaponAtkParam;

		public Text fortHpParam;

		public Text fortAtkParam;

		public Text abilityHpParam;

		public Text abilityAtkParam;

		public Text amuletHpParam;

		public Text amuletAtkParam;

		public Text totalHpParam;

		public Text totalAtkParam;

		public Text plusHpValueParam;

		public Text plusAtkValueParam;

		public GameObject plusValueObj;

		public Text albumHpParam;

		public Text albumAtkParam;

		public GameObject albumObj;

		public static CharaStatusDetailPopup Create(UnitDetailModel.UnitDetailType detailType)
		{
			return null;
		}

		public void SetCharaStatus(bool isEquipParamPlus)
		{
		}
	}
}
