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
	public class GrowthAwakeConfirmPop : CommonPopup
	{
		// Fields
		public Image breforeIcon;
		public Image afterIcon;
		public UnityEngine.UI.Text beforeLevel;
		public UnityEngine.UI.Text afterLevel;
		public UnityEngine.UI.Text beforeHp;
		public UnityEngine.UI.Text afterHp;
		public UnityEngine.UI.Text beforeAtk;
		public UnityEngine.UI.Text afterAtk;
		public UnityEngine.UI.Text beforePower;
		public UnityEngine.UI.Text afterPower;
		public UnityEngine.UI.Text beforeManacircle;
		public UnityEngine.UI.Text afterManacircle;
		public UnityEngine.UI.Text needDew;
		public UnityEngine.UI.Text beforeDew;
		public UnityEngine.UI.Text afterDew;
		[SerializeField]
		private UnityEngine.UI.Text headerAwakeText;
		[SerializeField]
		private UnityEngine.UI.Text headerItemText;
		[SerializeField]
		private UnityEngine.UI.Text statusLevelText;
		[SerializeField]
		private UnityEngine.UI.Text statusHpText;
		[SerializeField]
		private UnityEngine.UI.Text statusAtkText;
		[SerializeField]
		private UnityEngine.UI.Text statusPowerText;
		[SerializeField]
		private UnityEngine.UI.Text statusManacircleText;
		[SerializeField]
		private UnityEngine.UI.Text needDewText;
		[SerializeField]
		private UnityEngine.UI.Text awakeAlertText;
	
		// Constructors
		public GrowthAwakeConfirmPop();
	
		// Methods
		public static GrowthAwakeConfirmPop Create(bool showBlackLayer = true);
		public void InitPop(ulong unitKeyId);
		private void InitText();
	}
}
