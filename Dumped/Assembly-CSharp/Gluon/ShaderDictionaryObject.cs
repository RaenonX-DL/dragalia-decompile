/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CreateAssetMenu]
	public class ShaderDictionaryObject : ScriptableObject
	{
		// Fields
		private static readonly string[] _emptyKeywords;
		[SerializeField]
		private ShaderInfo[] _shaderInfos;
		private Dictionary<string, Shader> _shaderDictionary;
	
		// Properties
		public ShaderInfo[] shaderInfos { get; set; }
	
		// Nested types
		public class ShaderKeywords
		{
			// Fields
			public string[][] keywords;
	
			// Constructors
			public ShaderKeywords();
		}
	
		[Serializable]
		public class ShaderInfo
		{
			// Fields
			public string name;
			public Shader shader;
			public TextAsset shaderKeywordList;
			[TextArea]
			public string assetPath;
			[NonSerialized]
			public ShaderKeywords shaderKeywords;
	
			// Constructors
			public ShaderInfo();
		}
	
		// Constructors
		public ShaderDictionaryObject();
		static ShaderDictionaryObject();
	
		// Methods
		private void AddShaderVariant(ShaderVariantCollection shaderVariantCollection, ShaderInfo shaderInfo, Shader overrideShader);
		public ShaderVariantCollection CreateShaderVariantCollection(List<Shader> overrideShaderList);
		public static int SortShaderInfo(ShaderInfo a, ShaderInfo b);
		public void InitShaderDictionary();
		public bool WarmUpShaderVariantCollection(List<Shader> overrideShader);
		public Shader Find(string shaderName);
		public static ShaderDictionaryObject LoadInitInstantiate(string path);
	}
}
