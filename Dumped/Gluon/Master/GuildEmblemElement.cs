using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GuildEmblemElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		public int Id => default(int);

		public int SortId => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;
	}
}
