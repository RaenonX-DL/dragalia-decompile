using Gluon.Http;

namespace Gluon
{
	public class CraftStepupSendData
	{
		public int targetWeaponId;

		public int quantity;

		public bool isLimitBreak;

		public AtgenWeaponSetList[] weaponSetDatas;

		public static AtgenWeaponSetList[] ConvertMaterialWeaponCellDataToCraftSendData(int tragetWeaponId, int quantity, CraftMaterialCellData[] craftMaterialCellDatas)
		{
			return null;
		}

		public static AtgenWeaponSetList[] ConvertMaterialWeaponCellDataToGradeupSendData(int targetWeaponId, CraftMaterialCellData[] craftMaterialCellDatas)
		{
			return null;
		}
	}
}
