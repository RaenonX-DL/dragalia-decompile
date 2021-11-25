using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class SummonGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _SummonId1;

		[SerializeField]
		private int _SummonId2;

		[SerializeField]
		private int _SummonId3;

		[SerializeField]
		private int _SummonId4;

		[SerializeField]
		private int _SummonId5;

		[SerializeField]
		private string _CommenceDate;

		[SerializeField]
		private string _CompleteDate;

		public int Id => default(int);

		public int SummonId1 => default(int);

		public int SummonId2 => default(int);

		public int SummonId3 => default(int);

		public int SummonId4 => default(int);

		public int SummonId5 => default(int);

		public string CommenceDate => null;

		public string CompleteDate => null;
	}
}
