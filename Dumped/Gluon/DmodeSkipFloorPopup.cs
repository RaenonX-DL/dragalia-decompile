using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeSkipFloorPopup : PopupBase
	{
		[SerializeField]
		[Header("UI")]
		private Text remainDailySkipCountText;

		[SerializeField]
		private Text emptySkipFloorText;

		[SerializeField]
		[Header("Contoller")]
		private DmodeSkipFloorListController skipFloorListController;

		private int remainDailySkipCount;

		private Action<int> okButtonPressed;

		private static readonly DateTime skipCountResetTime;

		private static readonly string popupPrefabPath;

		public static DmodeSkipFloorPopup Create(int maxFloorNum)
		{
			return null;
		}

		private void Initialize(int maxFloorNum)
		{
		}

		private void ShowSKipConfirmPopup(int destinationFloorNum)
		{
		}

		public void AddOnOKButtonPressed(Action<int> callback)
		{
		}
	}
}
