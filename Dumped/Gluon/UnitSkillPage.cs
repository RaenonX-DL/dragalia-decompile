using UnityEngine;

namespace Gluon
{
	public class UnitSkillPage : MonoBehaviour
	{
		[SerializeField]
		[Header("Cells")]
		public UnitDetailSkillInfoCell[] skillCellList;

		[HideInInspector]
		public UnitDetailCanvas parentCanvas;

		private UnitDetailModel.UnitDetailType unitType;

		public void SetupSkillPage(UnitDetailModel.UnitDetailType type)
		{
		}

		private void SetSkillInfo()
		{
		}
	}
}
