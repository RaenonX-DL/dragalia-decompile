using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class OptionBgmSelectToggle : CommonSettingToggleBase
	{
		[Serializable]
		public class BgmToggleChangeEvent : UnityEvent<int>
		{
		}

		public int bgmId;

		public Text bgmTitle;

		[SerializeField]
		private BgmToggleChangeEvent onToggleValueChangedEvent;

		public override void OnToggleValueChanged(bool value)
		{
		}
	}
}
