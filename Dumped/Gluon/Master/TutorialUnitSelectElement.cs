using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class TutorialUnitSelectElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _UnitSelelctGroupId;

		[SerializeField]
		private string _StartDate;

		[SerializeField]
		private string _EndDate;

		public int Id => default(int);

		public int UnitSelelctGroupId => default(int);

		public string StartDate => null;

		public string EndDate => null;
	}
}
