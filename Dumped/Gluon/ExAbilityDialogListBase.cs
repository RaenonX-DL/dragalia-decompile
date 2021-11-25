using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	[Serializable]
	public class ExAbilityDialogListBase : MonoBehaviour
	{
		public Image charaIcon;

		public Image blackBase;

		public CommonExAbilityCell[] exAbilityCells;

		public Text notLearnMessage;

		public Image[] duplicateCharaIcons;

		private void Start()
		{
		}

		public void SetupListBase(int charaId, int charaRarity)
		{
		}

		public void GrayOutListBase(List<CommonCharaExAbilityData.UnitData> abilityDuplicateUnit)
		{
		}
	}
}
