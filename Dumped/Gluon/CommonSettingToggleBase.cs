using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonSettingToggleBase : MonoBehaviour
	{
		[SerializeField]
		[Header("Components")]
		public Toggle toggle;

		public Action<bool, bool> onToggleValueChanged;

		public Toggle.ToggleEvent onToggleClicked;

		protected bool isSettingBySystem;

		protected ToggleSound toggleSound;

		private void Awake()
		{
		}

		public void SetToggleState(bool value)
		{
		}

		public virtual void OnToggleValueChanged(bool value)
		{
		}

		public static int GetActiveToggle(CommonSettingToggleBase[] toggles)
		{
			return default(int);
		}
	}
}
