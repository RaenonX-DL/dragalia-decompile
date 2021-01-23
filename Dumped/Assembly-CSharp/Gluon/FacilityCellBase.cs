/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FacilityCellBase : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		protected GameObject iconNew;
		[CompilerGenerated]
		private Facility _facility_k__BackingField;
	
		// Properties
		public Facility facility { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public FacilityCellBase();
	
		// Methods
		public void SetNewIcon(bool isNew);
		public virtual bool IsNew();
		public virtual List<Facility> GetNewFacilityList();
	}
}
