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
	public class InitialOptionStepPopupPage : MonoBehaviour
	{
		// Fields
		public GameObject vocalPage;
		public GameObject graphicPage;
		public GameObject uiLayoutPage;
		public UnityEngine.UI.Text title;
		public RubySupportedText comment;
		public Image image;
		public TabBase vocalTab;
		public TabBase graphicTab;
		public TabBase uiLayoutTab;
	
		// Constructors
		public InitialOptionStepPopupPage();
	
		// Methods
		public void SetupWithType(InitialOptionStepPopup.PageIndex index);
		private void Start();
		private void BindEvents();
		public void OnVocalSettingChanged(int index, bool isFromUI);
		public void OnGraphicQualitySettingChanged(int index, bool isFromUI);
		public void OnUILayoutSettingChanged(int index, bool isFromUI);
	}
}
