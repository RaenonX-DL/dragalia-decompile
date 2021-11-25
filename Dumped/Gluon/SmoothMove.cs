using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class SmoothMove
	{
		private Vector3 startPosition;

		private Vector3 endPosition;

		private Transform targetTransform;

		private float duration;

		private float stepTime;

		public TweenType tweenType
		{
			[CompilerGenerated]
			get
			{
				return default(TweenType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isFinished
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SmoothMove(Transform transform, Vector3 startPos, Vector3 endPos, float duration)
		{
		}

		public void Update()
		{
		}

		protected float GetTweenTime(float delta)
		{
			return default(float);
		}
	}
}
