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
	public class RandomEventInfoCtrl : EventInfoCtrlBase
	{
		// Fields
		[SerializeField]
		private EventRewardInfoCtrl rewardInfo;
		[SerializeField]
		private UnityEngine.UI.Text[] exchangeMaterialTexts;
		[SerializeField]
		private UnityEngine.UI.Text nextMedalTitle;
		[SerializeField]
		private UnityEngine.UI.Text totalMedalTitle;
	
		// Constructors
		public RandomEventInfoCtrl();
	
		// Methods
		public static RandomEventInfoCtrl Create(Transform parent);
		public override void SetEventInfo();
	}
}
