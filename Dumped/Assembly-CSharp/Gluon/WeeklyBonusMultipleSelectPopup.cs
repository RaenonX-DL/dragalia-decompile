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
	public class WeeklyBonusMultipleSelectPopup : WeeklyBonusSelectPopup
	{
		// Fields
		[SerializeField]
		private CommonSliderSelection slider;
		[SerializeField]
		private Button receiveButton;
	
		// Constructors
		public WeeklyBonusMultipleSelectPopup();
	
		// Methods
		protected override void Start();
		public void OnSelectedValueChanged(float value);
		protected override int GetReceiveCount();
	}
}
