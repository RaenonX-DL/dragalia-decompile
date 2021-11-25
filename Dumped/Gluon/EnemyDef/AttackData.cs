using System;
using UnityEngine;

namespace Gluon.EnemyDef
{
	[Serializable]
	public class AttackData
	{
		[SerializeField]
		public InGameDef.AttackRange attackRange;

		[SerializeField]
		public string motionName;

		[SerializeField]
		public float beforeInterval;

		[SerializeField]
		public float afterInterval;

		[SerializeField]
		public float activeRange;

		[SerializeField]
		protected float[] _hitFrames;

		[SerializeField]
		public float sleepInterval;

		public static AttackData Default()
		{
			return null;
		}

		public static void SetupDefault(ref AttackData data)
		{
		}

		public void CopyTo(AttackData target)
		{
		}
	}
}
