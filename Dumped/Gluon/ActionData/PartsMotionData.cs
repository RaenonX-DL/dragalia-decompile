using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class PartsMotionData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private string _motionState;

		[SerializeField]
		[HideInInspector]
		private int _motionFrame;

		[SerializeField]
		[HideInInspector]
		private float _blendDuration;

		[SerializeField]
		[HideInInspector]
		private bool _isBlend;

		[SerializeField]
		[HideInInspector]
		private bool _isEndSyncMotion;

		[SerializeField]
		[HideInInspector]
		private bool _isIgnoreFinishCondition;

		[SerializeField]
		[HideInInspector]
		private bool _isIdleAfterCancel;

		public string motion => null;

		public int motionFrame => default(int);

		public float blendDuration => default(float);

		public bool isBlend => default(bool);

		public bool isEndSyncMotion => default(bool);

		public bool isIgnoreFinishCondition => default(bool);

		public bool isIdleAfterCancel => default(bool);
	}
}
