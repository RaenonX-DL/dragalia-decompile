using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyEquipOverPopup : CommonPopup
	{
		[SerializeField]
		private List<Image> charaIconList;

		[SerializeField]
		private List<Image> selectedImageList;

		[SerializeField]
		private Image targetIcon;

		[SerializeField]
		private Text targetName;

		[SerializeField]
		private Image targetCharaIcon;

		private int selectedIndex;

		private List<int> charaIdList;

		public static PartyEquipOverPopup Create()
		{
			return null;
		}

		public void SetupForWeapon(List<int> charaIdList, int targetWeaponId, int targetCharaId = 0)
		{
		}

		public void SetupForCrest(List<int> charaIdList, int targetCrestId, int targetCharaId = 0)
		{
		}

		private void Setup(List<int> charaIdList, int targetCharaId)
		{
		}

		public void SelectIcon(int index)
		{
		}

		public int GetSelectedCharaId()
		{
			return default(int);
		}

		private void SetTargetUnitInfo(GiftType type, int unitId)
		{
		}
	}
}
