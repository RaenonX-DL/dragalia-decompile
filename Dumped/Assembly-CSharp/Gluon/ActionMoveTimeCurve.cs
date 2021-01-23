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
	public class ActionMoveTimeCurve : ActionMoveBase
	{
		// Fields
		private bool _isNormalizeCurve;
		private Vector3 _distance;
		private Vector3 _diffPos;
		private float _height;
		private float _duration;
		private float _elapsed;
		public AnimationCurve _timeCurveToSide;
		public AnimationCurve _timeCurveToHeight;
		public AnimationCurve _timeCurveToForward;
		private ActionMoveExecution moveExec;
	
		// Constructors
		public ActionMoveTimeCurve();
	
		// Methods
		public void Initialize(CharacterBase chara, bool isNormalizeCurve, Vector3 distance, float height, float duration, AnimationCurve curveX, AnimationCurve curveY, AnimationCurve curveZ, int property);
		public override void Stop();
		protected override void OnStart();
		protected override void OnFinish();
		protected override bool OnFixedUpdate(float delta);
		private void SetupSlip();
	}
}
