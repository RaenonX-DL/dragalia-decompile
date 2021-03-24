/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlayModeSelectDialog : CommonPopup
	{
		// Fields
		public Button soloPlayButton;
		public Button multiPlayButton;
		public UnityEvent soloButtonCallBack;
		public UnityEvent multiButtonCallBack;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public UnityAction OnOKCallback;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _Create_b__0();
		}
	
		// Constructors
		public PlayModeSelectDialog();
	
		// Methods
		public static PlayModeSelectDialog Create(UnityAction OnOKCallback = null, bool showBlackLayer = true);
		public void SetMessageText(string message);
		public void SoloButtonPressed();
		public void MultiButtonPressed();
	}
}
