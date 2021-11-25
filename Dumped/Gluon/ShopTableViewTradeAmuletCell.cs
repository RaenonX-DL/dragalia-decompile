using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopTableViewTradeAmuletCell : TableViewCell<ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData>
	{
		[SerializeField]
		private CommonIcon amuletImage;

		[SerializeField]
		private Text amuletNameText;

		[SerializeField]
		private Text[] amuletAbilityTexts;

		[SerializeField]
		private Image[] amuletAbilityIcons;

		[SerializeField]
		private Text amuletDurationText;

		[SerializeField]
		private Button exchangeButton;

		[SerializeField]
		private GameObject[] rarityObjs;

		[SerializeField]
		private GameObject limitBreakInfo;

		[SerializeField]
		private Text exchangeConditionText;

		[SerializeField]
		private GameObject newIcon;

		[SerializeField]
		private GameObject memoryTitle;

		[SerializeField]
		private Image recommendedRibbon;

		public ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData data
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override void UpdateContent(ShopTableViewTradeAmuletCtrl.ShopTableViewTradeAmuletData data)
		{
		}

		public void SwitchContent()
		{
		}

		public void UpdateNewIcon()
		{
		}

		private void SetAbility(int abilityId, ElementalType elementType, Image icon, Text abilityName)
		{
		}

		public void OnExchangeButtonPressed()
		{
		}

		public void OnIconTouched()
		{
		}
	}
}
