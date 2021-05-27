/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ManagedFacilityController : FacilityContentBase
	{
		// Fields
		[Header]
		[SerializeField]
		private FortMenuGroupType facilityGroup;
		[SerializeField]
		private RectTransform originalCellPrefab;
		[SerializeField]
		private ManagedFacilityDialogController dialogController;
		[SerializeField]
		private UnityEngine.UI.Text noItemText;
		[CompilerGenerated]
		private List<ManagedFacilityModel.ManagedFacility> _managedFacilityList_k__BackingField;
		[CompilerGenerated]
		private List<ManagedFacilityModel.ManagedFacility> _sortedManagedFacilityList_k__BackingField;
		[CompilerGenerated]
		private bool _existUpgradeableFacility_k__BackingField;
		private bool finishInitialize;
	
		// Properties
		public List<ManagedFacilityModel.ManagedFacility> managedFacilityList { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<ManagedFacilityModel.ManagedFacility> sortedManagedFacilityList { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool existUpgradeableFacility { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public ManagedFacilityCell cell;
			public ManagedFacilityController __4__this;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _UpdateContents_b__0(Facility facility);
			internal void _UpdateContents_b__1(Facility facility);
		}
	
		// Constructors
		public ManagedFacilityController();
	
		// Methods
		private void Start();
		protected new void OnEnable();
		public override void SetNewFlagToFalse();
		public void UpdateContents();
		public void UpdateData(List<ManagedFacilityModel.ManagedFacility> cellDataList);
		public FacilitySortModel.Preset GetPreset();
		[CompilerGenerated]
		private void _SetNewFlagToFalse_b__19_0(UpdateResetNewResponse response);
	}
}
