using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ManageAccountMenu : CommonPopup
	{
		private const string path = "Prefabs/OutGame/DataTransition/ManageNintendoMenu";

		[SerializeField]
		private Text MenuTitle;

		[SerializeField]
		private Text AccountLabel;

		[SerializeField]
		private Text DeleteAllDataLabel;

		[SerializeField]
		private Text AccountAreaText;

		[SerializeField]
		private Text DeleteAllDataAreaText;

		[SerializeField]
		private Text AccountManageButton;

		[SerializeField]
		private Text DeleteAllDataButton;

		[SerializeField]
		private Text mailAdressLabel;

		[SerializeField]
		private Text mailAdress;

		public static void Create()
		{
		}

		private static string GetEmail()
		{
			return null;
		}

		public static string GetNickname()
		{
			return null;
		}

		private static string GetFilteredAddress(string email)
		{
			return null;
		}

		public void OnManageAccountButton()
		{
		}

		public void OnDeleteAllDataButton()
		{
		}
	}
}
