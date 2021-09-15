/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class ActionTargetSearch
	{
		// Nested types
		private enum SortType
		{
			None = 0,
			HighHp = 1,
			LowHp = 2,
			HighLv = 3,
			LowLv = 4,
			HighStr = 5,
			LowStr = 6,
			Near = 7,
			Far = 8,
			Random = 9,
			HostPlayer = 10,
			User1 = 11,
			User2 = 12,
			User3 = 13,
			User4 = 14,
			User2_NoSub = 15,
			User3_NoSub = 16,
			User4_NoSub = 17,
			User2_SubHost = 18,
			User3_SubHost = 19,
			User4_SubHost = 20
		}
	
		private struct StSortData
		{
			// Fields
			private GameObject target;
			private float distance2;
			private int hp;
			private int maxHp;
		}
	
		private enum TargetType
		{
			AliveAll = 0,
			AliveAlly = 1,
			AliveAI = 2,
			DeadAlly = 3,
			AliveHostile = 4,
			AliveHostileFront = 5,
			AliveHostileBehind = 6,
			AliveHostileNoLimit = 7,
			AliveHostileBind = 8,
			AliveHostileSwoon = 9,
			AliveSpeHate = 10,
			AlivePlayerIndirect = 11,
			AlivePlayerDirect = 12,
			AliveHostileOutMarker = 13,
			AlivePlayerMulti = 14,
			RegisteredPlayer = 15,
			DeadOrAliveHostile = 16,
			DeadOrDollOrAliveHostile = 17,
			AliveHostileLockOn = 18
		}
	
		// Methods
		public static CommonObjectStatus Get(CommonObjectStatus owner, ActionTarget target);
		private static CharacterBase SearchTarget(CommonObjectStatus owner, TargetType targetType, SortType sortType);
		private static float GetParameter(Transform ownerTransform, CharacterBase character, SortType sortType);
		private static bool ExceptTarget(CommonObjectStatus owner_, CharacterBase target, bool isRangeLimit = true, bool isDeadOrAlive = false, bool notExceptDoll = false);
		private static bool UniqueExceptTarget(TargetType targetType, CharacterBase owner, CharacterBase target);
		private static int GetCharacterCount(bool isEnemy);
		private static int GetCharacterCountForPlayer(List<CharacterSelector> charas);
		private static CharacterBase GetCharacter(bool isEnemy, int index);
		private static CharacterBase GetCharacterForPlayer(List<CharacterSelector> charas, int index);
		private static bool IsExcludedChara(CharacterSelector chara);
		private static CharacterBase GetTargetMultiPlayer(SortType sortType);
		private static CharacterBase GetTargetSpecialHate(CommonObjectStatus owner, bool isEnemy, SortType sortType, ref float parameter);
		private static CharacterBase GetTargetRegisteredPlayer(CommonObjectStatus owner, SortType sortType);
	}
}
