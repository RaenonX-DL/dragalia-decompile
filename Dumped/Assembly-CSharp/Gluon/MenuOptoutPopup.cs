/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Http;
using Gluon.Http;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MenuOptoutPopup : PopupBase
	{
		// Fields
		private const string prefabPath = "Prefabs/OutGame/Menu/MenuOptoutPopup";
		public Toggle sendUsageInfoToggle;
		public UnityEngine.UI.Text checkBoxText;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public CommonPopup popup;
			public MenuOptoutPopup __4__this;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _OnOkButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass8_0
		{
			// Fields
			public UnityAction successCallback;
	
			// Constructors
			public __c__DisplayClass8_0();
	
			// Methods
			internal void _RequestUserOptOutSetting_b__0(UserOptInSettingResponse res);
		}
	
		// Constructors
		public MenuOptoutPopup();
	
		// Methods
		public static MenuOptoutPopup Create();
		public void InitSetting();
		public void OnCancelButtonPressed();
		public void OnOkButtonPressed();
		public void OnToggleClickedSendUsageInfo(bool bOn);
		private void RequestUserOptOutSetting(UnityAction successCallback);
		public static void OnError(ErrorType errorType, int resultCode);
		[CompilerGenerated]
		private void _OnOkButtonPressed_b__6_0();
	}
}
