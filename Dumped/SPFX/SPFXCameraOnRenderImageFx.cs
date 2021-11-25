using UnityEngine;

namespace SPFX
{
	public class SPFXCameraOnRenderImageFx : MonoBehaviour
	{
		public enum MaterialPassName
		{
			DepthTexture,
			MainTextureBase,
			MainTextureSideY
		}

		private Camera RefCamera;

		private bool RequiredBillboardCamera;

		[Header("â\u0096\u00a0 Lighting Info")]
		public Light TargetLight;

		public float SceneLightScale;

		public float SceneAmbientScale;

		[Header("â\u0096\u00a0 VFX Draw Layer")]
		public eDrawLayer[] DrawLayersBefore;

		public eDrawLayer[] DrawLayersAfter;

		[Header("â\u0096\u00a0 Billboard Target Camera")]
		public bool BillboardCamera;

		[Header("â\u0096\u00a0 Debug information")]
		public eDebugInfoType DebugInfoType;

		[Header("â\u0096\u00a0 Material")]
		private Shader CopyShader;

		public Material CopyMaterial;

		private int _DepthPass;

		private int _ColorPass;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
