using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DifferenceImageController : MonoBehaviour
	{
		[Serializable]
		public class MaterialParameter
		{
			public Color color;

			public float contrast;

			public float saturation;

			public float brightness;

			public Color screenTopColor;

			public Color screenButtomColor;

			public float screenColorSmoothMin;

			public float screenColorSmoothMax;

			public Color lastMulColor;
		}

		[Serializable]
		public class PartsDispData
		{
			public int partsGroupNo;

			public int[] frameNo;

			public Material material;

			public DifferenceImageObject.TextureIndex[] indexDataTable;
		}

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

		public DifferenceImageObject differenceImageObject => null;

		public MaterialParameter materialParameter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isLoaded => default(bool);

		private void SetupStrings()
		{
		}

		private void Awake()
		{
		}

		public void SetPartsDispNo(int partsTableNo, int partsNo, int frameNo)
		{
		}

		public void SetPartsTexture()
		{
		}

		public void SetPartsGroupNo(int partsTableNo, int partsGroupNo)
		{
		}

		public void SetPartsFrame(int partsTableNo, int partsNo, int fameNo)
		{
		}

		public bool GetPartsTablePos(int partsTableNo, out Vector2 position)
		{
			return default(bool);
		}

		private void InstanceMaterial(Image image)
		{
		}

		private void UpdateMaterialParameter(Material material)
		{
		}

		private void CreateImageParts()
		{
		}

		public void Load(DifferenceImageObject differenceImageObject)
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void SetScale(float scale)
		{
		}

		public void SetDefault()
		{
		}

		public void ConvertShaderForUgui()
		{
		}

		public void ConvertTransformForUgui()
		{
		}

		public void ShowParts(bool show)
		{
		}

		private void SetTextureFilter(Material material, int texID, FilterMode filter)
		{
		}

		private void SetTextureFilter(Material material, int texYID, int texCbID, int texCrID, int texAID, FilterMode filter)
		{
		}

		public void BlitToRenderTexture(RenderTexture renderTexture)
		{
		}
	}
}
