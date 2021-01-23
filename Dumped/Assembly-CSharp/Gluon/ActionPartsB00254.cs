/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsB00254 : ActionParts
	{
		// Fields
		private readonly B00254Data _partsData;
		private State _state;
		private List<ChargeMarker> _markers;
		private float _generateSec;
		private int _generateCnt;
		private float _forwardRot;
		private float _sectionRot;
		private CollisionHitAttribute _hitAttribute;
		protected HitException _hitException;
		private RandomXorshift _random;
		private RunActionRandomParameter _runActionParam;
	
		// Nested types
		private enum State
		{
			init = 0,
			delayAttack = 1,
			hitCheck = 2,
			retreat = 3
		}
	
		// Constructors
		public ActionPartsB00254(ActionParts resource);
	
		// Methods
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private bool UpdateAttack(float delta);
		private bool UpdateRetreat();
		private void CreateMarker(float forwardRot);
		private CollisionHitAttribute CreateHitAttribute();
		public override void OnCollided(GameObject target, bool isPropagation);
	}
}
