/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CriMana;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CriMana.Detail
{
	public class RendererResourceAndroidH264Rgb : RendererResource
	{
		// Fields
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
	
		// Nested types
		private struct NativeTexture
		{
			// Fields
			public uint nativePtrRGB;
			public uint nativePtrA;
			public float[] texCoords;
		}
	
		// Constructors
		public RendererResourceAndroidH264Rgb(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
	
		// Methods
		protected override void OnDisposeManaged();
		protected override void OnDisposeUnmanaged();
		public override bool IsPrepared();
		public override bool ContinuePreparing();
		public override bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
		public override void SetApplyTargetAlpha(bool flag);
		public override void AttachToPlayer(int playerId);
		public override bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop);
		public override bool UpdateMaterial(Material material);
		private void UpdateMovieTextureST(float[] texCoords, float dispWidth, float dispHeight);
		public override void UpdateTextures();
		public static bool IsSupported();
		private static extern bool criManaUnity_IsMediaCodecSupported_ANDROID(int device_type);
		private static extern uint criManaUnity_MediaCodecCreateTexture_ANDROID();
		private static extern void criManaUnity_MediaCodecDeleteTexture_ANDROID(uint oes_texture);
		private static extern bool criManaUnityPlayer_MediaCodecAttachTexture_ANDROID(int player_id, uint oes_texture);
		private static extern void criManaUnityPlayer_MediaCodecDetachTexture_ANDROID(int player_id, uint oes_texture);
	}
}
