/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FacilityStoreHouseCell : FacilityCellBase
	{
		// Fields
		[CompilerGenerated]
		private StoreHouse.StoreHouseFacility _storeHouseFacility_k__BackingField;
		private static readonly int GRID_UNIT_SIZE;
		[SerializeField]
		private Image iconImage;
		[SerializeField]
		private Image gridImage;
		[SerializeField]
		private UnityEngine.UI.Text nameLabel;
		[SerializeField]
		private UnityEngine.UI.Text levelLabel;
		[SerializeField]
		private UnityEngine.UI.Text buildButtonLabel;
		[SerializeField]
		private UnityEngine.UI.Text countLabel;
		[SerializeField]
		private UnityEngine.UI.Text countTitle;
		private RectTransform gridRectTransformCache;
		private buildButtonPressedDelegate buildButtonPressedCallbacks;
	
		// Properties
		public StoreHouse.StoreHouseFacility storeHouseFacility { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public delegate void buildButtonPressedDelegate(Facility facility);
	
		// Constructors
		public FacilityStoreHouseCell();
		static FacilityStoreHouseCell();
	
		// Methods
		public void AddBuildButtonPressedCallback(buildButtonPressedDelegate callback);
		private void Awake();
		public void OnBuildButtonPressed();
		public void SetContent(StoreHouse.StoreHouseFacility storedFacility);
		public override bool IsNew();
		public override List<Facility> GetNewFacilityList();
	}
}
