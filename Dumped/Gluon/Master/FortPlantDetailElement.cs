using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class FortPlantDetailElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _AssetGroup;

		[SerializeField]
		private int _Level;

		[SerializeField]
		private int _NextAssetGroup;

		[SerializeField]
		private string _ReleaseDate;

		[SerializeField]
		private string _PrefabName;

		[SerializeField]
		private string _ImageUiName;

		[SerializeField]
		private int _LevelType;

		[SerializeField]
		private int _NeedLevel;

		[SerializeField]
		private int _Time;

		[SerializeField]
		private int _Cost;

		[SerializeField]
		private int _RmCost;

		[SerializeField]
		private int _MaterialsId1;

		[SerializeField]
		private int _MaterialsNum1;

		[SerializeField]
		private int _MaterialsId2;

		[SerializeField]
		private int _MaterialsNum2;

		[SerializeField]
		private int _MaterialsId3;

		[SerializeField]
		private int _MaterialsNum3;

		[SerializeField]
		private int _MaterialsId4;

		[SerializeField]
		private int _MaterialsNum4;

		[SerializeField]
		private int _MaterialsId5;

		[SerializeField]
		private int _MaterialsNum5;

		[SerializeField]
		private FortPlantEffect _EffectId;

		[SerializeField]
		private int _EffType1;

		[SerializeField]
		private int _EffType2;

		[SerializeField]
		private float _EffArgs1;

		[SerializeField]
		private float _EffArgs2;

		[SerializeField]
		private float _EffArgs3;

		[SerializeField]
		private int _CostMaxTime;

		[SerializeField]
		private int _CostMax;

		[SerializeField]
		private int _MaterialMaxTime;

		[SerializeField]
		private int _MaterialMax;

		[SerializeField]
		private string _Odds;

		[SerializeField]
		private int _StaminaMaxTime;

		[SerializeField]
		private int _StaminaMax;

		[SerializeField]
		private FortPlantEventEffect _EventEffectType;

		[SerializeField]
		private float _EventEffectArgs;

		public int Id => default(int);

		public int AssetGroup => default(int);

		public int Level => default(int);

		public int NextAssetGroup => default(int);

		public string ReleaseDate => null;

		public string PrefabName => null;

		public string ImageUiName => null;

		public int LevelType => default(int);

		public int NeedLevel => default(int);

		public int Time => default(int);

		public int Cost => default(int);

		public int RmCost => default(int);

		public int MaterialsId1 => default(int);

		public int MaterialsNum1 => default(int);

		public int MaterialsId2 => default(int);

		public int MaterialsNum2 => default(int);

		public int MaterialsId3 => default(int);

		public int MaterialsNum3 => default(int);

		public int MaterialsId4 => default(int);

		public int MaterialsNum4 => default(int);

		public int MaterialsId5 => default(int);

		public int MaterialsNum5 => default(int);

		public FortPlantEffect EffectId => default(FortPlantEffect);

		public int EffType1 => default(int);

		public int EffType2 => default(int);

		public float EffArgs1 => default(float);

		public float EffArgs2 => default(float);

		public float EffArgs3 => default(float);

		public int CostMaxTime => default(int);

		public int CostMax => default(int);

		public int MaterialMaxTime => default(int);

		public int MaterialMax => default(int);

		public string Odds => null;

		public int StaminaMaxTime => default(int);

		public int StaminaMax => default(int);

		public FortPlantEventEffect EventEffectType => default(FortPlantEventEffect);

		public float EventEffectArgs => default(float);
	}
}
