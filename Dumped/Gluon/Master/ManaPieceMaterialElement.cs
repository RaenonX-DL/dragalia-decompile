using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ManaPieceMaterialElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _ElementId;

		[SerializeField]
		private Gluon.ManaPieceType _ManaPieceType;

		[SerializeField]
		private int _Step;

		[SerializeField]
		private int _MaterialId1;

		[SerializeField]
		private int _MaterialQuantity1;

		[SerializeField]
		private int _MaterialId2;

		[SerializeField]
		private int _MaterialQuantity2;

		[SerializeField]
		private int _MaterialId3;

		[SerializeField]
		private int _MaterialQuantity3;

		[SerializeField]
		private int _DewPoint;

		public int Id => default(int);

		public int ElementId => default(int);

		public Gluon.ManaPieceType ManaPieceType => default(Gluon.ManaPieceType);

		public int Step => default(int);

		public int MaterialId1 => default(int);

		public int MaterialQuantity1 => default(int);

		public int MaterialId2 => default(int);

		public int MaterialQuantity2 => default(int);

		public int MaterialId3 => default(int);

		public int MaterialQuantity3 => default(int);

		public int DewPoint => default(int);
	}
}
