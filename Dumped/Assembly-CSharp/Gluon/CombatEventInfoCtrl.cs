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
	public class CombatEventInfoCtrl : EventInfoCtrlBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text[] materialTexts;
		[SerializeField]
		private UnityEngine.UI.Text[] difficultyTextList;
		[SerializeField]
		private GameObject[] clearMarkList;
		[SerializeField]
		private UnityEngine.UI.Text hintTitle;
		[SerializeField]
		private UnityEngine.UI.Text hintText;
		public ButtonWithSelectedImage specialHelpButtonWithSelectImage;
	
		// Constructors
		public CombatEventInfoCtrl();
	
		// Methods
		public static CombatEventInfoCtrl Create(Transform parent);
		public override void SetEventInfo();
		private void SetEventHintText();
		protected override void ResetSpecialHelpButtonPressedState();
	}
}
