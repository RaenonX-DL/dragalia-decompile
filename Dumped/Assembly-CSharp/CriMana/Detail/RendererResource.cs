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
	public abstract class RendererResource : IDisposable
	{
		// Fields
		private bool disposed;
	
		// Constructors
		protected RendererResource();
	
		// Methods
		~RendererResource();
		public void Dispose();
		private void Dispose(bool disposing);
		public int GetNumberOfFrameBeforeDestroy(int playerId);
		protected abstract void OnDisposeManaged();
		protected abstract void OnDisposeUnmanaged();
		public abstract bool IsPrepared();
		public abstract bool ContinuePreparing();
		public abstract void AttachToPlayer(int playerId);
		public abstract bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop);
		public abstract bool UpdateMaterial(Material material);
		public abstract void UpdateTextures();
		public abstract bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);
		public abstract void SetApplyTargetAlpha(bool flag);
		public virtual void OnPlayerPause(bool pauseStatus);
		public static uint NextPowerOfTwo(uint x);
		public static int NextPowerOfTwo(int x);
		public static int CeilingWith(int x, int ceilingValue);
		public static int Ceiling16(int x);
		public static int Ceiling32(int x);
		public static int Ceiling64(int x);
		public static int Ceiling256(int x);
		protected static extern bool CRIWARE597BC8D5(int player_id, int num_textures, IntPtr[] tex_ptrs, [In, Out] FrameInfo frame_info, ref bool frame_drop);
		protected static extern bool CRIWARE09E7841E(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs);
		protected static extern bool CRIWAREA3ECA824(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs);
		protected static extern bool CRIWARE20C11B9A(int player_id, int num_textures, [In, Out] IntPtr[] tex_ptrs);
		protected static extern sbyte CRIWAREA77B4237(int player_id);
	}
}
