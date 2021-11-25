using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class CharacterFormation
	{
		private class ActorData
		{
			public List<FormationPrivateData> characters;

			public bool isActive;

			public int manageCount;

			public bool isHighOwnerPriority;

			public int actorId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public ActorData(int actorId)
			{
			}

			public void Clear()
			{
			}
		}

		private class FormationPrivateData
		{
			public bool isGuestCharacter;

			public bool isControlled;

			public int originActorId;

			public FormationData publicData;
		}

		public class FormationData
		{
			public CharacterSelector character;

			public int ownerActorId;

			public Vector3 followOffset;

			public Vector3 startOffset;
		}

		private enum FormationPatterns
		{
			Quest,
			Raid
		}

		private static readonly Vector3[] _offsetTableForQuest;

		private static readonly Vector3[] _offsetTableForRaid;

		private FormationPatterns _pattern;

		private Dictionary<int, ActorData> _formations;

		private List<FormationPrivateData> _myManagedCharacters;

		private int _totalCharacterCount;

		private int _actorIdSelf;

		private bool _isDirty;

		public static Vector3[] offsetTableForQuest => null;

		public CharacterFormation(int actorIdSelf, int[] actorIds, DungeonType dungeonType, bool[] isLowestGraphicsQuarities)
		{
		}

		public void Clear()
		{
		}

		public void AddPartyCharacter(int actorId, CharacterSelector selector)
		{
		}

		public void AddGuestCharacter(int actorId, CharacterSelector selector)
		{
		}

		private void AddCharacter(int actorId, CharacterSelector selector, bool isGuest)
		{
		}

		public void ChangeControlledPlayer(int changedActorId, CharacterSelector selector)
		{
		}

		public List<FormationData> CollectCharactersByActorId(int actorId)
		{
			return null;
		}

		public List<FormationData> InactivatateUser(int actorId)
		{
			return null;
		}

		public bool TryGetFormationData(CharacterSelector selector, out FormationData result)
		{
			return default(bool);
		}

		private int GetActorId(CharacterSelector selector)
		{
			return default(int);
		}

		public int GetOwnerActorId(CharacterSelector selector)
		{
			return default(int);
		}

		private void CalculateStartOffset()
		{
		}

		private void CalculateFollowOffset()
		{
		}

		private bool IsCheckOwnerPriorityQuest()
		{
			return default(bool);
		}
	}
}
