using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class DestroyMotionData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private string _motionState;

		[SerializeField]
		[HideInInspector]
		private bool _isEndSyncMotion;

		[SerializeField]
		[HideInInspector]
		private float _blendDuration;

		[SerializeField]
		[HideInInspector]
		private bool _isBlend;

		public string motion => null;

		public bool isEndSyncMotion => default(bool);

		public float blendDuration => default(float);

		public bool isBlend => default(bool);
	}
}
