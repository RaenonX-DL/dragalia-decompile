using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	[CreateAssetMenu]
	public class ShaderDictionaryObject : ScriptableObject
	{
		public class ShaderKeywords
		{
			public string[][] keywords;
		}

		[Serializable]
		public class ShaderInfo
		{
			public string name;

			public Shader shader;

			public TextAsset shaderKeywordList;

			[TextArea]
			public string assetPath;

			[NonSerialized]
			public ShaderKeywords shaderKeywords;
		}

		private static readonly string[] _emptyKeywords;

		[SerializeField]
		private ShaderInfo[] _shaderInfos;

		private Dictionary<string, Shader> _shaderDictionary;

		public ShaderInfo[] shaderInfos
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void AddShaderVariant(ShaderVariantCollection shaderVariantCollection, ShaderInfo shaderInfo, Shader overrideShader)
		{
		}

		public ShaderVariantCollection CreateShaderVariantCollection(List<Shader> overrideShaderList)
		{
			return null;
		}

		public static int SortShaderInfo(ShaderInfo a, ShaderInfo b)
		{
			return default(int);
		}

		public void InitShaderDictionary()
		{
		}

		public bool WarmUpShaderVariantCollection(List<Shader> overrideShader)
		{
			return default(bool);
		}

		public Shader Find(string shaderName)
		{
			return null;
		}

		public static ShaderDictionaryObject LoadInitInstantiate(string path)
		{
			return null;
		}
	}
}
