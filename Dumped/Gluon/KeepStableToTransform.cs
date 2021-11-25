using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	[ExecuteAlways]
	public class KeepStableToTransform : MonoBehaviour
	{
		private class TraceTargetInfo
		{
			public Vector3 position;

			public Quaternion rotation;

			public Vector3 localScale;

			public TraceTargetInfo(Vector3 position, Quaternion rotation, Vector3 localScale)
			{
			}

			public TraceTargetInfo(Transform t)
			{
			}
		}

		public Transform keepStableTo;

		public string findKeepInScene;

		public string specifySceneName;

		public bool ignoreZOffset;

		public bool onlyPosition;

		public bool stableOnFirstEnableState;

		public Vector3 freezeScale;

		public int traceDelayFrame;

		private Vector3 offset;

		private bool resetOnDisable;

		private bool initialOffsetSet;

		private List<TraceTargetInfo> delayedTracePosition;

		private void OnEnable()
		{
		}

		private IEnumerator OnEnableCoroutine()
		{
			return null;
		}

		private void OnDisable()
		{
		}

		public void FollowUp()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
