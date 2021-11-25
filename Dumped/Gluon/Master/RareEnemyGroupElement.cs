using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class RareEnemyGroupElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _RareGroupId;

		[SerializeField]
		private string _RareAdminName;

		[SerializeField]
		private int _EnemyThresholdNum;

		[SerializeField]
		private int _RareEnemy1;

		[SerializeField]
		private int _RareWeight1;

		[SerializeField]
		private int _RareEnemy2;

		[SerializeField]
		private int _RareWeight2;

		[SerializeField]
		private int _RareEnemy3;

		[SerializeField]
		private int _RareWeight3;

		[SerializeField]
		private int _RareEnemy4;

		[SerializeField]
		private int _RareWeight4;

		[SerializeField]
		private int _RareEnemy5;

		[SerializeField]
		private int _RareWeight5;

		public int Id => default(int);

		public int RareGroupId => default(int);

		public string RareAdminName => null;

		public int EnemyThresholdNum => default(int);

		public int RareEnemy1 => default(int);

		public int RareWeight1 => default(int);

		public int RareEnemy2 => default(int);

		public int RareWeight2 => default(int);

		public int RareEnemy3 => default(int);

		public int RareWeight3 => default(int);

		public int RareEnemy4 => default(int);

		public int RareWeight4 => default(int);

		public int RareEnemy5 => default(int);

		public int RareWeight5 => default(int);
	}
}
