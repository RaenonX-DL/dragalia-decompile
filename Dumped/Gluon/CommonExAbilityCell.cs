using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonExAbilityCell : MonoBehaviour
	{
		public Image exAbilityIconImage;

		public Text exAbilityNameText;

		private int exAbilityId;

		private int exAbilityLevel;

		private bool isWeaponExAbility;

		public void SetupCell(CharaDataElement masterCharaData, bool isWeaponExAbility, int exAbilityLevel)
		{
		}

		public void SetupCell(int exAbilityId, bool isWeaponExAbility, int exAbilityLevel)
		{
		}

		public void OnExAbilityCellPressed()
		{
		}
	}
}
