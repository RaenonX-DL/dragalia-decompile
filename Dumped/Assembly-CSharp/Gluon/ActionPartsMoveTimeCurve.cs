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
	public class ActionPartsMoveTimeCurve : ActionParts
	{
		// Fields
		private readonly MoveTimeCurveData _partsData;
		private ActionMoveTimeCurve _move;
	
		// Constructors
		public ActionPartsMoveTimeCurve(ActionParts resource);
	
		// Methods
		public override void Clear();
		protected override void OnFinish();
		public override void Stop();
		protected override void OnStart();
		protected override bool OnUpdate(float delta);
		protected override bool OnFixedUpdate(float delta);
		private void CalcDynamicDistance(ref Vector3 distance);
		private void CalcDynamicHeight(ref float height);
	}
}
