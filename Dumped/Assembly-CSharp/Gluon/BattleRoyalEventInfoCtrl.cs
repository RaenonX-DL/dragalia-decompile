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
	public class BattleRoyalEventInfoCtrl : EventInfoCtrlBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text totalPointText;
		[SerializeField]
		private UnityEngine.UI.Text currentPointText;
		[SerializeField]
		private UnityEngine.UI.Text hintText;
		[SerializeField]
		private UnityEngine.UI.Text hintTitle;
	
		// Constructors
		public BattleRoyalEventInfoCtrl();
	
		// Methods
		public static BattleRoyalEventInfoCtrl Create(Transform parent);
		public override void SetEventInfo();
		private void SetEventHintText();
	}
}
