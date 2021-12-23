using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BootyInfoUI : BootyInfoUIBase
	{
		[SerializeField]
		[Header("component")]
		private RectTransform sackIconRt;

		[SerializeField]
		private RectTransform weaponIconRt;

		[SerializeField]
		private RectTransform amuletInfoRt;

		[SerializeField]
		private RectTransform manaInfoRt;

		[SerializeField]
		private RectTransform coinInfoRt;

		[SerializeField]
		private Text sackText;

		[SerializeField]
		private Text weaponText;

		[SerializeField]
		private Text amuletText;

		[SerializeField]
		private Text manaText;

		[SerializeField]
		private Text coinText;

		private const int displaySackMaxNum = 99;

		private const int displayWeaponMaxNum = 99;

		private const int displayAmuletMaxNum = 99;

		private const int displayManaMaxNum = 999999;

		private const int displayCoinMaxNum = 999999;

		public static BootyInfoUI Create(GameObject parent)
		{
			return null;
		}

		protected override void Initialize()
		{
		}

		public override void SetSack(int val)
		{
		}

		public override void SetWeapon(int val)
		{
		}

		public override void SetAmulet(int val)
		{
		}

		public override void SetMana(int val)
		{
		}

		public override void SetCoin(int val)
		{
		}

		public override Vector3 GetPositionSackIcon()
		{
			return default(Vector3);
		}

		public override Vector3 GetPositionWeaponIcon()
		{
			return default(Vector3);
		}

		public override Vector3 GetPositionAmuletIcon()
		{
			return default(Vector3);
		}

		public override Vector3 GetPositionManaIcon()
		{
			return default(Vector3);
		}

		public override Vector3 GetPositionCoinIcon()
		{
			return default(Vector3);
		}
	}
}
