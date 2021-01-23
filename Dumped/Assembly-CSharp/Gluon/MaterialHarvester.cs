/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MaterialHarvester : FastUpdateMonoBehaviour
	{
		// Fields
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
	
		// Properties
		public float harvestValue { get; private set; }
	
		// Nested types
		public enum HarvestType
		{
			None = 0,
			Gold = 1,
			Material = 2,
			Stamina = 3,
			Num = 4
		}
	
		// Constructors
		public MaterialHarvester();
	
		// Methods
		public void OnInit(FortPlantType type, Facility facility, float enableHarvestDuration);
		public void InitToHarvest();
		public void StartToHarvest();
		public void UpdateHarvest();
		public int GetAlreadyPassedHarvestTime();
		private void Init(HarvestType type, Facility facility, float enableHarvestDuration);
	}
}
