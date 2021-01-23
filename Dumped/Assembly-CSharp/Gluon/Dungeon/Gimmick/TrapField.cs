/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Dungeon;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class TrapField : GimmickBase
	{
		// Fields
		public GimmickTrapField type;
		[Lock]
		[SerializeField]
		private string soundCueName;
		private GimmickTrapFieldElement variation;
		private CollisionHitAttribute hitAttribute;
		private Collider triggerCollider;
		private Dictionary<int, victimInfo> victim;
		private const float HitIntervalTime = 1f;
		public Action<TrapField, Collider> onEnterAction;
		public Action<TrapField, Collider> onExitAction;
	
		// Properties
		public string SoundCueName { get; }
		public CollisionHitAttribute HitAttribute { get; }
		public Collider TriggerCollider { get; }
	
		// Nested types
		private class victimInfo
		{
			// Fields
			public CharacterBase character;
			public float timer;
	
			// Constructors
			public victimInfo();
		}
	
		// Constructors
		public TrapField();
	
		// Methods
		protected override void Awake();
		private void OnTriggerEnter(Collider other);
		private void OnTriggerExit(Collider other);
		private void Update();
	}
}
