/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterFormation
	{
		// Fields
		private static readonly Vector3[] _offsetTableForQuest;
		private static readonly Vector3[] _offsetTableForRaid;
		private FormationPatterns _pattern;
		private Dictionary<int, ActorData> _formations;
		private List<FormationPrivateData> _myManagedCharacters;
		private int _totalCharacterCount;
		private int _actorIdSelf;
		private bool _isDirty;
	
		// Nested types
		private class ActorData
		{
			// Fields
			[CompilerGenerated]
			private int _actorId_k__BackingField;
			public List<FormationPrivateData> characters;
			public bool isActive;
			public int manageCount;
	
			// Properties
			public int actorId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public ActorData(int actorId);
		}
	
		private class FormationPrivateData
		{
			// Fields
			public bool isGuestCharacter;
			public bool isControlled;
			public int originActorId;
			public FormationData publicData;
	
			// Constructors
			public FormationPrivateData();
		}
	
		public class FormationData
		{
			// Fields
			public CharacterSelector character;
			public int ownerActorId;
			public Vector3 followOffset;
			public Vector3 startOffset;
	
			// Constructors
			public FormationData();
		}
	
		private enum FormationPatterns
		{
			Quest = 0,
			Raid = 1
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Predicate<FormationPrivateData> __9__16_0;
			public static Predicate<FormationPrivateData> __9__16_1;
			public static Comparison<int> __9__23_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _AddCharacter_b__16_0(FormationPrivateData item);
			internal bool _AddCharacter_b__16_1(FormationPrivateData item);
			internal int _CalculateStartOffset_b__23_0(int a, int b);
		}
	
		// Constructors
		public CharacterFormation(int actorIdSelf, int[] actorIds, DungeonType dungeonType);
		static CharacterFormation();
	
		// Methods
		public void Clear();
		public void AddPartyCharacter(int actorId, CharacterSelector selector);
		public void AddGuestCharacter(int actorId, CharacterSelector selector);
		private void AddCharacter(int actorId, CharacterSelector selector, bool isGuest);
		public void ChangeControlledPlayer(int changedActorId, CharacterSelector selector);
		public List<FormationData> CollectCharactersByActorId(int actorId);
		public List<FormationData> InactivatateUser(int actorId);
		public bool TryGetFormationData(CharacterSelector selector, out FormationData result);
		private int GetActorId(CharacterSelector selector);
		public int GetOwnerActorId(CharacterSelector selector);
		private void CalculateStartOffset();
		private void CalculateFollowOffset();
	}
}
