/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CriMana;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace CriMana.Detail
{
	public class RendererResourceAndroidSofdecPrimeYuvLegacyGles2 : RendererResource
	{
		// Fields
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
		private Shader shader;
		private Vector4 movieTextureST;
		private Vector4 movieChromaTextureST;
		private Vector4 movieAlphaTextureST;
		private Texture2D[] textureY;
		private Texture2D[] textureU;
		private Texture2D[] textureV;
		private Texture2D[] textureA;
		private IntPtr[][] nativeTextures;
		private Material currentMaterial;
		private int srcBlendMode;
		private int dstBlendMode;
		private int numTextureSets;
		private int currentTextureSet;
		private int drawTextureSet;
		private int playerID;
	
		// Constructors
		public RendererResourceAndroidSofdecPrimeYuvLegacyGles2(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
	
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
		private void UpdateMovieTextureST(uint dispWidth, uint dispHeight);
		public override void UpdateTextures();
		private static void CalculateTextureSize(ref int w, ref int h, int videoWidth, int videoHeight, CodecType type, bool isChroma);
	}
}
