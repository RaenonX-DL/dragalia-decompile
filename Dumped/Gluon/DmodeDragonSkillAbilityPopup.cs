using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DmodeDragonSkillAbilityPopup : PopupBase
	{
		private static readonly string prefabPath;

		[SerializeField]
		[Header("Contents")]
		private Text nameText;

		[SerializeField]
		private DmodeItemDetailInfoBaseCell skillCell;

		[SerializeField]
		private DmodeItemDetailInfoBaseCell abilityCell;

		public static DmodeDragonSkillAbilityPopup Create(int id, ElementalType elementalType = ElementalType.NOELEMENT)
		{
			return null;
		}

		private void Initialize(int id, ElementalType elementalType)
		{
		}
	}
}
