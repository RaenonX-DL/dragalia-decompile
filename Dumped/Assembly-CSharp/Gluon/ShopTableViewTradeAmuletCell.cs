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
	public class ShopTableViewTradeAmuletCell : TableViewCell<Gluon.ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData>
	{
		// Fields
		[SerializeField]
		private CommonIcon amuletImage;
		[SerializeField]
		private UnityEngine.UI.Text amuletNameText;
		[SerializeField]
		private UnityEngine.UI.Text[] amuletAbilityTexts;
		[SerializeField]
		private Image[] amuletAbilityIcons;
		[SerializeField]
		private UnityEngine.UI.Text amuletDurationText;
		[SerializeField]
		private Button exchangeButton;
		[SerializeField]
		private GameObject[] rarityObjs;
		[SerializeField]
		private GameObject limitBreakInfo;
		[SerializeField]
		private UnityEngine.UI.Text exchangeConditionText;
		[SerializeField]
		private GameObject newIcon;
		[SerializeField]
		private GameObject memoryTitle;
		[SerializeField]
		private Image recommendedRibbon;
		[CompilerGenerated]
		private ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData _data_k__BackingField;
	
		// Properties
		public ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData data { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public ShopTableViewTradeAmuletCell();
	
		// Methods
		public override void UpdateContent(ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData data);
		public void SwitchContent();
		public void UpdateNewIcon();
		private void SetAbility(int abilityId, ElementalType elementType, Image icon, UnityEngine.UI.Text abilityName);
		public void OnExchangeButtonPressed();
		public void OnIconTouched();
	}
}
