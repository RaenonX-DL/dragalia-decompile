using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MenuTalkGroupElement : IMasterElement
	{
		[SerializeField]
		private int _CharaId;

		[SerializeField]
		private int _GroupId;

		[SerializeField]
		private int _Category0;

		[SerializeField]
		private int _Priority;

		[SerializeField]
		private string _ViewStartDate;

		[SerializeField]
		private string _ViewEndDate;

		public int CharaId => default(int);

		public int GroupId => default(int);

		public int Category0 => default(int);

		public int Priority => default(int);

		public string ViewStartDate => null;

		public string ViewEndDate => null;
	}
}
