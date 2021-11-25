using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UIImageMaskToAlpha : MonoBehaviour
	{
		public class ImageData
		{
			public bool isCuteSprite;

			public Vector2 addOffset;
		}

		private bool _initializedFlag;

		private Image _maskImage;

		private Image[] _targetImageArray;

		private int _materialId_MaskTex;

		private float _canvasWidth;

		private ImageData[] _targetDataArray;

		public IEnumerator Start()
		{
			return null;
		}

		public Vector2 GetParentCanvasPixel(Transform parent)
		{
			return default(Vector2);
		}

		public void Initialize()
		{
		}

		public void ResetImageDataQue()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateMaterial()
		{
		}
	}
}
