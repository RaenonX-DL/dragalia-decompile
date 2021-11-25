using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DragonStatusDetailPopup : CommonPopup
	{
		public Text dragonHpParam;

		public Text dragonAtkParam;

		public Text fortHpParam;

		public Text fortAtkParam;

		public Text totalHpParam;

		public Text totalAtkParam;

		public Text plusHpValueParam;

		public Text plusAtkValueParam;

		public GameObject plusValueObj;

		public Text albumHpParam;

		public Text albumAtkParam;

		public GameObject albumObj;

		public static DragonStatusDetailPopup Create()
		{
			return null;
		}

		public void SetStatus()
		{
		}
	}
}
