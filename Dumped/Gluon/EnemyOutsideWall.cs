using UnityEngine;

namespace Gluon
{
	public class EnemyOutsideWall
	{
		private EnemyCharacter _owner;

		private const float CHECK_TIME = 2f;

		private float _checkTiming;

		private int _rayHitTimes;

		private Vector3 _safePosition;

		private bool _active;

		public bool active
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public EnemyOutsideWall(EnemyCharacter owner)
		{
		}

		public void Update()
		{
		}

		private void Warp()
		{
		}

		public void Reset()
		{
		}
	}
}
