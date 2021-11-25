using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DefenseEventSystemInfoElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _QuestGroupId;

		[SerializeField]
		private int _QuestId;

		[SerializeField]
		private string _FortDamageText;

		[SerializeField]
		private string _FortDyingText;

		[SerializeField]
		private string _FortDeadText;

		[SerializeField]
		private string _HouseDeadText;

		[SerializeField]
		private string _NextAreaText;

		public int Id => default(int);

		public int QuestGroupId => default(int);

		public int QuestId => default(int);

		public string FortDamageText => null;

		public string FortDyingText => null;

		public string FortDeadText => null;

		public string HouseDeadText => null;

		public string NextAreaText => null;
	}
}
