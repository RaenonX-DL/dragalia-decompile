using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MCElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Hierarchy;

		[SerializeField]
		private int _No;

		[SerializeField]
		private Gluon.ManaPieceType _ManaPieceType;

		[SerializeField]
		private int _IsReleaseStory;

		[SerializeField]
		private int _NecessaryManaPoint;

		[SerializeField]
		private int _UniqueGrowMaterialCount1;

		[SerializeField]
		private int _UniqueGrowMaterialCount2;

		[SerializeField]
		private int _GrowMaterialCount;

		public int Id => default(int);

		public int Hierarchy => default(int);

		public int No => default(int);

		public Gluon.ManaPieceType ManaPieceType => default(Gluon.ManaPieceType);

		public int IsReleaseStory => default(int);

		public int NecessaryManaPoint => default(int);

		public int UniqueGrowMaterialCount1 => default(int);

		public int UniqueGrowMaterialCount2 => default(int);

		public int GrowMaterialCount => default(int);
	}
}
