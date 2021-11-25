using UnityEngine;

namespace SPFX
{
	public class SPFXCameraSimple : MonoBehaviour
	{
		private Camera RefCamera;

		public Light TargetLight;

		public float SceneLightScale;

		public float SceneAmbientScale;

		public eDrawLayer[] DrawLayerTable;

		private bool RequiredBillboardCamera;

		public bool RequireBillboardCamera;

		public bool RotV_DirectX;

		public bool RotV_Metal;

		[SerializeField]
		private bool UseTryRendering;

		protected SPFXCameraSimple()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnPostRender()
		{
		}
	}
}
