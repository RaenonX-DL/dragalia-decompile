/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LoginBonusPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text itemNameText;
		[SerializeField]
		private UnityEngine.UI.Text contentText;
		[SerializeField]
		private CommonIcon icon;
		private Action actionOnClosed;
	
		// Constructors
		public LoginBonusPopup();
	
		// Methods
		public static LoginBonusPopup Create(LoginBonusRewardElement elem, string prefabPath, Action onClosed);
		private void SetupContents(LoginBonusRewardElement elem, Action onClosed);
		public void OnCloseButtonPressed();
	}
}
