using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class FacilitySelectCtrl : FacilityContentBase
	{
		public class FacilityBuildingData
		{
			public FortPlantDataElement plantElement;

			public Facility facility;

			public int currentCount;

			public int sortId;

			public FortModel.BuildFacilityResult canBuild;
		}

		[SerializeField]
		[Header("æ\u0096½è\u00a8­Group")]
		public FortMenuGroupType facilityGroup;

		[SerializeField]
		protected RectTransform prefab;

		[SerializeField]
		protected GameObject dialogObj;

		private List<FacilityBuildingData> plantList;

		private void Start()
		{
		}

		protected virtual void SetContent(FacilityBuildingData plantData, RectTransform cellObj)
		{
		}

		public override void SetNewFlagToFalse()
		{
		}
	}
}
