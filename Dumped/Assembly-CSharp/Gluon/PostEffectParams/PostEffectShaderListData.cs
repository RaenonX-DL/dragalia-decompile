/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.PostEffectParams
{
	[Serializable]
	public class PostEffectShaderListData
	{
		// Fields
		private Shader shaderPostBaseOnlyStandardEffect;
		[CompilerGenerated]
		private Material _materialPostOnlyStandardEffect_k__BackingField;
		private Shader shaderPostBloom;
		[CompilerGenerated]
		private Material _materialPostBloom_k__BackingField;
		private Shader shaderPostDofBloom;
		[CompilerGenerated]
		private Material _materialPostDofBloom_k__BackingField;
		private Shader shaderPostTiltShiftBloom;
		[CompilerGenerated]
		private Material _materialPostTiltShiftBloom_k__BackingField;
		private Shader shaderPostTiltShiftPointIrisBloom;
		[CompilerGenerated]
		private Material _materialPostTiltShiftPointIrisBloom_k__BackingField;
	
		// Properties
		public Material materialPostOnlyStandardEffect { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Material materialPostBloom { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Material materialPostDofBloom { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Material materialPostTiltShiftBloom { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Material materialPostTiltShiftPointIrisBloom { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	
		// Constructors
		public PostEffectShaderListData();
	
		// Methods
		private Shader FindCheckShader(Shader srcShader, string name);
		public void CreateMaterials(PostEffectsBase postEffectBase);
	}
}
