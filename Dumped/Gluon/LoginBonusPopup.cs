using System;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class LoginBonusPopup : PopupBase
	{
		[SerializeField]
		private Text titleText;

		[SerializeField]
		private Text itemNameText;

		[SerializeField]
		private Text contentText;

		[SerializeField]
		private CommonIcon icon;

		private Action actionOnClosed;

		public static LoginBonusPopup Create(LoginBonusRewardElement elem, string prefabPath, Action onClosed)
		{
			return null;
		}

		private void SetupContents(LoginBonusRewardElement elem, Action onClosed)
		{
		}

		public void OnCloseButtonPressed()
		{
		}
	}
}
