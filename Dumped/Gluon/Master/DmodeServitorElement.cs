using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DmodeServitorElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private DmodeServitorType _DmodeServitorType;

		[SerializeField]
		private int _DragonId;

		[SerializeField]
		private int _ServitorLevelGroupId;

		public int Id => default(int);

		public DmodeServitorType DmodeServitorType => default(DmodeServitorType);

		public int DragonId => default(int);

		public int ServitorLevelGroupId => default(int);
	}
}
