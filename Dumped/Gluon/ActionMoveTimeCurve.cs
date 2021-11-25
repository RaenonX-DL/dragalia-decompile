using UnityEngine;

namespace Gluon
{
	public class ActionMoveTimeCurve : ActionMoveBase
	{
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

		public void Initialize(CharacterBase chara, bool isNormalizeCurve, Vector3 distance, float height, float duration, AnimationCurve curveX, AnimationCurve curveY, AnimationCurve curveZ, int property)
		{
		}

		public override void Stop()
		{
		}

		protected override void OnStart()
		{
		}

		protected override void OnFinish()
		{
		}

		protected override bool OnFixedUpdate(float delta)
		{
			return default(bool);
		}

		private void SetupSlip()
		{
		}
	}
}
