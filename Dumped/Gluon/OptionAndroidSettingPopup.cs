using System;
using UnityEngine;

namespace Gluon
{
	public class OptionAndroidSettingPopup : PopupBase
	{
		[SerializeField]
		[Header("Tabs")]
		public TabBase statusBarTab;

		public TabBase navigationBarTab;

		private bool statusBarOn;

		private bool navigationBarOn;

		private Action onClosed;

		public static OptionAndroidSettingPopup Create(Action onClosed)
		{
			return null;
		}

		protected override void Start()
		{
		}

		public void OnAppliedAnyAction()
		{
		}

		private void BindEvent()
		{
		}

		private void TabCallbackToToggle(TabBase tab, Action<bool> toggleCallback)
		{
		}

		private void ApplyUIByOptionSetting()
		{
		}

		public void OnOKButtonPressed()
		{
		}

		public void OnStatusBarToggled(bool value)
		{
		}

		public void OnNavigationBarToggled(bool value)
		{
		}
	}
}
