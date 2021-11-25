using UnityEngine;

namespace CriMana.Detail
{
	public class RendererResourceAndroidSofdecPrimeYuv : RendererResource
	{
		private int width;

		private int height;

		private int chromaWidth;

		private int chromaHeight;

		private int alphaWidth;

		private int alphaHeight;

		private bool hasAlpha;

		private bool additive;

		private bool applyTargetAlpha;

		private bool useUserShader;

		private CodecType codecType;

		private const TextureFormat format = TextureFormat.R8;

		private Shader shader;

		private Vector4 movieTextureST;

		private Vector4 movieChromaTextureST;

		private Vector4 movieAlphaTextureST;

		private Texture2D textureY;

		private Texture2D textureU;

		private Texture2D textureV;

		private Texture2D textureA;

		private Material currentMaterial;

		private int srcBlendMode;

		private int dstBlendMode;

		private int playerID;

		private bool areTexturesUpdated;

		private bool isFrameUpdated;

		public RendererResourceAndroidSofdecPrimeYuv(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
		{
		}

		protected override void OnDisposeManaged()
		{
		}

		protected override void OnDisposeUnmanaged()
		{
		}

		public override bool IsPrepared()
		{
			return default(bool);
		}

		public override bool ContinuePreparing()
		{
			return default(bool);
		}

		public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
		{
			return default(bool);
		}

		public override void SetApplyTargetAlpha(bool flag)
		{
		}

		public override void AttachToPlayer(int playerId)
		{
		}

		public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop)
		{
			return default(bool);
		}

		public override bool UpdateMaterial(Material material)
		{
			return default(bool);
		}

		private void UpdateMovieTextureST(uint dispWidth, uint dispHeight)
		{
		}

		public override void UpdateTextures()
		{
		}

		private static void CalculateTextureSize(ref int w, ref int h, int videoWidth, int videoHeight, CodecType type, bool isChroma)
		{
		}
	}
}
