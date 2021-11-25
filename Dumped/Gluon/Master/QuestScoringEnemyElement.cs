using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestScoringEnemyElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _ScoringEnemyGroupId;

		[SerializeField]
		private int _EnemyListId;

		[SerializeField]
		private int _Point;

		[SerializeField]
		private string _IconImage;

		public int Id => default(int);

		public int ScoringEnemyGroupId => default(int);

		public int EnemyListId => default(int);

		public int Point => default(int);

		public string IconImage => null;
	}
}
