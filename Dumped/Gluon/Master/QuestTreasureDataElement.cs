using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestTreasureDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _GroupId;

		[SerializeField]
		private int _LocationId;

		public int Id => default(int);

		public int GroupId => default(int);

		public int LocationId => default(int);
	}
}
