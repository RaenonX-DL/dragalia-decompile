using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CraftMaterialCell : MonoBehaviour
	{
		public Image materialIcon;

		public Text needCount;

		public Text nowCount;

		public Text haveText;

		public Text xText;

		public Image[] errorImage;

		public UnityAction<CraftMaterialCellData> materialPressedCallBack;

		public Transform plusTransform;

		public Badge alertBadgeIcon;

		public GameObject alertBadgeObj;

		public GameObject baseIconObj;

		private CraftMaterialCellData cellData;

		private int needCountBase;

		[SerializeField]
		private Image tradeImage;

		private bool isDismantleWeapon;

		public bool isMaterialSetupComplete => default(bool);

		private void Awake()
		{
		}

		public CraftMaterialCellData InitMaterialCell(GiftType type, int materialId, int needCnt, bool isDismantleWeapon = false)
		{
			return null;
		}

		public CraftMaterialCellData InitWeaponMaterialCell(int weaponSetId, int needCnt)
		{
			return null;
		}

		public void InitWeaponMaterialCell(CraftMaterialCellData cellData, int defaultNeedCount)
		{
		}

		private void SetError(bool isError)
		{
		}

		public void OnMaterialIconPressed()
		{
		}

		public void UpdateCell()
		{
		}

		private void UpdateTradeIcon(int nowCnt, int needCnt)
		{
		}

		public void UpDateNeedCount(int craftCount)
		{
		}
	}
}
