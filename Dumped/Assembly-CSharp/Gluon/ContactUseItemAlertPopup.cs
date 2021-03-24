/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactUseItemAlertPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private CommonIcon beforeIcon;
		[SerializeField]
		private CommonIcon afterIcon;
		[SerializeField]
		private UnityEngine.UI.Text messageText;
		[SerializeField]
		private UnityEngine.UI.Text overText;
		private UnityAction okButtonAction;
	
		// Constructors
		public ContactUseItemAlertPopup();
	
		// Methods
		public static ContactUseItemAlertPopup Create();
		public void Setup(int dragonId, int currentLevel, int afterLevel, int overValue, UnityAction onPlessOk, bool isWalker);
		public void OnPresseOk();
		protected override void OnDestroy();
	}
}
