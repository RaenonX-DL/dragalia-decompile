/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[ExecuteAlways]
	[RequireComponent]
	public abstract class PostEffectsBase : FixedImageEffect
	{
		// Fields
		protected bool supportHDRTextures;
		protected bool supportDX11;
		protected bool isSupported;
		private bool mStarted;
	
		// Constructors
		protected PostEffectsBase();
	
		// Methods
		public Material CheckShaderAndCreateMaterial(Shader s, Material m2Create);
		public Material CreateMaterial(Shader s, Material m2Create);
		public bool CheckSupport();
		public abstract bool CheckResources();
		public bool CheckSupport(bool needDepth);
		public bool CheckSupport(bool needDepth, bool needHdr);
		public bool Dx11Support();
		public void ReportAutoDisable();
		public bool CheckShader(Shader s);
		public void NotSupported();
		public void DrawBorder(RenderTexture dest, Material material);
		private void OnEnable();
		protected override void Awake();
	}
}
