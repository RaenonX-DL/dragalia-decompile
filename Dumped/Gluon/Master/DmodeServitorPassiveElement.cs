using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeServitorPassiveElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private DmodeServitorPassiveType _ServitorPassiveType;

		[SerializeField]
		private string _PassiveName;

		[SerializeField]
		private int _PassiveNum;

		[SerializeField]
		private int _SortId;

		[SerializeField]
		private string _IconImage;

		public int Id => default(int);

		public DmodeServitorPassiveType ServitorPassiveType => default(DmodeServitorPassiveType);

		public string PassiveName => null;

		public int PassiveNum => default(int);

		public int SortId => default(int);

		public string IconImage => null;
	}
}
