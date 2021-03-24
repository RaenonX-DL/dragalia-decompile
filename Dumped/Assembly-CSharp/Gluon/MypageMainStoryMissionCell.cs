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
	public class MypageMainStoryMissionCell : MonoBehaviour
	{
		// Fields
		public static Color titleColor;
		[SerializeField]
		private Image checkBoxObj;
		[SerializeField]
		private Image checkObj;
		[SerializeField]
		private UnityEngine.UI.Text missionText;
		private bool isMissionTitle;
	
		// Constructors
		public MypageMainStoryMissionCell();
		static MypageMainStoryMissionCell();
	
		// Methods
		public void SetText(string text, bool isTitle = false);
		public void SetCheckBox(bool isOn);
		public void SetTextColor(Color color);
	}
}
