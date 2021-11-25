using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class UnitExAbilityPage : MonoBehaviour
	{
		public List<UnitDetailAbilityInfoCell> exAbilityCell;

		[HideInInspector]
		public UnitDetailCanvas parentCanvas;

		public void SetupExAbilityPage(UnitDetailModel.UnitDetailType type)
		{
		}

		private void SetExAbilityInfo()
		{
		}
	}
}
