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
	public class RaidEventInfoCtrl : EventInfoCtrlBase
	{
		// Fields
		[Header]
		[SerializeField]
		private GameObject friendlyPointParent;
		[SerializeField]
		private UnityEngine.UI.Text friendlyPointText;
		[Header]
		[SerializeField]
		private Image itemImage;
		[SerializeField]
		private UnityEngine.UI.Text itemCountText;
		[Header]
		[SerializeField]
		private Image exItemImage;
		[SerializeField]
		private UnityEngine.UI.Text exItemCountText;
		[Header]
		[SerializeField]
		private Image iconImage;
		[SerializeField]
		private UnityEngine.UI.Text iconCountText;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text exchangeItem1CountText;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text exchangeItem2CountText;
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
		[SerializeField]
		private GameObject hintParent;
		[SerializeField]
		private GameObject itemsParent;
		[Header]
		[SerializeField]
		public GameObject raidBoostGO;
		public GameObject raidBoostSpecialHelpGO;
		public ButtonWithSelectedImage specialHelpButtonWithSelectImage;
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text updateTimeText;
		[SerializeField]
		private UnityEngine.UI.Text individualTotalDamageValueText;
		[SerializeField]
		private UnityEngine.UI.Text wholeTotalDamageValueText;
		[SerializeField]
		private ButtonWithSelectedImage totalDamageRewardButtonSelectedImage;
		[SerializeField]
		private UnityEngine.UI.Text aggregateUpdateTimeText;
		[SerializeField]
		private GameObject friendlyInfoPanel;
		private bool hasRaidBoost;
		private bool isTotalDamageEvent;
		private static readonly string totalDamageRaidEventInfoPrefabPath;
		private static readonly string raidEventInfoPrefabPath;
	
		// Constructors
		public RaidEventInfoCtrl();
		static RaidEventInfoCtrl();
	
		// Methods
		public static RaidEventInfoCtrl Create(Transform parent, bool isTotalDamageEvent);
		public override void SetEventInfo();
		private void SetEventHintText();
		public void OnRaidBoostButtonPressed();
		protected override void ResetSpecialHelpButtonPressedState();
		public void OnTotalDamageRewardButtonPressed();
		private void InitializeTotalDamageEventInfo();
	}
}
