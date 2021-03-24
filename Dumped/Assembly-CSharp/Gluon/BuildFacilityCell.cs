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
	public class BuildFacilityCell : FacilityCellBase
	{
		// Fields
		private static readonly int GRID_UNIT_SIZE;
		[SerializeField]
		private Image iconImage;
		[SerializeField]
		private Image gridImage;
		[SerializeField]
		private UnityEngine.UI.Text nameLabel;
		[SerializeField]
		private UnityEngine.UI.Text countLabel;
		[SerializeField]
		private Button buildButton;
		[SerializeField]
		private Button detailButton;
		[SerializeField]
		private GameObject disableNode;
		[SerializeField]
		private UnityEngine.UI.Text disableDescription;
		[SerializeField]
		private UnityEngine.UI.Text coutTitle;
		private RectTransform gridRectTransformCache;
		public int currentCount;
		public int maxCout;
		private FortModel.BuildFacilityResult buildResult;
		private buildButtonPressedDelegate buildButtonPressedCallbacks;
		private detailButtonPressedDelegate _detailButtonPressedCallbacks;
	
		// Properties
		public detailButtonPressedDelegate detailButtonPressedCallbacks { get; set; }
	
		// Nested types
		public delegate void buildButtonPressedDelegate(Facility facility, FortModel.BuildFacilityResult buildResult);
	
		public delegate void detailButtonPressedDelegate(Facility facility, FortModel.BuildFacilityResult buildResult);
	
		// Constructors
		public BuildFacilityCell();
		static BuildFacilityCell();
	
		// Methods
		public void AddBuildButtonPressedCallback(buildButtonPressedDelegate callback);
		private void Awake();
		public void OnBuildButtonPressed();
		public void OnDetailButtonPressed();
		public void SetEnable(bool enable);
		public void SetCellContent(FacilitySelectCtrl.FacilityBuildingData plantData);
		public override bool IsNew();
		public override List<Facility> GetNewFacilityList();
	}
}
