using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private Gluon.WeaponType _Type;

		[SerializeField]
		private int _Rarity;

		[SerializeField]
		private Gluon.ElementalType _ElementalType;

		[SerializeField]
		private int _MinHp;

		[SerializeField]
		private int _MaxHp;

		[SerializeField]
		private int _MinAtk;

		[SerializeField]
		private int _MaxAtk;

		[SerializeField]
		private int _LimitBreakId;

		[SerializeField]
		private int _BaseId;

		[SerializeField]
		private int _VariationId;

		[SerializeField]
		private int _FormId;

		[SerializeField]
		private int _DecBaseId;

		[SerializeField]
		private int _DecVariationId;

		[SerializeField]
		private int _BulletBaseId;

		[SerializeField]
		private int _BulletVariationId;

		[SerializeField]
		private int _Skill;

		[SerializeField]
		private int _Abilities11;

		[SerializeField]
		private int _Abilities21;

		[SerializeField]
		private int _IsPlayable;

		[SerializeField]
		private string _Text;

		[SerializeField]
		private int _SellCoin;

		[SerializeField]
		private int _SellDewPoint;

		[SerializeField]
		private int _GradeId;

		[SerializeField]
		private int _CraftSeriesId;

		[SerializeField]
		private int _CraftStyleGroupId;

		public int Id => default(int);

		public string Name => null;

		public Gluon.WeaponType Type => default(Gluon.WeaponType);

		public int Rarity => default(int);

		public Gluon.ElementalType ElementalType => default(Gluon.ElementalType);

		public int MinHp => default(int);

		public int MaxHp => default(int);

		public int MinAtk => default(int);

		public int MaxAtk => default(int);

		public int LimitBreakId => default(int);

		public int BaseId => default(int);

		public int VariationId => default(int);

		public int FormId => default(int);

		public int DecBaseId => default(int);

		public int DecVariationId => default(int);

		public int BulletBaseId => default(int);

		public int BulletVariationId => default(int);

		public int Skill => default(int);

		public int Abilities11 => default(int);

		public int Abilities21 => default(int);

		public int IsPlayable => default(int);

		public string Text => null;

		public int SellCoin => default(int);

		public int SellDewPoint => default(int);

		public int GradeId => default(int);

		public int CraftSeriesId => default(int);

		public int CraftStyleGroupId => default(int);
	}
}
