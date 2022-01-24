using System.Collections.Generic;

namespace Gluon
{
	public class CharacterHitData
	{
		public CharacterBase attacker;

		public int actionId;

		public List<int> nextActions;

		public int productId;

		public int conditionId;

		public int type;

		public int skillId;

		public int skillProductId;

		public bool isUnifiedBuff;

		public int buffExplosionHitId;

		public void Clear()
		{
		}

		public void ClearForDebuff()
		{
		}
	}
}
