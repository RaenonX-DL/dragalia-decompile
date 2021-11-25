using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CheatDetectionParamElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _MaxEnemyDamage;

		[SerializeField]
		private int _MaxEnemyBreakDamage;

		[SerializeField]
		private int _MaxEnemyPlayerDistance;

		[SerializeField]
		private int _MaxPlayerHeal;

		[SerializeField]
		private float _MaxPlayerMoveSpeed;

		public int Id => default(int);

		public int MaxEnemyDamage => default(int);

		public int MaxEnemyBreakDamage => default(int);

		public int MaxEnemyPlayerDistance => default(int);

		public int MaxPlayerHeal => default(int);

		public float MaxPlayerMoveSpeed => default(float);
	}
}
