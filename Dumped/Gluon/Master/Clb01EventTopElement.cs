using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class Clb01EventTopElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Category0;

		[SerializeField]
		private int _TargetValue;

		[SerializeField]
		private int _ViewCharaCount;

		[SerializeField]
		private int _ViewNpcId1;

		[SerializeField]
		private int _ViewNpcId2;

		[SerializeField]
		private int _ViewNpcId3;

		[SerializeField]
		private int _ViewNpcId4;

		[SerializeField]
		private int _ViewNpcId5;

		public int Id => default(int);

		public int Category0 => default(int);

		public int TargetValue => default(int);

		public int ViewCharaCount => default(int);

		public int ViewNpcId1 => default(int);

		public int ViewNpcId2 => default(int);

		public int ViewNpcId3 => default(int);

		public int ViewNpcId4 => default(int);

		public int ViewNpcId5 => default(int);
	}
}
