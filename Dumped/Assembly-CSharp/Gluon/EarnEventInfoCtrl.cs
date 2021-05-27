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
	public class EarnEventInfoCtrl : EventInfoCtrlBase
	{
		// Fields
		[Header]
		[SerializeField]
		private Image[] materialImages;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text[] materialTexts;
		[SerializeField]
		private UnityEngine.UI.Text hintText;
		[SerializeField]
		private UnityEngine.UI.Text hintTitleText;
	
		// Constructors
		public EarnEventInfoCtrl();
	
		// Methods
		protected override void Start();
		public static EarnEventInfoCtrl Create(Transform parent);
		public override void SetEventInfo();
		private void SetEventHintText();
		private void SetEventHintTitle();
	}
}
