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
	public class ActionPartsHypnosWindyStream : ActionParts
	{
		// Fields
		private readonly HypnosWindyStreamData _partsData;
		private State _state;
		private EnemyCharacter _enemy;
		private CollisionHitAttribute _hitAttribute;
		private HitException _hitException;
		private float _waiting;
		private int _powerNum;
		private int _checkChildID;
	
		// Nested types
		private enum State
		{
			Ready = 0,
			Wait = 1,
			Attack = 2
		}
	
		// Constructors
		public ActionPartsHypnosWindyStream(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		protected override void OnFinish();
		public override void Clear();
		protected override bool OnUpdate(float delta);
		public override void OnCollided(GameObject target, bool isPropagation);
	}
}
