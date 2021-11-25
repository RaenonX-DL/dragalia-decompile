using System.Runtime.InteropServices;
using Gluon.Http;
using UnityEngine;

namespace Gluon
{
	public class FacilityDialogContent : MonoBehaviour
	{
		[SerializeField]
		private FacilityDialogContentItem item1;

		[SerializeField]
		private FacilityDialogContentItem item2;

		[SerializeField]
		private FacilityDialogContentItem item3;

		[SerializeField]
		private FacilityDialogContentItem itemDragonBoost;

		[SerializeField]
		private GameObject noItemSpacer;

		private const int productionSpeedNumberDigit = 4;

		public bool SetContent(Facility facility, [Optional] Facility nextLevelFacility)
		{
			return default(bool);
		}

		public void SetContentProduction(float maxTime, float max, bool isLevelUp = false, float nextLevelMaxTime = 0f, float nextLevelMax = 0f)
		{
		}

		public void SetContentProductionWithoutProduceMaxTime(float maxTime, float max, bool isLevelUp = false, float nextLevelMaxTime = 0f, float nextLevelMax = 0f)
		{
		}

		public void SetContentDragonFruits(float maxTime, float max, int appearLv, bool isLevelUp = false, float nextLevelMaxTime = 0f, float nextLevelMax = 0f, int nextAppearLv = 0)
		{
		}

		public void SetContentCharaBoost(bool isBoostAll, float hp, float attack, float defense, bool isLevelUp = false, float nextLevelHP = 0f, float nextLevelAttack = 0f, float nextLevelDefense = 0f)
		{
		}

		public void SetContentDragonBoost(float value, bool isLevelUp = false, float nextLevelValue = 0f)
		{
		}

		public void SetContentDragonBoostAllPrameters(AtgenDragonBonus dragonBoost)
		{
		}

		public void SetContentDragonBoostTime(float value, bool isLevelUp = false, float nextLevelValue = 0f)
		{
		}

		private string GetProduceMaxTimeText(float time)
		{
			return null;
		}

		private string GetBattleText(bool isBoostAll, float value)
		{
			return null;
		}

		private string GetDragonTimeText(float value)
		{
			return null;
		}

		private string GetDragonBoostText(float value)
		{
			return null;
		}
	}
}
