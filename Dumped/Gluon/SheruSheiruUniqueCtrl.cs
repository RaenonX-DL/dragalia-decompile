using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Gluon
{
	public class SheruSheiruUniqueCtrl : EnemyUniqueCtrl
	{
		public EnemyCharacter owner;

		private bool isChildCollisionOff;

		public List<EnemyCharacter> HitList
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override void Initialize()
		{
		}

		public void HitEnemy(EnemyCharacter subEnemy, int actionID)
		{
		}

		public bool AlreadyHit(EnemyCharacter subEnemy)
		{
			return default(bool);
		}

		public void ResetHitList()
		{
		}

		public override void FastUpdate()
		{
		}
	}
}
