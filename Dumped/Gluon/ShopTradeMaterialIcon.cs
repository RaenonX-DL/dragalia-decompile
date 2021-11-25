using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ShopTradeMaterialIcon : MonoBehaviour
	{
		[SerializeField]
		public CommonIcon icon;

		public Text useCount;

		public Image bottomCountPlate;

		[SerializeField]
		[Header("Amulet")]
		public GameObject amuletDeco;

		public GameObject amuletCover;

		[SerializeField]
		[Header("OnOffs")]
		public GameObject countMask;

		[SerializeField]
		[Header("ä\u00b8\u008aé\u0099\u0090è§£æ\u0094¾ã\u0081®ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8")]
		private Image[] limitBreakImages;

		private Text[] displayTextList;

		private Color insufficientCountColor;

		private Color insufficientCountPlateColor;

		private Color insufficientCountPlateColorBottom;

		private Color normalCountPlateColorBottom;

		private Color normalCountColor;

		private Color normalPlateColor;

		private static readonly int needOmitDigitsCounts;

		private void Awake()
		{
		}

		public void SetMaterial(int id, int useCount, GiftType giftType = GiftType.MATERIAL, int limitBreakCount = 0, ulong keyId = 0uL, bool shouldTurnInsufficient = false)
		{
		}

		public void SetMaterialUseCount(int useCount, bool isSufficient)
		{
		}

		private void SetLimitBreakImage(int limitBreakCount)
		{
		}
	}
}
