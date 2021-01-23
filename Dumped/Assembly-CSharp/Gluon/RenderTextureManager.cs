/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RenderTextureManager : FastUpdateMonoBehaviour
	{
		// Fields
		private const CameraLabelFlags CameraLabelFlagsNone = ;
		private const CameraLabelFlags CameraLabelFlagsAll = CameraLabelFlags.Main | CameraLabelFlags.Story3D | CameraLabelFlags.Story2D;
		[SerializeField]
		[Tooltip]
		private RenderTextureData[] _renderTextureData;
		private Dictionary<string, RenderTextureData> _renderTextureDataDictionary;
		[CompilerGenerated]
		private RenewRenderTexture eventRenewRenderTexture;
	
		// Events
		public event RenewRenderTexture eventRenewRenderTexture {
			add;
			remove;
		}
	
		// Nested types
		[Flags]
		public enum CameraLabelFlags
		{
			Main = 1,
			Story3D = 2,
			Story2D = 4
		}
	
		[Serializable]
		private class RenderTextureData
		{
			// Fields
			[Tooltip]
			public string name;
			[Tooltip]
			public Vector2Int size;
			[Tooltip]
			public int depth;
			[Tooltip]
			public bool isAlwaysScreenSize;
			[EnumFlags]
			[Tooltip]
			public CameraLabelFlags createFlags;
			[Tooltip]
			public RenderTextureFormat format;
			[NonSerialized]
			public RenderTexture renderTexture;
	
			// Constructors
			public RenderTextureData();
		}
	
		public delegate bool RenewRenderTexture(RenderTexture oldTexture, RenderTexture newTexture);
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static RenewRenderTexture __9__16_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _.ctor_b__16_0(RenderTexture _p0_, RenderTexture _p1_);
		}
	
		// Constructors
		public RenderTextureManager();
	
		// Methods
		public void CreateTexture(CameraLabelFlags createFlags);
		public void ReleaseTexture(CameraLabelFlags releaseFlags);
		private void OnDestroy();
		public RenderTexture GetRenderTexture(int id);
		public RenderTexture GetRenderTexture(string name);
		public override void FastUpdate();
	}
}
