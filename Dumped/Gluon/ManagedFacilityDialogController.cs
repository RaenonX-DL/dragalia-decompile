using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class ManagedFacilityDialogController : PopupBase
	{
		public enum ExecutedFacilityAction
		{
			Store,
			LevelUp,
			CompleteBuilding,
			ExchangeMaterial,
			UpdsateWorkableSmith
		}

		[SerializeField]
		private TabViewBase tabView;

		[SerializeField]
		private Transform sortParentTransform;

		private List<ManagedFacilityController> managedFacilityCtrlList;

		private CommonSortButton sortButton;

		private FlashPlayer managedFacilityFlashPlayer;

		private ManagedFacilityCell selectedCell;

		private PopupCanvas popupCanvasComponent;

		private static List<string> managedFacilityTabNameList;

		public Canvas canvas
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public GameObject fortRoot
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void OnSortButtonClicked()
		{
		}

		public void OnCloseButtonPressd()
		{
		}

		public void SetActiveSortButton(bool isActive)
		{
		}

		private void SetManagedFacilityFlashPlayer(string flashPath, Transform target)
		{
		}

		private void UpdateSortAndFilter(int tabIndex)
		{
		}

		public void StoreFacility(Facility facility)
		{
		}

		public void LevelUpFacility(Facility currentFacility)
		{
		}

		public void CompleteAtOnceFacility(Facility facility)
		{
		}

		public void ShowFacilityInformation(Facility facility)
		{
		}

		public void SetSelectedCell(ManagedFacilityCell selectedCell)
		{
		}

		public void OnFalicitySelectCofirm(Facility facility)
		{
		}

		public void UpdateCurrentContents(ExecutedFacilityAction executedFacilityAction)
		{
		}

		public static void ResetTabSetting()
		{
		}

		private void RegisterTabNameList()
		{
		}
	}
}
