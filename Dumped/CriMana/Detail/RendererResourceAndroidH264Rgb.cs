using System;
using UnityEngine;

namespace CriMana.Detail
{
	public class RendererResourceAndroidH264Rgb : RendererResource
	{
		private struct NativeTexture
		{
			public uint nativePtrRGB;

			public uint nativePtrA;

			public float[] texCoords;
		}

		private const int RenderEventAction_ATTACH = 769;

		private int playerId;

		private int width;

		private int height;

		private int dispWidth;

		private int dispHeight;

		private bool hasAlpha;

		private int alphaWidth;

		private int alphaHeight;

		private bool additive;

		private bool applyTargetAlpha;

		private bool useUserShader;

		private Shader shader;

		private Vector4 movieTextureST;

		private Vector4 alphaTextureST;

		private Texture2D textureRGB;

		private Texture2D textureA;

		private IntPtr[] nativePtrs;

		private bool needsUpdateTexture;

		private Material currentMaterial;

		private int srcBlendMode;

		private int dstBlendMode;

		private bool needsToDetachInitTexture;

		private bool areTexturesUpdated;

		public RendererResourceAndroidH264Rgb(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
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

		private void UpdateMovieTextureST(float[] texCoords, float dispWidth, float dispHeight)
		{
		}

		public override void UpdateTextures()
		{
		}

		public static bool IsSupported()
		{
			return default(bool);
		}

		private static extern bool criManaUnity_IsMediaCodecSupported_ANDROID(int device_type);

		private static extern uint criManaUnity_MediaCodecCreateTexture_ANDROID();

		private static extern void criManaUnity_MediaCodecDeleteTexture_ANDROID(uint oes_texture);

		private static extern bool criManaUnityPlayer_MediaCodecAttachTexture_ANDROID(int player_id, uint oes_texture);

		private static extern void criManaUnityPlayer_MediaCodecDetachTexture_ANDROID(int player_id, uint oes_texture);
	}
}
