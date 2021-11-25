using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class CraftTargetSelectMainCanvas : CraftEffectMainCanvas
	{
		public CraftTargetSelectListController craftSelectListController;

		public WeaponEvolutionSelectListController evolutionSelectListController;

		public static WeaponType selectWeaponTab;

		public UnityAction<WeaponType> changeTypeCallBack;

		public TabBase listTab;

		public Transform craftListBase;

		public Transform evolutionListBase;

		public bool isEvolutionListShowAll;

		public UnityAction<bool> showAllButtonCallBack;

		public UnityAction dismantleButtonCallBack;

		public Text dismantleButtonText;

		public Button[] weaponTabs;

		public Transform[] weaponTabOnImages;

		public Text infoChangeButtonText;

		public Button changeInfoListButton;

		public bool isShowRootInfo;

		protected override void Start()
		{
		}

		public void ChangeWeaponTab(int index)
		{
		}

		public void OnShowAllButtonPressed()
		{
		}

		public void OnDismantleWeaponButtonPressed()
		{
		}

		public void OnChangeInfoButtonPressed()
		{
		}
	}
}
