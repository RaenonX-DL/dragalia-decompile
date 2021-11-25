using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class FirstCharaSelectPopup : PopupBase
	{
		[SerializeField]
		private FirstCharaSelectController tableView;

		private SummonScene scene;

		public static FirstCharaSelectPopup Create(SummonScene scene)
		{
			return null;
		}

		public void SetContent()
		{
		}

		public void OnClickButton(int id)
		{
		}

		public void ClosePopup([Optional] Action onFinished)
		{
		}

		public static bool IsSelectCharacterAllPartyIn()
		{
			return default(bool);
		}
	}
}
