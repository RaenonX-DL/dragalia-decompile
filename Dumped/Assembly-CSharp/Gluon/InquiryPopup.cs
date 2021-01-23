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
	public class InquiryPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/TitleMenu/InquiryPopup";
		[SerializeField]
		private UnityEngine.UI.Text titleText;
		[SerializeField]
		private UnityEngine.UI.Text CancelButtonText;
		[SerializeField]
		private UnityEngine.UI.Text OkButtonText;
		private string[] checkInfoStrings;
		private string urlFormat;
	
		// Nested types
		private enum CheckInfo
		{
			UserID = 0,
			AppVersion = 1,
			DeviceOS = 2,
			DeviceName = 3,
			Max = 4
		}
	
		// Constructors
		public InquiryPopup();
	
		// Methods
		public static InquiryPopup Create();
		public void InitSetting();
		public void OnCloseButtonPressed();
		public void OnOkButtonPressed();
		public void OnToggleClickedUserID(bool bOn);
		public void OnToggleClickedAppVersion(bool bOn);
		public void OnToggleClickedDeviceOS(bool bOn);
		public void OnToggleClickedDeviceName(bool bOn);
	}
}
