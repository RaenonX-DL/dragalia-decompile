using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class FortDetailCell : MonoBehaviour
	{
		[SerializeField]
		private Image icon;

		[SerializeField]
		private Text facilityName;

		[SerializeField]
		private FacilityDialogContent facilityDialogContent;

		public void SetContentProduction(AtgenProductionRp production, MaterialHarvester.HarvestType type)
		{
		}

		public void SetContentWeapon(AtgenParamBonus weaponParam)
		{
		}

		public void SetContentElement(AtgenElementBonus elementParam)
		{
		}

		public void SetContentAllBonus(AtgenAllBonus allBonus)
		{
		}

		public void SetContentDragonBoost(AtgenDragonBonus dragonBoost, bool isSetAllPrameters = false)
		{
		}

		public void SetContentDragonBoostTime(AtgenDragonTimeBonus dragonBoostTime)
		{
		}

		private void LoadIconPrefab(string path)
		{
		}
	}
}
