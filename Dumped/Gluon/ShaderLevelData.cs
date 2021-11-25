using System;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class ShaderLevelData
	{
		public bool enable;

		public ShaderLevelLodData high2;

		public ShaderLevelLodData high1;

		public Shader[] originals;

		public ShaderLevelLodData low1;

		public ShaderLevelLodData low2;

		public ShaderLevelLodData low3;

		public ShaderLevelLodData GetLodShader(Shader originalShader, LodLevel level)
		{
			return default(ShaderLevelLodData);
		}
	}
}
