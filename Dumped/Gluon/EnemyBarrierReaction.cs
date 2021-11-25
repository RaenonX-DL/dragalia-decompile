using UnityEngine;

namespace Gluon
{
	public class EnemyBarrierReaction
	{
		private class Parameter
		{
			public int character_id;

			public int action_id;

			public float timer;

			public void Reset()
			{
			}
		}

		private const float TIME_UP = 1f;

		private Parameter[] _paramList;

		private EnemyCharacter _owner;

		private NotifyCharacter.NoDamage noDmgParam;

		public void Initialize(EnemyCharacter owner)
		{
		}

		public void Reset()
		{
		}

		public void Update()
		{
		}

		public void OnHit(int characterId, int actionId, Vector3 hitPos)
		{
		}
	}
}
