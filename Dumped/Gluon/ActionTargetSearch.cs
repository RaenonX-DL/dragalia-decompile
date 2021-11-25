using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public static class ActionTargetSearch
	{
		private enum SortType
		{
			None,
			HighHp,
			LowHp,
			HighLv,
			LowLv,
			HighStr,
			LowStr,
			Near,
			Far,
			Random,
			HostPlayer,
			User1,
			User2,
			User3,
			User4,
			User2_NoSub,
			User3_NoSub,
			User4_NoSub,
			User2_SubHost,
			User3_SubHost,
			User4_SubHost
		}

		private struct StSortData
		{
			private GameObject target;

			private float distance2;

			private int hp;

			private int maxHp;
		}

		private enum TargetType
		{
			AliveAll,
			AliveAlly,
			AliveAI,
			DeadAlly,
			AliveHostile,
			AliveHostileFront,
			AliveHostileBehind,
			AliveHostileNoLimit,
			AliveHostileBind,
			AliveHostileSwoon,
			AliveSpeHate,
			AlivePlayerIndirect,
			AlivePlayerDirect,
			AliveHostileOutMarker,
			AlivePlayerMulti,
			RegisteredPlayer,
			DeadOrAliveHostile,
			DeadOrDollOrAliveHostile,
			AliveHostileLockOn
		}

		public static CommonObjectStatus Get(CommonObjectStatus owner, ActionTarget target)
		{
			return null;
		}

		private static CharacterBase SearchTarget(CommonObjectStatus owner, TargetType targetType, SortType sortType)
		{
			return null;
		}

		private static float GetParameter(Transform ownerTransform, CharacterBase character, SortType sortType)
		{
			return default(float);
		}

		private static bool ExceptTarget(CommonObjectStatus owner_, CharacterBase target, bool isRangeLimit = true, bool isDeadOrAlive = false, bool notExceptDoll = false)
		{
			return default(bool);
		}

		private static bool UniqueExceptTarget(TargetType targetType, CharacterBase owner, CharacterBase target)
		{
			return default(bool);
		}

		private static int GetCharacterCount(bool isEnemy)
		{
			return default(int);
		}

		private static int GetCharacterCountForPlayer(List<CharacterSelector> charas)
		{
			return default(int);
		}

		private static CharacterBase GetCharacter(bool isEnemy, int index)
		{
			return null;
		}

		private static CharacterBase GetCharacterForPlayer(List<CharacterSelector> charas, int index)
		{
			return null;
		}

		private static bool IsExcludedChara(CharacterSelector chara)
		{
			return default(bool);
		}

		private static CharacterBase GetTargetMultiPlayer(SortType sortType)
		{
			return null;
		}

		private static CharacterBase GetTargetSpecialHate(CommonObjectStatus owner, bool isEnemy, SortType sortType, ref float parameter)
		{
			return null;
		}

		private static CharacterBase GetTargetRegisteredPlayer(CommonObjectStatus owner, SortType sortType)
		{
			return null;
		}
	}
}
