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
	public class ExHunterEventInfoCtrl : EventInfoCtrlBase
	{
		// Fields
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text exchangeItem1Text;
		[SerializeField]
		private UnityEngine.UI.Text exchangeItem2Text;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text itemCountText;
		[SerializeField]
		private UnityEngine.UI.Text exItemCountText;
		[SerializeField]
		private UnityEngine.UI.Text iconCountText;
		[SerializeField]
		private UnityEngine.UI.Text hintText;
		[Header]
		[SerializeField]
		private Animator boardAnimator;
	
		// Nested types
		public enum BoardAnimationType
		{
			Idle = 0,
			In = 1,
			Out = 2,
			Up = 3,
			Down = 4
		}
	
		// Constructors
		public ExHunterEventInfoCtrl();
	
		// Methods
		public static ExHunterEventInfoCtrl Create(Transform parent);
		public override void SetEventInfo();
		private void SetEventHintText();
		public void TriggerBoardAnimation(BoardAnimationType type);
		public void TriggerBoardAnimation_Idle();
		public void TriggerBoardAnimation_In();
		public void TriggerBoardAnimation_Out();
		public void TriggerBoardAnimation_Up();
		public void TriggerBoardAnimation_Down();
		public void OnRaidBoostButtonPressed();
	}
}
