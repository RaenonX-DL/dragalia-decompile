using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class SummonMaterialDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _LimitedCount;

		[SerializeField]
		private int _PayCrystal1;

		[SerializeField]
		private int _PayCrystal2;

		[SerializeField]
		private int _PayCrystal3;

		[SerializeField]
		private int _PayCrystal4;

		[SerializeField]
		private int _PayCrystal5;

		[SerializeField]
		private int _PayCrystal6;

		[SerializeField]
		private string _CommenceDate;

		[SerializeField]
		private string _CompleteDate;

		public int Id => default(int);

		public int LimitedCount => default(int);

		public int PayCrystal1 => default(int);

		public int PayCrystal2 => default(int);

		public int PayCrystal3 => default(int);

		public int PayCrystal4 => default(int);

		public int PayCrystal5 => default(int);

		public int PayCrystal6 => default(int);

		public string CommenceDate => null;

		public string CompleteDate => null;
	}
}
