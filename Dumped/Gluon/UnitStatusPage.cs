using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class UnitStatusPage : MonoBehaviour
	{
		[SerializeField]
		[Header("Title")]
		private Text statusPageTitle;

		[SerializeField]
		[Header("Params")]
		public Text hpParam;

		[SerializeField]
		private Text hpPlusParam;

		[SerializeField]
		private Text hpAndPlusParam;

		public Text atkParam;

		[SerializeField]
		private Text atkPlusParam;

		[SerializeField]
		private Text atkAndPlusParam;

		public Text defParam;

		public Text powerParam;

		[SerializeField]
		private GameObject[] separateValueObj;

		[SerializeField]
		private GameObject[] sumValueObj;

		[SerializeField]
		private Button paramSwitchButton;

		[SerializeField]
		[Header("æ\u0089\u0080æ\u009c\u0089ç\u0089©")]
		private GameObject possessionNode;

		[SerializeField]
		private Text possessionText;

		[SerializeField]
		[Header("ã\u0083¦ã\u0083\u008bã\u0082ªã\u0083³")]
		private GameObject unionNode;

		[SerializeField]
		private Image[] unionImage;

		[SerializeField]
		private Text unionNothing;

		[SerializeField]
		[Header("ã\u0082¹ã\u0083­ã\u0083\u0083ã\u0083\u0088")]
		private GameObject slotNode;

		[SerializeField]
		private Image[] slotImage;

		[SerializeField]
		[Header("ã\u0082²ã\u0083¼ã\u0082\u00b8")]
		private GameObject gaugeNode;

		[SerializeField]
		[Header("ã\u0083¬ã\u0083\u0099ã\u0083«")]
		private GameObject levelNode;

		[SerializeField]
		[Header("CharaType")]
		public CharaTypeUI charaType;

		[SerializeField]
		[Header("DetailButton")]
		public GameObject detailButtonBase;

		public UnityAction statusDetailCallBack;

		[SerializeField]
		[Header("Level")]
		public Text levelText;

		public Text expText;

		public Slider expGauge;

		public GameObject fullGageFill;

		public Button expChangeButton;

		[SerializeField]
		[Header("LimitBreak")]
		public GameObject limitBase;

		public GameObject[] limitParentImages;

		public GameObject[] limitOnImages;

		public GameObject[] limitMaxImages;

		[SerializeField]
		[Header("Mana")]
		public Image manaStar;

		public Text manaCountText;

		[SerializeField]
		[Header("ShareSkill")]
		public GameObject shareSkillCostObj;

		public Text shareSkillCostText;

		[SerializeField]
		public Image weaponSkinIcon;

		[HideInInspector]
		public UnitDetailCanvas parentCanvas;

		private UnitDetailModel.UnitDetailType unitType;

		private bool isShowNextLv;

		private bool isParamSwitch;

		[SerializeField]
		private GameObject modeIconParent;

		[SerializeField]
		private Image[] modeIconImage;

		private Color grayout;

		public void SetupStatusPage(UnitDetailModel.UnitDetailType type)
		{
		}

		private void SetupCommonInfo()
		{
		}

		public void ExpInfoChangeButtonPressed()
		{
		}

		private void SetNextLevelGauge()
		{
		}

		public void StatusDetailButtonPressed()
		{
		}

		private void SetStatusInfo()
		{
		}

		private void SetGunModeIcon(Image image, int modeId)
		{
		}

		public void OnParamSwitchButton()
		{
		}
	}
}
