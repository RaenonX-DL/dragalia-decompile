/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsMoveTarget : ActionParts
	{
		// Fields
		private MoveTargetData _partsData;
		private Vector3 _targetPos;
		private Vector3 _basePos;
		private float _moveDistance;
		private float _speedRate;
		private float _velocity;
	
		// Constructors
		public ActionPartsMoveTarget(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		public override void Clear();
		protected override void OnFinish();
		private void UpdateTarget();
		protected override bool OnUpdate(float delta);
	}
}
