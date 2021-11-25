using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class EnemySearchLink
	{
		private List<EnemyCtrl> _operators;

		private List<CharacterBase> _inSightHostiles;

		public bool disableAwake;

		public List<CharacterBase> inSightHostiles => null;

		public void AddOperator(EnemyCtrl enemy)
		{
		}

		public void ResponseDiscoverTarget(CharacterBase target)
		{
		}

		public void DiscoverTarget(CharacterBase target, bool isEmotion)
		{
		}

		public void ResponseAwakeAll(CollisionHitAttribute hitAttr, int damage)
		{
		}

		public void AwakeAll(bool isEmotion)
		{
		}

		public CharacterBase GetNearTarget(Vector3 basePos)
		{
			return null;
		}
	}
}
