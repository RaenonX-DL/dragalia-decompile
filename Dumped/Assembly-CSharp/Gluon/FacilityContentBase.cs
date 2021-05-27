/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FacilityContentBase : TabContentBase
	{
		// Fields
		[SerializeField]
		public GameObject tabBadgeObject;
		[SerializeField]
		protected Transform contentParent;
		protected List<FacilityCellBase> cells;
		public bool hasNewFacility;
		public List<Facility> newFacilities;
	
		// Constructors
		public FacilityContentBase();
	
		// Methods
		protected virtual void OnInit();
		protected void OnEnable();
		private void SortCells();
		private void SwapCell(int index1, int index2);
		protected void UpdateBadges();
		public virtual void SetNewFlagToFalse();
	}
}
