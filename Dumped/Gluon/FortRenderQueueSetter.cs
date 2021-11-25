using UnityEngine;

namespace Gluon
{
	[ExecuteAlways]
	public class FortRenderQueueSetter : MonoBehaviour
	{
		public enum RenderQueueType
		{
			Background = 1000,
			Geometry = 2000,
			AlphaTest = 2450,
			Transparent = 3000,
			Overlay = 4000
		}

		[SerializeField]
		private RenderQueueType renderQueue;

		[SerializeField]
		private int additionalOrder;

		private Renderer[] myRenderers;

		[SerializeField]
		private bool isMaterialShared;

		private void Start()
		{
		}

		private void OnValidate()
		{
		}

		public void SetRenderQueueToAllMaterials()
		{
		}
	}
}
