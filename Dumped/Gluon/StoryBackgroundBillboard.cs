using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class StoryBackgroundBillboard : MonoBehaviour
	{
		public Tweener currentTween;

		[SerializeField]
		public MeshFilter meshFilter;

		[SerializeField]
		public MeshRenderer meshRenderer;

		[SerializeField]
		public TextureScroll textureScroll;

		private bool completeVisible;

		private Vector2 completePosition;

		public float initPosZ;

		public static float posOffsetY;

		public string layerName;

		public string assetName;

		public Vector2[] defaultUVs;

		private Material defaultMaterial;

		public const int scrollDataMainIndex = 0;

		public Vector2 offsetUV;

		private void Awake()
		{
		}

		public void SetDefault()
		{
		}

		public void SetMoveToPos(Vector3 moveTo, float sec, Ease ease = Ease.Linear)
		{
		}

		public void SetBackgroundLayerData(BackgroundImageLayerObject.BackgroundImageLayer layerData, string assetName)
		{
		}

		public DifferenceImageController.MaterialParameter GetCharaColorParameter()
		{
			return null;
		}

		public void SetCompleteData()
		{
		}

		public void SetPosition(Vector2 pos)
		{
		}

		public void SetVisible(bool visible)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
