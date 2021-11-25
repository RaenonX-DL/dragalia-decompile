using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TabButton : MonoBehaviour
	{
		[SerializeField]
		public int index;

		[SerializeField]
		protected GameObject onImage;

		[SerializeField]
		public TabBase tabBase;

		public Action onEnabledAction;

		private Toggle toggle;

		[SerializeField]
		private Image offImage;

		[SerializeField]
		private Text offText;

		private void Awake()
		{
		}

		public void OnValueChanged(bool value)
		{
		}

		public void DisableButton(bool toDisable, bool allImage = false)
		{
		}

		public void SetText(string nameButton, [Optional] string nameActive)
		{
		}

		public void SetCallbackAfterInitializedTheme(Action callback)
		{
		}
	}
}
