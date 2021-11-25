using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthWeaponUpdateSkillResultPopup : CommonPopup
	{
		public Text messageText;

		public Transform cellParentTransform;

		private GrowthUnitEnhanceModel model;

		private const string cellPrefabPath = "Prefabs/OutGame/Growth/GrowthUnitEnhance/GrowthUnitEnhanceSkillAbilityInfoCell";

		public static GrowthWeaponUpdateSkillResultPopup Create()
		{
			return null;
		}

		public void InitPopup(GrowthUnitEnhanceModel model, BitArray diffParam)
		{
		}

		private void AddSkillInfo()
		{
		}

		private void AddAbilityInfo(int abilityNo)
		{
		}
	}
}
