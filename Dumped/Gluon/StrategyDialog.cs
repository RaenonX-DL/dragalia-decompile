using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StrategyDialog : StrategyDialogBase
	{
		public enum ItemType
		{
			Sack_N,
			Sack_R,
			Weapon_N,
			Weapon_R,
			Amulet_N,
			Amulet_R,
			Max
		}

		public enum ExConditionType
		{
			Continue,
			Reborn,
			PartySwitch
		}

		[SerializeField]
		[Header("components")]
		private RectTransform infoRt;

		[SerializeField]
		private RectTransform infoDetailRt;

		[SerializeField]
		private RectTransform[] infoDetailItemRt;

		[SerializeField]
		private RectTransform missionRt;

		[SerializeField]
		private RectTransform missionDetailRt;

		[SerializeField]
		private RectTransform itemRt;

		[SerializeField]
		private RectTransform itemDetailRt;

		[SerializeField]
		private Image frameImage;

		[SerializeField]
		private Image[] elementImages;

		[SerializeField]
		private Sprite[] elementSprite;

		[SerializeField]
		private RectTransform buttonBaseRt;

		[SerializeField]
		[Tooltip("ã\u0082\u00afã\u0083ªã\u0082¢æ\u009d¡ä»¶ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text clearText;

		[SerializeField]
		[Tooltip("å¤±æ\u0095\u0097æ\u009d¡ä»¶ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text failureText;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aã\u0083«ã\u0083¼ã\u0083«ã\u0082¿ã\u0082¤ã\u0083\u0088ã\u0083«ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text exConditionTitleText;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aã\u0083«ã\u0083¼ã\u0083«è©³ç\u00b4°ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text exConditionDetailText;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aã\u0083«ã\u0083¼ã\u0083«2ã\u0082¿ã\u0082¤ã\u0083\u0088ã\u0083«ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text exCondition2TitleText;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aã\u0083«ã\u0083¼ã\u0083«2è©³ç\u00b4°ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text exCondition2DetailText;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aã\u0083«ã\u0083¼ã\u0083«2ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform exCondition2Rt;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aã\u0083«ã\u0083¼ã\u0083«3ã\u0082¿ã\u0082¤ã\u0083\u0088ã\u0083«ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text exCondition3TitleText;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aã\u0083«ã\u0083¼ã\u0083«3è©³ç\u00b4°ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text exCondition3DetailText;

		[SerializeField]
		[Tooltip("ç\u0089¹æ®\u008aã\u0083«ã\u0083¼ã\u0083«3ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform exCondition3Rt;

		[SerializeField]
		private Text[] missionText;

		[SerializeField]
		private Image[] missionIcon;

		[SerializeField]
		private Sprite missionIconOn;

		[SerializeField]
		private Sprite missionIconOff;

		[SerializeField]
		[Tooltip("ç\u008d²å¾\u0097ã\u0083\u009eã\u0083\u008aã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text manaText;

		[SerializeField]
		[Tooltip("ç\u008d²å¾\u0097ã\u0083«ã\u0083\u0094ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text coinText;

		[SerializeField]
		private Text[] itemText;

		[SerializeField]
		private Image[] itemImage;

		[SerializeField]
		[Header("parameter")]
		private Color32 selectedColor;

		[SerializeField]
		private float continueImpossibleMergin;

		[SerializeField]
		private float gameWallDetailOffsetY;

		[SerializeField]
		private float gameWallInfoDetailItemOffsetY;

		[SerializeField]
		private float gameWallItemOffsetY;

		[SerializeField]
		private float gameBRHeadOffsetY;

		[SerializeField]
		private float gameBRFrameOffsetY;

		[SerializeField]
		private float gameBRFrameOffsetH;

		[SerializeField]
		private float gameBRItemOffsetY;

		[SerializeField]
		private float gameBRButtonOffsetY;

		[SerializeField]
		[Tooltip("å±\u009eæ\u0080§ã\u0081\u008cè¤\u0087æ\u0095°ã\u0081\u0082ã\u0082\u008bå\u00a0\u00b4å\u0090\u0088ã\u0081®ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0081®é\u0096\u0093é\u009a\u0094")]
		private float elementIconOffset;

		private Vector3 orgHeadPos;

		private Vector3 orgFramePos;

		private Vector3 orgInfoPos;

		private Vector3 orgInfoDetailPos;

		private Vector3[] orgInfoDetailItemPos;

		private Vector3 orgMissionPos;

		private Vector3 orgMissionDetailPos;

		private Vector3 orgItemPos;

		private Vector3 orgItemDetailPos;

		private Vector3 orgButtonBasePos;

		private Vector3 orgRetryButtonPos;

		private float orgFrameHeight;

		private const int numKind = 2;

		private const int numElement = 6;

		private const int numStrategy = 4;

		private const int numMission = 3;

		private const int numItem = 6;

		public static StrategyDialog Create(GameObject parent)
		{
			return null;
		}

		protected override void Initialize()
		{
		}

		private void LoadEventSackMaterial(int type)
		{
		}

		public void Update()
		{
		}

		public override void Open()
		{
		}

		private void SetQuestElement(ElementalType elemental, ElementalType elemental2 = ElementalType.NONE)
		{
		}

		private void SetupLayout()
		{
		}

		private void UpdateItemCount(ref Text uiText, int count)
		{
		}

		private Sprite GetElementSprite(ElementalType type)
		{
			return null;
		}

		private string GetExConditionTitle(ExConditionType type)
		{
			return null;
		}

		public static string GetExConditionDetail(ExConditionType type, bool isStrategy)
		{
			return null;
		}
	}
}
