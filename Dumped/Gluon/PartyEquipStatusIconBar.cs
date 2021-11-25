using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Gluon
{
	public class PartyEquipStatusIconBar : MonoBehaviour
	{
		public Image charaBase;

		public Image amuletBase;

		public Image dragonBase;

		public Image weaponBase;

		public Image skillBase;

		public Text nameText;

		public Image icon;

		[FormerlySerializedAs("rockIcon")]
		public Image lockIcon;

		[FormerlySerializedAs("rockIconImage")]
		public Image lockIconImage;

		public Image notUseImage;

		public GameObject skinIconObj;

		public void SetBaseImage(PartyEquipSkillAbilityData.AbilityType type)
		{
		}
	}
}
