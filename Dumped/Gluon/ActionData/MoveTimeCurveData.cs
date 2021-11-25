using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class MoveTimeCurveData : ActionParts.PartsData
	{
		public enum MoveStyle
		{
			Normal,
			SafeCollider,
			Ignore,
			Teleport,
			ThroughChara
		}

		[SerializeField]
		[HideInInspector]
		private bool _isNormalizeCurve;

		[SerializeField]
		[HideInInspector]
		private Vector3 _position;

		[SerializeField]
		[HideInInspector]
		private float _height;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _timeCurveToSide;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _timeCurveToHeight;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _timeCurveToForward;

		[SerializeField]
		[HideInInspector]
		private bool _toTarget;

		[SerializeField]
		[HideInInspector]
		private bool _toRegisterPosition;

		[SerializeField]
		[HideInInspector]
		private bool _toGround;

		[SerializeField]
		[HideInInspector]
		private Vector3 _toTargetOffset;

		[SerializeField]
		[HideInInspector]
		private float _minimumLength;

		[SerializeField]
		[HideInInspector]
		private bool _cancelOffset;

		[SerializeField]
		[HideInInspector]
		private float _curveScale;

		[SerializeField]
		[HideInInspector]
		private bool _flipX;

		[SerializeField]
		[HideInInspector]
		private MoveStyle _moveStyle;

		public bool isNormalizeCurve => default(bool);

		public Vector3 position => default(Vector3);

		public float height => default(float);

		public AnimationCurve timeCurveToSide => null;

		public AnimationCurve timeCurveToHeight => null;

		public AnimationCurve timeCurveToForward => null;

		public bool toTarget => default(bool);

		public bool toRegisterPosition => default(bool);

		public bool toGround => default(bool);

		public Vector3 toTargetOffset => default(Vector3);

		public float minimumLength => default(float);

		public bool cancelOffset => default(bool);

		public float curveScale => default(float);

		public bool flipX => default(bool);

		public MoveStyle moveStyle => default(MoveStyle);
	}
}
