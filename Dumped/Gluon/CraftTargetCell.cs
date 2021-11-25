using System.Collections;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CraftTargetCell : TableViewCell<CraftTargetSelectCellData>
	{
		public Image newIcon;

		public Image weaponIcon;

		public Image eventIcon;

		public Image skillIcon;

		public Image[] abilityIcons;

		public Image craftButtonImage;

		public Image specialCraftButtonImage;

		public Image treeButtonImage;

		public Text weaponName;

		public Text needLevelText;

		public Text needLevelTextOnBlink;

		public Text possessionCount;

		public Text hpParam;

		public Text atkParam;

		public Sprite craftButtonSprite;

		public Sprite emptyMaterialSprite;

		public UnityAction<int> craftCallBack;

		public UnityAction<int> treeCallBack;

		public Text craftButtonText;

		public Text specialCraftButtonText;

		public Text treeButtonText;

		public CanvasGroup skillAbilityRootGroup;

		public GameObject skillBase;

		public GameObject abilityBase;

		public GameObject needLevelTextBase;

		public Text hpParamText;

		public Text atkParamText;

		public Text plusParam;

		public GameObject sortDecoAttachNode;

		public CraftTargetSelectListController listController;

		public Animator blinkAnimator;

		public CanvasGroup skillAbilityInfoBaseGroup;

		public CanvasGroup needLevelTextGroupOnBlink;

		public Transform skillAbilityInfoBaseParent;

		public Transform skillAbilityInfoBaseParentOnBlink;

		[SerializeField]
		private Transform craftBaseTransform;

		[SerializeField]
		private Transform rootBaseTransform;

		[SerializeField]
		private Image[] abilityIcon;

		[SerializeField]
		private Text[] abilityName;

		[SerializeField]
		private GameObject[] abilityTextBase;

		[SerializeField]
		private Image[] elementIcon;

		[SerializeField]
		private Toggle[] elementToggles;

		private int[] rootIds;

		[SerializeField]
		private Text seriesLabel;

		[SerializeField]
		private GameObject labelBaseObj;

		[SerializeField]
		private GameObject infoBaseObj;

		[SerializeField]
		private Image voidWeaponEnemyIcon;

		[SerializeField]
		private Image hgCraftBgImage;

		[SerializeField]
		private Text hgCraftName;

		[SerializeField]
		private Text hgCraftPosCount;

		[SerializeField]
		private Text hgCraftNeedWeaponText;

		private int targetId;

		private int skillLv;

		private WeaponDataElement weaponData;

		private int statusHpPlusCount;

		private int statusAtkPlusCount;

		private RectTransform[] skillRects;

		private RectTransform[] abilityRects;

		private CraftTargetSelectCellData targetData;

		protected override void Awake()
		{
		}

		public override void UpdateContent(CraftTargetSelectCellData data)
		{
		}

		private void SetupSpecialCraftInfo(CraftTargetSelectCellData data)
		{
		}

		private void SetupCraftInfo(CraftTargetSelectCellData data)
		{
		}

		private void SetupRootInfo(CraftTargetSelectCellData data)
		{
		}

		private void SetupRootInfoCellUI(int weaponId)
		{
		}

		public void OnCraftButtonPressed()
		{
		}

		public void OnTreeButtonPressed()
		{
		}

		public void OnIconButtonPressed()
		{
		}

		public void OnSkillButtonPressed()
		{
		}

		public void OnAbilityButtonPressed(int intex)
		{
		}

		private Vector2 GetScaleFromVisible(bool visible)
		{
			return default(Vector2);
		}

		private IEnumerator WaitMoment(UnityAction callback)
		{
			return null;
		}

		public void OnElementTogglePressed(bool isOn)
		{
		}

		private void UpdateCraftButton(ref Image buttonImage, ref Text buttonText, bool isCraft)
		{
		}
	}
}
