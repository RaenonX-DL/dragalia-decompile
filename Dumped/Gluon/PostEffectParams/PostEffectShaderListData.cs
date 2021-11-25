using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon.PostEffectParams
{
	[Serializable]
	public class PostEffectShaderListData
	{
		private Shader shaderPostBaseOnlyStandardEffect;

		private Shader shaderPostBloom;

		private Shader shaderPostDofBloom;

		private Shader shaderPostTiltShiftBloom;

		private Shader shaderPostTiltShiftPointIrisBloom;

		public Material materialPostOnlyStandardEffect
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Material materialPostBloom
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Material materialPostDofBloom
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Material materialPostTiltShiftBloom
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Material materialPostTiltShiftPointIrisBloom
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		private Shader FindCheckShader(Shader srcShader, string name)
		{
			return null;
		}

		public void CreateMaterials(PostEffectsBase postEffectBase)
		{
		}
	}
}
