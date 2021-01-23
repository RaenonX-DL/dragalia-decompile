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
	public class FollowerStateApproach : IState<Gluon.FollowerController>
	{
		// Fields
		private float elapsedSec;
		private bool playedEffect;
	
		// Constructors
		public FollowerStateApproach();
	
		// Methods
		public override void OnStateEnter();
		public override void OnStateExit();
		public override void OnStateUpdate();
		private bool CheckBRItem();
		private void SetMoveTarget(Vector3 moveTarget);
	}
}
