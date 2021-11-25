using UnityEngine;

namespace Gluon
{
	public class ChargeMarkerArrowCircle : ChargeMarker
	{
		private GameObject goArrow;

		private GameObject[] goPoint;

		private static readonly float[] pointLength;

		private const float maxArrowScale = 1.8f;

		protected override void Awake()
		{
		}

		protected override void SetPartsParam()
		{
		}

		public override void UpdatePosition(Vector3 pos)
		{
		}

		private bool UpdatePoint(int visibleNum, float len, Vector3 dir, float arrowScale)
		{
			return default(bool);
		}

		public override void SetImpactPosition()
		{
		}

		protected override void OnClose()
		{
		}
	}
}
