using System;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public struct ShaderLevelLodData
	{
		public ShaderSwitchingType type;

		public Shader shader;
	}
}
