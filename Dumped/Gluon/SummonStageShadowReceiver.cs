using UnityEngine;

namespace Gluon
{
	public class SummonStageShadowReceiver : MonoBehaviour
	{
		public class ShadowSetting
		{
			public float farDistance;

			public bool followXZPosition;

			public float scaleMaxVal;

			public float offsetY;

			public float offsetX;

			public float offsetZ;

			public bool isDirectPosition;

			public bool applyAmuletShot2Offset;
		}

		private readonly Vector3 amuletShadowShot2Offset;

		public ShadowSetting shadowSetting;

		private Vector3 beginPosition;

		private SummonStageShadowEmitter _emitter;

		public SummonStageShadowEmitter emitter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Awake()
		{
		}

		public void Update()
		{
		}
	}
}
