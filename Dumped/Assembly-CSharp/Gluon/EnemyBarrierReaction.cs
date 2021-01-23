/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyBarrierReaction
	{
		// Fields
		private const float TIME_UP = 1f;
		private Parameter[] _paramList;
		private EnemyCharacter _owner;
		private NotifyCharacter.NoDamage noDmgParam;
	
		// Nested types
		private class Parameter
		{
			// Fields
			public int character_id;
			public int action_id;
			public float timer;
	
			// Constructors
			public Parameter();
	
			// Methods
			public void Reset();
		}
	
		// Constructors
		public EnemyBarrierReaction();
	
		// Methods
		public void Initialize(EnemyCharacter owner);
		public void Reset();
		public void Update();
		public void OnHit(int characterId, int actionId, Vector3 hitPos);
	}
}
