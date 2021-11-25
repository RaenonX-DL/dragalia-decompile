using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class RotateNodeData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private string _nodeName;

		[SerializeField]
		[HideInInspector]
		private Vector3 _addLocalRotation;

		[SerializeField]
		[HideInInspector]
		private float _curveCycleSecond;

		[SerializeField]
		[HideInInspector]
		private float _curveCycleOffset;

		[SerializeField]
		[HideInInspector]
		private bool _riseWaveFlag;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _curve;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public string nodeName => null;

		public Vector3 addLocalRotation => default(Vector3);

		public float curveCycleSecond => default(float);

		public float curveCycleOffset => default(float);

		public bool riseWaveFlag => default(bool);

		public AnimationCurve curve => null;

		public bool guarantee => default(bool);
	}
}
