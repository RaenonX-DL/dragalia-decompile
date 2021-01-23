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
	public class RaidEventInfoCtrl : EventInfoCtrlBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text friendlyPointText;
		[SerializeField]
		private UnityEngine.UI.Text itemCountText;
		[SerializeField]
		private UnityEngine.UI.Text exItemCountText;
		[SerializeField]
		private UnityEngine.UI.Text iconCountText;
		[SerializeField]
		private UnityEngine.UI.Text hintText;
		[SerializeField]
		private UnityEngine.UI.Text hintTitleText;
		[SerializeField]
		private UnityEngine.UI.Text charaGrowItemCountText;
		[SerializeField]
		private Image charaGrowItemIcon;
		[SerializeField]
		private GameObject charaGrowItem;
		[SerializeField]
		private Gauge gauge;
		[Header]
		[SerializeField]
		public GameObject raidBoostGO;
		public GameObject raidBoostSpecialHelpGO;
		public ButtonWithSelectedImage specialHelpButtonWithSelectImage;
		private bool hasRaidBoost;
	
		// Constructors
		public RaidEventInfoCtrl();
	
		// Methods
		public static RaidEventInfoCtrl Create(Transform parent);
		public override void SetEventInfo();
		private void SetEventHintText();
		public void OnRaidBoostButtonPressed();
		protected override void ResetSpecialHelpButtonPressedState();
	}
}
