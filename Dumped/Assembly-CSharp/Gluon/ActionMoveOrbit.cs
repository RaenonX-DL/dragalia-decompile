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
	public class ActionMoveOrbit : ActionInterval
	{
		// Fields
		private ActionMoveExecution moveExec;
		private GameObject _goAnchor;
		private GameObject _goMovePoint;
		private float _rotateSpeed;
		private float _winchSpeed;
	
		// Constructors
		public ActionMoveOrbit(Vector3 anchor, float rotateSpeed, float winchSpeed);
	
		// Methods
		public override void Stop();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
	}
}
