using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ManaPieceTypeElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private GiftType _EntityType1;

		[SerializeField]
		private int _EntityId1;

		[SerializeField]
		private int _EntityQuantity1;

		[SerializeField]
		private GiftType _EntityType2;

		[SerializeField]
		private int _EntityId2;

		[SerializeField]
		private int _EntityQuantity2;

		[SerializeField]
		private GiftType _EntityType3;

		[SerializeField]
		private int _EntityId3;

		[SerializeField]
		private int _EntityQuantity3;

		public int Id => default(int);

		public GiftType EntityType1 => default(GiftType);

		public int EntityId1 => default(int);

		public int EntityQuantity1 => default(int);

		public GiftType EntityType2 => default(GiftType);

		public int EntityId2 => default(int);

		public int EntityQuantity2 => default(int);

		public GiftType EntityType3 => default(GiftType);

		public int EntityId3 => default(int);

		public int EntityQuantity3 => default(int);
	}
}
