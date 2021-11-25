namespace Gluon
{
	public class CharacterHitData
	{
		public CharacterBase attacker;

		public int actionId;

		public int nextActionId;

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
