/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class BindBulletObject : BulletObjectWithMarker
	{
		// Fields
		private MoveType _moveType;
		private CollisionHitAttribute _releaseHitAttr;
		protected HitException _releaseHitException;
		[CompilerGenerated]
		private float _timer_k__BackingField;
		[CompilerGenerated]
		private int _effectTrigger_Release_k__BackingField;
		[CompilerGenerated]
		private float _bindHeight_k__BackingField;
		private long _bindEventId;
		private List<CharacterBase> _boundList;
		private bool _hasBound;
		private float _bindingTime;
	
		// Properties
		private float timer { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int effectTrigger_Release { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float bindHeight { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum MoveType
		{
			Stay = 0,
			Straight = 1
		}
	
		// Constructors
		public BindBulletObject();
	
		// Methods
		public bool Initialize(CharacterBase owner, CommonObjectStatus target, Vector3 position, Quaternion rotation, MoveType moveType, float bulletDuration, MarkerData markerData, float waitCount, int traceDelay, string releaseHitAttrLabel = "", long bindEventId = 0, float tempoScale = 1f, float bindingTime = 0f);
		protected override void Clear();
		protected override bool State_BulletRun();
		private void RunStay();
		private void RunStraight();
		protected override bool State_After();
		private void ProcReleaseBind();
		public override void OnCollided(GameObject goTarget, bool isPropagation);
		public override bool IsExcept(CharacterBase chara);
		public override void OnCollidedEffect(CommonObjectStatus from, CommonObjectStatus to, Vector3 pos, Quaternion rot);
		private void CreateHitAttribute(string label, ActionCollision collision, ref CollisionHitAttribute hit);
	}
}
