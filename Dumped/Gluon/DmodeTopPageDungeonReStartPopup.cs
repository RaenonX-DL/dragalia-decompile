using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeTopPageDungeonReStartPopup : CommonIconPopup
	{
		[SerializeField]
		private Text overText;

		public static DmodeTopPageDungeonReStartPopup Create(Size size = Size.S, BottomButtons bottomButtons = BottomButtons.Close, bool showBlackLayer = true, bool showStartAnimation = true)
		{
			return null;
		}

		public void SetOverText(string str)
		{
		}
	}
}
