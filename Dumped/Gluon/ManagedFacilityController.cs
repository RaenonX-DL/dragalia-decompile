using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class ManagedFacilityController : FacilityContentBase
	{
		[SerializeField]
		[Header("æ\u0096½è\u00a8­Group")]
		private FortMenuGroupType facilityGroup;

		[SerializeField]
		private RectTransform originalCellPrefab;

		[SerializeField]
		private ManagedFacilityDialogController dialogController;

		[SerializeField]
		private Text noItemText;

		private bool finishInitialize;

		public List<ManagedFacilityModel.ManagedFacility> managedFacilityList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<ManagedFacilityModel.ManagedFacility> sortedManagedFacilityList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool existUpgradeableFacility
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Start()
		{
		}

		protected new void OnEnable()
		{
		}

		public override void SetNewFlagToFalse()
		{
		}

		public void UpdateContents()
		{
		}

		public void UpdateData(List<ManagedFacilityModel.ManagedFacility> cellDataList)
		{
		}

		public FacilitySortModel.Preset GetPreset()
		{
			return default(FacilitySortModel.Preset);
		}
	}
}
