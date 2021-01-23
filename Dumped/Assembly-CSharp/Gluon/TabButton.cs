/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[RequireComponent]
	public class TabButton : MonoBehaviour
	{
		// Fields
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
		private UnityEngine.UI.Text offText;
	
		// Constructors
		public TabButton();
	
		// Methods
		private void Awake();
		public void OnValueChanged(bool value);
		public void DisableButton(bool toDisable, bool allImage = false);
		public void SetText(string nameButton, string nameActive = null);
		public void SetCallbackAfterInitializedTheme(Action callback);
	}
}
