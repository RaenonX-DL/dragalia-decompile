using System;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	[CreateAssetMenu]
	public class ShaderLodDataObject : ScriptableObject
	{
		[Serializable]
		public class SwitchShaderData
		{
			[Tooltip("è¡\u00a8ç¤ºå\u0090\u008d")]
			public string name;

			[Tooltip("ã\u0083\u0087ã\u0083\u0095ã\u0082©ã\u0083«ã\u0083\u0088æ\u0099\u0082ã\u0081®ã\u0082·ã\u0082§ã\u0083¼ã\u0083\u0080")]
			public Shader defaultShader;

			[Tooltip("ã\u0082·ã\u0083«ã\u0082\u00a8ã\u0083\u0083ã\u0083\u0088ä»\u0098ã\u0081\u008dã\u0081®ã\u0082·ã\u0082§ã\u0083¼ã\u0083\u0080")]
			public Shader silhouetteShader;

			[Tooltip("ã\u0083ªã\u0083\u0083ã\u0083\u0081ç\u0094\u00a8ã\u0081®ã\u0082·ã\u0082§ã\u0083¼ã\u0083\u0080")]
			public Shader richShader;

			[Tooltip("ã\u0082·ã\u0083«ã\u0082\u00a8ã\u0083\u0083ã\u0083\u0088ä»\u0098ã\u0081\u008dã\u0083ªã\u0083\u0083ã\u0083\u0081ç\u0094\u00a8ã\u0082·ã\u0082§ã\u0083¼ã\u0083\u0080")]
			public Shader silhouetteRichShader;
		}

		[SerializeField]
		[Tooltip("ã\u0082·ã\u0082§ã\u0083¼ã\u0083\u0080LODã\u0083\u0087ã\u0083¼ã\u0082¿ã\u0083ªã\u0082¹ã\u0083\u0088")]
		private ShaderLevelData[] _shaderLevelDataList;

		[SerializeField]
		[Tooltip("ç\u0084¡è¦\u0096ã\u0081\u0099ã\u0082\u008bã\u0082·ã\u0082§ã\u0083¼ã\u0083\u0080ã\u0083ªã\u0082¹ã\u0083\u0088")]
		private Shader[] _shaderIgnoreList;

		[SerializeField]
		[Tooltip("å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082·ã\u0082§ã\u0083¼ã\u0083\u0080ã\u0083\u0087ã\u0083¼ã\u0082¿")]
		private SwitchShaderData[] switchShaderDataArray;

		public Shader GetSilhouetteSwitchShader(Shader shader, bool isDefault)
		{
			return null;
		}

		public SwitchShaderData GetSwitchShaderData(Shader shader)
		{
			return null;
		}

		public ShaderLevelLodData GetLodShader(Shader originalShader, LodLevel level)
		{
			return default(ShaderLevelLodData);
		}
	}
}
