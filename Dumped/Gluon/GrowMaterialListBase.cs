using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowMaterialListBase : CommonIconListBase
	{
		[SerializeField]
		[Header("GrowMaterialListBase")]
		public TabBase tab;

		public Button autoSelectButton;

		public Button manaButton;

		public Button growButton;

		public Button platinumButton;

		public Text noItemMaterialMessage;

		public Text[] unitMaterialTypeText;

		public UnitMaterialListController unitMaterialListController;

		public ItemMaterialListController itemMaterialListController;

		public UnityAction growPressedCallback;

		public UnityAction selectConfigCallback;

		public UnityAction autoSelectCallback;

		public UnityAction manaPressedCallback;

		public UnityAction tabButtonCallBack;

		public UnityAction platinumCrystalPressedCallback;

		public GameObject effectBlackObj;

		public bool isReleasePlusParam;

		[SerializeField]
		private Text materialText;

		[SerializeField]
		private Text autoText;

		[SerializeField]
		private Text manaText;

		[SerializeField]
		private Text grothText;

		[SerializeField]
		private Text[] itemTexts;

		[SerializeField]
		private GameObject platinumCrystal;

		[SerializeField]
		private Text platinumCrystalCountText;

		[SerializeField]
		private Image usePlatinumCrystalButtonImage;

		[SerializeField]
		private Sprite spriteUsePlatinumCrystal1;

		[SerializeField]
		private Sprite spriteUsePlatinumCrystal2;

		public UseMaterialType materialType
		{
			[CompilerGenerated]
			get
			{
				return default(UseMaterialType);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override void Awake()
		{
		}

		private void Start()
		{
		}

		public void ListTabPressedZeroToOne(int index)
		{
		}

		public void ListTabPressed(int tabTag)
		{
		}

		public override void SetupCountText(int nowCount, int maxCount)
		{
		}

		public void AutoButtonPressed()
		{
		}

		public void GrowButtonPressed()
		{
		}

		public void ManaButtonPressed()
		{
		}

		public void SetEnableGrowButton(bool isEnable)
		{
		}

		public void UpdatePlatinumCrystalState(GrowthBaseType growthBaseType, ulong growBaseKeyId, GrowthManaCircleManaCircleData circleData)
		{
		}

		public void OnPlatinumCrystalPressed()
		{
		}
	}
}
