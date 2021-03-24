/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DownloadPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text confirmText;
		[SerializeField]
		private UnityEngine.UI.Text downloadText;
		[SerializeField]
		private UnityEngine.UI.Text wifiText;
		[SerializeField]
		private UnityEngine.UI.Text helpText;
		private const string prefabPath = "UI/Popup/Download/DownloadPopup";
	
		// Constructors
		public DownloadPopup();
	
		// Methods
		public static DownloadPopup Create(bool showBlackLayer = true, bool showStartAnimation = true);
		public void SetText(long baseByte, string text = "", bool isNeedAddToPlay = false);
	}
}
