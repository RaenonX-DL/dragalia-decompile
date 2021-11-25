using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AmuletDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private int _Rarity;

		[SerializeField]
		private UnitType _AmuletType;

		[SerializeField]
		private int _MinHp;

		[SerializeField]
		private int _MaxHp;

		[SerializeField]
		private int _MinAtk;

		[SerializeField]
		private int _MaxAtk;

		[SerializeField]
		private int _BaseId;

		[SerializeField]
		private int _VariationId;

		[SerializeField]
		private int _Abilities11;

		[SerializeField]
		private int _Abilities12;

		[SerializeField]
		private int _Abilities13;

		[SerializeField]
		private int _Abilities21;

		[SerializeField]
		private int _Abilities22;

		[SerializeField]
		private int _Abilities23;

		[SerializeField]
		private int _Abilities31;

		[SerializeField]
		private int _Abilities32;

		[SerializeField]
		private int _Abilities33;

		[SerializeField]
		private string _CvInfo;

		[SerializeField]
		private string _Text1;

		[SerializeField]
		private string _Text2;

		[SerializeField]
		private string _Text3;

		[SerializeField]
		private string _Text4;

		[SerializeField]
		private string _Text5;

		[SerializeField]
		private int _LimitBreakId;

		[SerializeField]
		private int _IsPlayable;

		[SerializeField]
		private int _SellCoin;

		[SerializeField]
		private int _SellDewPoint;

		[SerializeField]
		private int _IsHideChangeImage;

		public int Id => default(int);

		public string Name => null;

		public int Rarity => default(int);

		public UnitType AmuletType => default(UnitType);

		public int MinHp => default(int);

		public int MaxHp => default(int);

		public int MinAtk => default(int);

		public int MaxAtk => default(int);

		public int BaseId => default(int);

		public int VariationId => default(int);

		public int Abilities11 => default(int);

		public int Abilities12 => default(int);

		public int Abilities13 => default(int);

		public int Abilities21 => default(int);

		public int Abilities22 => default(int);

		public int Abilities23 => default(int);

		public int Abilities31 => default(int);

		public int Abilities32 => default(int);

		public int Abilities33 => default(int);

		public string CvInfo => null;

		public string Text1 => null;

		public string Text2 => null;

		public string Text3 => null;

		public string Text4 => null;

		public string Text5 => null;

		public int LimitBreakId => default(int);

		public int IsPlayable => default(int);

		public int SellCoin => default(int);

		public int SellDewPoint => default(int);

		public int IsHideChangeImage => default(int);
	}
}
