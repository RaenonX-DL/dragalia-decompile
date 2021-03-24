/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionMove : ActionMoveBase
	{
		// Fields
		protected Vector3 _startPos;
		protected Vector3 _endPos;
		protected Vector3 _distance;
		protected float _duration;
		private float _stepTime;
		private bool isUpdateXZ;
		private Rigidbody _rigidbody;
		private ActionMoveExecution moveExec;
		private ActionMoveGravity moveGravity;
	
		// Constructors
		public ActionMove();
		public ActionMove(Vector3 startPos, Vector3 endPos, float duration, int property = 0);
	
		// Methods
		public void Startup(Vector3 startPos, Vector3 endPos, float duration, int property = 0);
		public void InitializeMoveGravity(float gravity);
		protected override void OnStart();
		protected override void OnFinish();
		public override void Stop();
		protected override bool OnFixedUpdate(float delta);
		private void UpdateForcedTranslate(Vector3 targetPos);
		private bool CheckHitCollider(float delta, Vector3 pos);
	}
}
