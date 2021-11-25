using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class SummonPointDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _SummonId;

		[SerializeField]
		private string _CommenceDate;

		[SerializeField]
		private string _CompleteDate;

		public int Id => default(int);

		public int SummonId => default(int);

		public string CommenceDate => null;

		public string CompleteDate => null;
	}
}
