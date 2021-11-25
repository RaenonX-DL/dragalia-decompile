using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BuildFacilityCell : FacilityCellBase
	{
		public delegate void buildButtonPressedDelegate(Facility facility, FortModel.BuildFacilityResult buildResult);

		public delegate void detailButtonPressedDelegate(Facility facility, FortModel.BuildFacilityResult buildResult);

		private static readonly int GRID_UNIT_SIZE;

		[SerializeField]
		private Image iconImage;

		[SerializeField]
		private Image gridImage;

		[SerializeField]
		private Text nameLabel;

		[SerializeField]
		private Text countLabel;

		[SerializeField]
		private Button buildButton;

		[SerializeField]
		private Button detailButton;

		[SerializeField]
		private GameObject disableNode;

		[SerializeField]
		private Text disableDescription;

		[SerializeField]
		private Text coutTitle;

		private RectTransform gridRectTransformCache;

		public int currentCount;

		public int maxCout;

		private FortModel.BuildFacilityResult buildResult;

		private buildButtonPressedDelegate buildButtonPressedCallbacks;

		private detailButtonPressedDelegate _detailButtonPressedCallbacks;

		public detailButtonPressedDelegate detailButtonPressedCallbacks
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void AddBuildButtonPressedCallback(buildButtonPressedDelegate callback)
		{
		}

		private void Awake()
		{
		}

		public void OnBuildButtonPressed()
		{
		}

		public void OnDetailButtonPressed()
		{
		}

		public void SetEnable(bool enable)
		{
		}

		public void SetCellContent(FacilitySelectCtrl.FacilityBuildingData plantData)
		{
		}

		public override bool IsNew()
		{
			return default(bool);
		}

		public override List<Facility> GetNewFacilityList()
		{
			return null;
		}
	}
}
