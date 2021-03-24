/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Common;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[CreateAssetMenu]
	public class DifferenceImageObject : ScriptableObject
	{
		// Fields
		public TextureDataType textureDataType;
		public BasePartsData basePartsData;
		public PartsData[] partsDataTable;
		public TextureIndex[] partsTextureIndexTable;
		public YUVTexture2D[] partsYUVTextureTable;
		public Texture2D[] partsATextureTable;
		public Texture2D[] partsRGBATextureTable;
		public ConvertIndex[] ConvertIndexTable;
		public Dictionary<int, int> ConvertIndexDictionary;
	
		// Nested types
		[Serializable]
		public enum TextureDataType
		{
			YUVA = 0,
			RGBA = 1
		}
	
		public enum TextureID
		{
			White = -2,
			UnUse = -1
		}
	
		[Serializable]
		public struct TextureIndex
		{
			// Fields
			public int colorIndex;
			public int alphaIndex;
		}
	
		[Serializable]
		public class BasePartsData
		{
			// Fields
			public Material material;
			public Vector2 size;
			public Rect rect;
	
			// Constructors
			public BasePartsData();
		}
	
		[Serializable]
		public class PartsData
		{
			// Fields
			public string name;
			public Material material;
			public Vector2 position;
			public Vector2 size;
			public Size tileCount;
			public int partsCount;
			public int frameCount;
			public int indexOffset;
			public int partsGroupCount;
	
			// Constructors
			public PartsData();
		}
	
		[Serializable]
		public struct YUVTexture2D
		{
			// Fields
			public Texture2D textureY;
			public Texture2D textureCb;
			public Texture2D textureCr;
		}
	
		[Serializable]
		public struct OutputTextureData
		{
			// Fields
			public TextureDataType textureDataType;
			public Texture2D textureRGBA;
			public Texture2D textureY;
			public Texture2D textureCb;
			public Texture2D textureCr;
			public Texture2D textureA;
		}
	
		[Serializable]
		public struct ConvertIndex
		{
			// Fields
			public int sourceId;
			public int convertId;
		}
	
		// Constructors
		public DifferenceImageObject();
	
		// Methods
		public void OnEnable();
		public OutputTextureData GetTexture(TextureIndex textureIndex);
		public TextureIndex GetTextureIndex(int partsTableNo, int partsGroupNo, int partsNo, int frameNo);
		public bool SetTextureToPartsMaterial(int partsTableNo, int partsGroupNo, int partsNo, int frameNo);
		public bool SetTextureToPartsMaterial(int partsTableNo, int partsGroupNo, int frameNo);
		public bool IsEnablePartsDataTable(int index);
	}
}
