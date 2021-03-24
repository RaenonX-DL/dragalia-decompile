/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DifferenceImageController : MonoBehaviour
	{
		// Fields
		[Range]
		[SerializeField]
		private float _ImageScale;
		[SerializeField]
		private DifferenceImageObject _differenceImageObject;
		[SerializeField]
		private PartsDispData[] _partsDispDataTable;
		[SerializeField]
		private MaterialParameter _materialParameter;
		private GameObject _rootObject;
		private Transform _rootTransform;
		private DifferenceImageWorkData _baseImageWorkData;
		private List<DifferenceImageWorkData> _partsImageWorkData;
		private const int maxPartsString = 64;
		private static string[] texNameY;
		private static string[] texNameCb;
		private static string[] texNameCr;
		private static string[] texNameA;
		private static string[] texNameRGBA;
		private static string[] keywords;
		public static bool isUguiShaderNeeded;
	
		// Properties
		public DifferenceImageObject differenceImageObject { get; }
		public MaterialParameter materialParameter { get; set; }
		public bool isLoaded { get; }
	
		// Nested types
		[Serializable]
		public class MaterialParameter
		{
			// Fields
			public Color color;
			[Range]
			public float contrast;
			[Range]
			public float saturation;
			[Range]
			public float brightness;
			public Color screenTopColor;
			public Color screenButtomColor;
			[Range]
			public float screenColorSmoothMin;
			[Range]
			public float screenColorSmoothMax;
			public Color lastMulColor;
	
			// Constructors
			public MaterialParameter();
		}
	
		[Serializable]
		public class PartsDispData
		{
			// Fields
			public int partsGroupNo;
			public int[] frameNo;
			public Material material;
			public DifferenceImageObject.TextureIndex[] indexDataTable;
	
			// Constructors
			public PartsDispData();
		}
	
		// Constructors
		public DifferenceImageController();
	
		// Methods
		private void SetupStrings();
		private void Awake();
		public void SetPartsDispNo(int partsTableNo, int partsNo, int frameNo);
		public void SetPartsTexture();
		public void SetPartsGroupNo(int partsTableNo, int partsGroupNo);
		public void SetPartsFrame(int partsTableNo, int partsNo, int fameNo);
		public bool GetPartsTablePos(int partsTableNo, out Vector2 position);
		private void InstanceMaterial(Image image);
		private void UpdateMaterialParameter(Material material);
		private void CreateImageParts();
		public void Load(DifferenceImageObject differenceImageObject);
		private void Start();
		private void Update();
		public void SetScale(float scale);
		public void SetDefault();
		public void ConvertShaderForUgui();
		public void ConvertTransformForUgui();
		public void ShowParts(bool show);
		private void SetTextureFilter(Material material, int texID, FilterMode filter);
		private void SetTextureFilter(Material material, int texYID, int texCbID, int texCrID, int texAID, FilterMode filter);
		public void BlitToRenderTexture(RenderTexture renderTexture);
	}
}
