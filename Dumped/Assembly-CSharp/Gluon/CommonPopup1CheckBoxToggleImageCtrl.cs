/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonPopup1CheckBoxToggleImageCtrl : MonoBehaviour
	{
		// Fields
		public Toggle toggle;
		public List<Image> targetImage;
		public List<Sprite> toggleOnImage;
		public List<Sprite> toggleOffImage;
		public Button buttonControl;
		public List<Image> buttonImage;
		public List<Sprite> enableButtonImage;
		public List<Sprite> disableButtonImage;
	
		// Constructors
		public CommonPopup1CheckBoxToggleImageCtrl();
	
		// Methods
		private void Start();
		public void SetButtonState(bool isEnable);
		public void OnTggleButtonPressed();
	}
}
