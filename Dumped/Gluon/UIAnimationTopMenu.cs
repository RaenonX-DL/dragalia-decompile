using UnityEngine;

namespace Gluon
{
	public class UIAnimationTopMenu : UIAnimationBase
	{
		protected Vector3 startRotation;

		protected Vector3 vanishingPointInCanvas;

		protected float exitVanishingT;

		protected float enterScale;

		protected float enterOffsetScale;

		protected float exitScale;

		protected float enterShakePostOverrunExtension;

		protected Vector3 enterShakeRotationStart;

		protected float enterVanishingT => default(float);

		protected override void Awake()
		{
		}

		public override void RecordCurrentStateAsDefault()
		{
		}

		public override void ResetUIAnimations()
		{
		}

		public Vector3 GetWorldVanishingPoint()
		{
			return default(Vector3);
		}

		public Vector3 GetWorldRectTransformCenter()
		{
			return default(Vector3);
		}

		public Vector3 GetWorldEnterPosition(Vector3 worldVanishingPoint, Vector3 centerStartWorldPos)
		{
			return default(Vector3);
		}

		public Vector3 GetWorldExitPosition(Vector3 worldVanishingPoint, Vector3 centerStartWorldPos)
		{
			return default(Vector3);
		}

		private void ReCalculateVanishingPoint()
		{
		}

		protected override void OnReadyToCalculatePosition()
		{
		}

		protected override void JoinEnterAnimation()
		{
		}

		protected override void JoinExitCanvasGroupAnimation()
		{
		}

		protected override float AppendExtraToEnterAnimation()
		{
			return default(float);
		}
	}
}
