using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BuildDialogController : PopupBase
	{
		public TabViewBase tabView;

		[SerializeField]
		private Text dialogTextTitle;

		[SerializeField]
		private Button closeButton;

		private FortScene fortScene;

		private List<FacilitySelectCtrl> facilitySelectCtrlList;

		private static List<string> buildFacilityTabNameList;

		private void Awake()
		{
		}

		protected override void Start()
		{
		}

		public void OnCloseButtonTouched()
		{
		}

		public void OnFalicitySelectCofirm(Facility facility, FortModel.BuildFacilityResult buildResult)
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
