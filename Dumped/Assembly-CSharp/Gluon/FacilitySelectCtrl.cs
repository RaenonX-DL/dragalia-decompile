/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FacilitySelectCtrl : FacilityContentBase
	{
		// Fields
		[Header]
		[SerializeField]
		public FortMenuGroupType facilityGroup;
		[SerializeField]
		protected RectTransform prefab;
		[SerializeField]
		protected GameObject dialogObj;
		private List<FacilityBuildingData> plantList;
	
		// Nested types
		public class FacilityBuildingData
		{
			// Fields
			public FortPlantDataElement plantElement;
			public Facility facility;
			public int currentCount;
			public int sortId;
			public FortModel.BuildFacilityResult canBuild;
	
			// Constructors
			public FacilityBuildingData();
		}
	
		// Constructors
		public FacilitySelectCtrl();
	
		// Methods
		private void Start();
		protected virtual void SetContent(FacilityBuildingData plantData, RectTransform cellObj);
		public override void SetNewFlagToFalse();
	}
}
