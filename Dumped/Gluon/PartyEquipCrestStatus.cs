using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class PartyEquipCrestStatus : MonoBehaviour
	{
		[SerializeField]
		private GameObject emptyObject;

		[SerializeField]
		private GameObject rootObject;

		[SerializeField]
		private PartyEquipStatusIconBar[] unionBonusBars;

		private List<KeyValuePair<UnionAbilityElement, AbilityDataElement>> unionBonusList;

		private int charaId;

		public void Setup(int charaId, int[] crestIds)
		{
		}

		public void OnIconPressed(int index)
		{
		}
	}
}
