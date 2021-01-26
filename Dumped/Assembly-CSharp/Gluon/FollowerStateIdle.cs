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
	public class FollowerStateIdle : IState<Gluon.FollowerController>
	{
		// Fields
		private MoveState moveState;
		private float moveStateTimer;
		private float moveMargin;
		protected Vector3 targetPos;
		private Vector3 prevPos;
		private float stayTimer;
		protected bool updateTargetPos;
	
		// Nested types
		private enum MoveState
		{
			Stop = 0,
			Walk = 1,
			Run = 2,
			GiveUpRun = 3,
			PathPending = 4
		}
	
		// Constructors
		public FollowerStateIdle();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateExit();
		public override void OnStateUpdate();
		protected void UpdateMove(bool updateTargetPos, bool ignoreMoveMargin);
		protected void Stop();
		public void UpdateTargetPos();
	}
}
