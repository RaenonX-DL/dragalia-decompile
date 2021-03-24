/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsLoitering : ActionParts
	{
		// Fields
		private readonly LoiteringData _partsData;
		private Vector3 _targetPos;
		private Vector3 _basePos;
		private float _elapsedSec;
		private float _moveElapsedSec;
		private State _state;
		private Vector3 _orgFoward;
		private float _reprateDir;
		private Vector3 _orgPos;
		private RandomXorshift _random;
		private RunActionRandomParameter _runActionParam;
	
		// Nested types
		private enum State
		{
			idle = 0,
			turn = 1,
			moving = 2,
			motionSync = 3
		}
	
		// Constructors
		public ActionPartsLoitering(ActionParts resource);
	
		// Methods
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		private void UpdateMove(float delta);
	}
}
