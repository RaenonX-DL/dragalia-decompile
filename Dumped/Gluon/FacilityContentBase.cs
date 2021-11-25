using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class FacilityContentBase : TabContentBase
	{
		[SerializeField]
		public GameObject tabBadgeObject;

		[SerializeField]
		protected Transform contentParent;

		protected List<FacilityCellBase> cells;

		public bool hasNewFacility;

		public List<Facility> newFacilities;

		protected virtual void OnInit()
		{
		}

		protected void OnEnable()
		{
		}

		private void SortCells()
		{
		}

		private void SwapCell(int index1, int index2)
		{
		}

		protected void UpdateBadges()
		{
		}

		public virtual void SetNewFlagToFalse()
		{
		}
	}
}
