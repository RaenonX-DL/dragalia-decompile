using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DungeonItemDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private DungeonItemEffect _Effect;

		[SerializeField]
		private int _EffectValue;

		public int Id => default(int);

		public DungeonItemEffect Effect => default(DungeonItemEffect);

		public int EffectValue => default(int);
	}
}
