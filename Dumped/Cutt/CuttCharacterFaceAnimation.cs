using Gluon;
using UnityEngine;

namespace Cutt
{
	public class CuttCharacterFaceAnimation
	{
		public enum Type
		{
			Blink,
			Once,
			Type1,
			Type2,
			Type3,
			Type1To2,
			Type2To4
		}

		public enum ModelType
		{
			HiModel,
			NormalModel
		}

		private class AnimationTableData
		{
			public int intervalMin;

			public int intervalMax;

			public int intervalRatio;

			public int[] textureIndex;

			public Vector2[] offset;
		}

		private CuttTimelineControl control;

		private Type animationType;

		private Material material;

		private float currentTime;

		private const int keepFrame = 2;

		private static readonly string propertyNameMainTex;

		private static readonly string propertyNameTextureY;

		private static readonly string propertyNameTextureCr;

		private static readonly string propertyNameTextureCb;

		private bool hasPropertyMainTex;

		private bool hasPropertyYCrCbTex;

		private float blinkIntervalTime;

		private bool isBlinkContinue;

		private AnimationTableData tableData;

		private CuttCharacterFaceData faceData;

		public void Release()
		{
		}

		public void SetMaterial(Material material, CuttCharacterFaceData faceData)
		{
		}

		public Vector2 FaceIndexToOffset(int index)
		{
			return default(Vector2);
		}

		private void SetFaceAnimation(CuttTimelineControl control, Type animationType, int startFrame)
		{
		}

		public void SetExpressionHiModel(CuttTimelineControl control, CuttCharaEye expressionType, Type animationType, int startFrame)
		{
		}

		public void SetExpressionHiModel(CuttTimelineControl control, CuttCharaMouth expressionType, Type animationType, int startFrame)
		{
		}

		public void SetExpressionNormalModel(CuttTimelineControl control, CharaFaceEye type, Type animationType, int startFrame)
		{
		}

		public void SetExpressionNormalModel(CuttTimelineControl control, CharaFaceMouth type, Type animationType, int startFrame)
		{
		}

		private void SetTexture(int textureIndex)
		{
		}

		public void SetTextureOffset(Vector2 offset)
		{
		}

		public void UpdateAnimation(int currentFrame)
		{
		}

		private void UpdateBlink(int currentFrame)
		{
		}

		private void UpdateOnce(int currentFrame)
		{
		}

		private void UpdateType1To2(int currentFrame)
		{
		}

		private void UpdateType2To4(int currentFrame)
		{
		}
	}
}
