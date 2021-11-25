using System;
using System.Collections.Generic;
using Gluon.Common;
using UnityEngine;

namespace Gluon
{
	[CreateAssetMenu]
	public class DifferenceImageObject : ScriptableObject
	{
		[Serializable]
		public enum TextureDataType
		{
			YUVA,
			RGBA
		}

		public enum TextureID
		{
			UnUse = -1,
			White = -2
		}

		[Serializable]
		public struct TextureIndex
		{
			public int colorIndex;

			public int alphaIndex;
		}

		[Serializable]
		public class BasePartsData
		{
			public Material material;

			public Vector2 size;

			public Rect rect;
		}

		[Serializable]
		public class PartsData
		{
			public string name;

			public Material material;

			public Vector2 position;

			public Vector2 size;

			public Size tileCount;

			public int partsCount;

			public int frameCount;

			public int indexOffset;

			public int partsGroupCount;
		}

		[Serializable]
		public struct YUVTexture2D
		{
			public Texture2D textureY;

			public Texture2D textureCb;

			public Texture2D textureCr;
		}

		[Serializable]
		public struct OutputTextureData
		{
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
			public int sourceId;

			public int convertId;
		}

		public TextureDataType textureDataType;

		public BasePartsData basePartsData;

		public PartsData[] partsDataTable;

		public TextureIndex[] partsTextureIndexTable;

		public YUVTexture2D[] partsYUVTextureTable;

		public Texture2D[] partsATextureTable;

		public Texture2D[] partsRGBATextureTable;

		public ConvertIndex[] ConvertIndexTable;

		public Dictionary<int, int> ConvertIndexDictionary;

		public void OnEnable()
		{
		}

		public OutputTextureData GetTexture(TextureIndex textureIndex)
		{
			return default(OutputTextureData);
		}

		public TextureIndex GetTextureIndex(int partsTableNo, int partsGroupNo, int partsNo, int frameNo)
		{
			return default(TextureIndex);
		}

		public bool SetTextureToPartsMaterial(int partsTableNo, int partsGroupNo, int partsNo, int frameNo)
		{
			return default(bool);
		}

		public bool SetTextureToPartsMaterial(int partsTableNo, int partsGroupNo, int frameNo)
		{
			return default(bool);
		}

		public bool IsEnablePartsDataTable(int index)
		{
			return default(bool);
		}
	}
}
