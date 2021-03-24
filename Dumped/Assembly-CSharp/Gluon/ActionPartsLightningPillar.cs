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
	public class ActionPartsLightningPillar : ActionParts
	{
		// Fields
		private readonly LightningPillarData _partsData;
		private State _state;
		private EnemyCharacter _enemy;
		private CollisionHitAttribute _hitAttribute;
		private HitException _hitException;
		private int _powerNum;
		private float _waiting;
		private float _cyclicTime;
		private bool _isSigned;
	
		// Nested types
		private enum State
		{
			Charge = 0,
			Ready = 1,
			Wait = 2,
			Attack = 3
		}
	
		// Constructors
		public ActionPartsLightningPillar(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		protected override void OnFinish();
		public override void Clear();
		protected override bool OnUpdate(float delta);
		private void CyclicHit();
		public override void OnCollided(GameObject target, bool isPropagation);
	}
}
