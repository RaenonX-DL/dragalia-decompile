using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestStoryGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Type;

		[SerializeField]
		private int _SortKey;

		public int Id => default(int);

		public int Type => default(int);

		public int SortKey => default(int);
	}
}
