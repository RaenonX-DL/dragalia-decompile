/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FollowerStateWalkerIdle : IState<Gluon.FollowerController>
	{
		// Fields
		private MoveState moveState;
		private float moveStateTimer;
		private float moveMargin;
		protected Vector3 targetPos;
		private Vector3 prevPos;
		private float stayTimer;
		private Transform walkerTarget;
		private bool caught;
		private bool giveUp;
		private NavMeshPath checkPath;
		private const string stateName_Catch = "skill_C";
		private const string stateName_Pass = "skill_B";
		private const string stateName_Wait = "skill_D";
	
		// Nested types
		private enum MoveState
		{
			Stop = 0,
			Walk = 1,
			Run = 2,
			GiveUpRun = 3,
			PathPending = 4,
			GiveUpCatch = 5,
			Catch = 6,
			PassToChara = 7
		}
	
		// Constructors
		public FollowerStateWalkerIdle();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateUpdate();
		protected void UpdateMove();
		protected void Stop();
		private void BackToChara();
	}
}
