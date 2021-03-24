/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsVolcano : ActionParts
	{
		// Fields
		private readonly VolcanoData _partsData;
		private State _state;
		private float _chargeTime;
		private EnemyCharacter _enemy;
		protected ChargeMarker _marker;
		private CollisionHitAttribute _hitAttribute;
		private HitException _hitException;
		protected EffectObject _attachEffect;
		protected EffectObject _explosionEffect;
		private float _preSpeedScale;
	
		// Nested types
		private enum State
		{
			Ready = 0,
			Charge = 1,
			Freeze = 2,
			Freezing = 3,
			Thaw = 4,
			Explosion = 5,
			End = 6
		}
	
		// Constructors
		public ActionPartsVolcano(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		protected override void OnFinish();
		public override void Clear();
		protected override bool OnUpdate(float delta);
		private void Explosion();
		public override void OnCollided(GameObject target, bool isPropagation);
	}
}
