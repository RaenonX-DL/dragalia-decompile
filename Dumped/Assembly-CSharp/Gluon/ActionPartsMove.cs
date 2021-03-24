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
	public class ActionPartsMove : ActionParts
	{
		// Fields
		private readonly MoveData _partsData;
		private ActionMove _move;
		private RandomXorshift _random;
		private RunActionRandomParameter _runActionParam;
	
		// Constructors
		public ActionPartsMove(ActionParts resource);
	
		// Methods
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		public override void Clear();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		protected override bool OnFixedUpdate(float delta);
		private Vector3 CalculateStartPosition();
		public override void Stop();
		private void SetupTeleport(out Vector3 position, out Vector3 direction);
		private void CalcMovePosition(Vector3 start, ref Vector3 end, ref float duration);
	}
}
