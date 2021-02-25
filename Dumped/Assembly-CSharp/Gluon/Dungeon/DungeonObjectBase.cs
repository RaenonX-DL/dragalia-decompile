/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public abstract class DungeonObjectBase : DungeonObjectStatus, ICollision
	{
		// Fields
		protected Animator anim;
		protected int idle;
		protected int open;
		[CompilerGenerated]
		private float _radius_k__BackingField;
		public bool isTarget;
		public bool isPenetratable;
		public float hitRadius;
		public CharacterHitStopPlayer hitStopPlayer;
		[CompilerGenerated]
		private Collider _baseCollider_k__BackingField;
	
		// Properties
		public float radius { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public virtual bool considerColliderOffsetHeight { get; }
		public Collider baseCollider { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		protected DungeonObjectBase();
	
		// Methods
		protected virtual void Start();
		public float GetAnimationTime(int stateHash);
		public float GetAnimationNormalizedTime(int stateHash);
		public abstract void OnCollided(GameObject target, CollisionHitAttribute data);
		protected void SetTargetInvalid();
		protected void SetTargetValid();
		protected bool IsFinishAnimator();
		protected Transform GetHitCharacterTransform(GameObject obj);
		public static void DisplaySystemMessage(Localize.TextId id);
		public static void DisplaySystemMessageOpen(Localize.TextId id, bool se = true);
		public static void DisplaySystemMessageClose();
		public float GetColliderHeight();
	}
}
