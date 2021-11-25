using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MenuOtherPopup : CommonPopup
	{
		[SerializeField]
		private Text variousNotationText;

		[SerializeField]
		private Text accountManageText;

		[SerializeField]
		private Text creditText;

		[SerializeField]
		private Text purchaceInfoText;

		[SerializeField]
		private Text optoutText;

		[SerializeField]
		private Text returnTitleText;

		public MenuPopup menuPopup;

		public static MenuOtherPopup Create()
		{
			return null;
		}

		public void InitSetting()
		{
		}

		public void OnVariousNotationButtonPressed()
		{
		}

		public void OnAccountManageButtonPressed()
		{
		}

		public static void DoAccountManage()
		{
		}

		private static void CreateAlreadyLinkToNAPopup()
		{
		}

		public void OnPurchaceInfoButtonPressed()
		{
		}

		public void OnOptoutButtonPressed()
		{
		}

		public void OnReturnTitleButtonPressed()
		{
		}
	}
}
