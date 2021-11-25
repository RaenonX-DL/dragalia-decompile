using System;
using Cute.Core;

namespace Gluon
{
	public class MaterialHarvester : FastUpdateMonoBehaviour
	{
		public enum HarvestType
		{
			None,
			Gold,
			Material,
			Stamina,
			Num
		}

		private const float kEnableCropGoldNum = 10f;

		private const float kEnableCropMaterialNum = 1f;

		public HarvestType type;

		public Facility facility;

		private float produceSpeed;

		private float produceMaxValue;

		private float _harvestValue;

		private float harvestDuration;

		private DateTime harvestStartTime;

		private float alreadyPassedHarvestTime;

		public float harvestValue
		{
			get
			{
				return default(float);
			}
			private set
			{
			}
		}

		public void OnInit(FortPlantType type, Facility facility, float enableHarvestDuration)
		{
		}

		public void InitToHarvest()
		{
		}

		public void StartToHarvest()
		{
		}

		public void UpdateHarvest()
		{
		}

		public int GetAlreadyPassedHarvestTime()
		{
			return default(int);
		}

		private void Init(HarvestType type, Facility facility, float enableHarvestDuration)
		{
		}
	}
}
