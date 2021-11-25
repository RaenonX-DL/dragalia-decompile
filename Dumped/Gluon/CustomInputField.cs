using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

namespace Gluon
{
	public class CustomInputField : InputField
	{
		private Action onEditCallback;

		private Action onEndEditCallback;

		public void InitSetting([Optional] Action onEditCallback, [Optional] Action onEndEditCallback)
		{
		}

		private void Update()
		{
		}

		private void OnEdit(string inputText)
		{
		}

		private void OnEndEdit(string inputText)
		{
		}

		public bool IsEditMessage()
		{
			return default(bool);
		}

		public void Clear()
		{
		}
	}
}
