using System;
using UnityEngine;

namespace Gluon
{
	public class OptionMyPageBgmChangePopup : PopupBase
	{
		[SerializeField]
		private GameObject[] togglesObject;

		[SerializeField]
		private GameObject limitedTitleObject;

		[SerializeField]
		private int regularBgmCount;

		private int selectedBgmId;

		private int changedBgmId;

		private Action<int> onChangeBgmAction;

		private bool isLimitedBgmExist;

		public static OptionMyPageBgmChangePopup Create(Action<int> onChangeBgmAction)
		{
			return null;
		}

		private void Awake()
		{
		}

		private void SetEnentBgmToggle()
		{
		}

		private void SetUpToggle(GameObject obj)
		{
		}

		private bool IsBgmEnabled(int bgmId)
		{
			return default(bool);
		}

		private string GetBgmTitle(int bgmId)
		{
			return null;
		}

		public void OnSelectToggle(OptionBgmSelectToggle toggle)
		{
		}

		public void OnOKButtonPressed()
		{
		}
	}
}
