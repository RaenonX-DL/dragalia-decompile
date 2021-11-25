using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class ContactUseItemAlertPopup : PopupBase
	{
		[SerializeField]
		private CommonIcon beforeIcon;

		[SerializeField]
		private CommonIcon afterIcon;

		[SerializeField]
		private Text messageText;

		[SerializeField]
		private Text overText;

		private UnityAction okButtonAction;

		public static ContactUseItemAlertPopup Create()
		{
			return null;
		}

		public void Setup(int dragonId, int currentLevel, int afterLevel, int overValue, UnityAction onPlessOk, bool isWalker)
		{
		}

		public void OnPresseOk()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
