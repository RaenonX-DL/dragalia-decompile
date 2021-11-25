using UnityEngine;

namespace Gluon
{
	[ExecuteAlways]
	public abstract class PostEffectsBase : FixedImageEffect
	{
		protected bool supportHDRTextures;

		protected bool supportDX11;

		protected bool isSupported;

		private bool mStarted;

		public Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		public Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		public bool CheckSupport()
		{
			return default(bool);
		}

		public abstract bool CheckResources();

		public bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		public bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		public bool Dx11Support()
		{
			return default(bool);
		}

		public void ReportAutoDisable()
		{
		}

		public bool CheckShader(Shader s)
		{
			return default(bool);
		}

		public void NotSupported()
		{
		}

		public void DrawBorder(RenderTexture dest, Material material)
		{
		}

		private void OnEnable()
		{
		}

		protected override void Awake()
		{
		}
	}
}
