using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class WeaponSkinElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private Gluon.WeaponType _WeaponType;

		[SerializeField]
		private int _Rarity;

		[SerializeField]
		private Gluon.ElementalType _ElementalType;

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
		private int _IsPlayable;

		[SerializeField]
		private string _Text;

		[SerializeField]
		private GiftType _DuplicateEntityType;

		[SerializeField]
		private int _DuplicateEntityId;

		[SerializeField]
		private int _DuplicateEntityQuantity;

		public int Id => default(int);

		public string Name => null;

		public Gluon.WeaponType WeaponType => default(Gluon.WeaponType);

		public int Rarity => default(int);

		public Gluon.ElementalType ElementalType => default(Gluon.ElementalType);

		public int BaseId => default(int);

		public int VariationId => default(int);

		public int FormId => default(int);

		public int DecBaseId => default(int);

		public int DecVariationId => default(int);

		public int BulletBaseId => default(int);

		public int BulletVariationId => default(int);

		public int IsPlayable => default(int);

		public string Text => null;

		public GiftType DuplicateEntityType => default(GiftType);

		public int DuplicateEntityId => default(int);

		public int DuplicateEntityQuantity => default(int);
	}
}
