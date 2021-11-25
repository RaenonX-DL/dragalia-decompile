using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DragonGiftDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Name;

		[SerializeField]
		private string _Descripsion;

		[SerializeField]
		private DragonGiftType _DragonGiftType;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private int _Reliability;

		[SerializeField]
		private int _FavoriteReliability;

		[SerializeField]
		private DragonFavoriteType _FavoriteType;

		public int Id => default(int);

		public string Name => null;

		public string Descripsion => null;

		public DragonGiftType DragonGiftType => default(DragonGiftType);

		public int SortId => default(int);

		public int Reliability => default(int);

		public int FavoriteReliability => default(int);

		public DragonFavoriteType FavoriteType => default(DragonFavoriteType);
	}
}
