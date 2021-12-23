namespace Gluon
{
	public static class CharacterBuffTriggerDispatcher
	{
		public static void OnAppendBuff(CharacterBase owner, ref CharacterBuff.BuffUnion buff, CollisionHitAttribute hitAttr)
		{
		}

		public static void OnPreRemoveBuff(CharacterBase owner, ref CharacterBuff.BuffUnion buff, RemoveBuffReason reason)
		{
		}

		public static void OnPostRemoveBuff(CharacterBase owner, RemoveBuffReason reason = RemoveBuffReason.Other)
		{
		}

		public static bool IsRemoveTriggerBuff(ref CharacterBuff.BuffUnion buff)
		{
			return default(bool);
		}

		private static void CheckAbilityForBuffDisappeared(CharacterBase owner, int buffConditionId, RemoveBuffReason reason = RemoveBuffReason.Other)
		{
		}
	}
}
