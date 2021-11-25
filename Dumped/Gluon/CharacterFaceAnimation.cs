using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class CharacterFaceAnimation
	{
		public enum Type
		{
			Blink,
			Once,
			Type1,
			Type2,
			Type3,
			Type1To2,
			Type2To4,
			Direct
		}

		private class AnimationTableData
		{
			public int intervalMin;

			public int intervalMax;

			public int intervalRatio;

			public int[] textureIndex;

			public Vector2[] offset;
		}

		private delegate Vector2 FaceIndexToOffsetDelegate(int index);

		private Type animationType;

		private MaterialPropertyData _materialPropertyData;

		private float currentTime;

		private const int keepFrame = 4;

		private const float targetFps = 60f;

		private float blinkIntervalTime;

		private bool isBlinkContinue;

		private AnimationTableData tableData;

		private FaceIndexToOffsetDelegate faceIndexToOffset;

		public CharacterFaceAnimation(bool isCharacter)
		{
		}

		public void SetMaterialPropertyData(MaterialPropertyData materialPropertyData)
		{
		}

		private void SetFaceAnimation(Type animationType)
		{
		}

		private Vector2 FaceIndexToOffsetCharacter(int index)
		{
			return default(Vector2);
		}

		private Vector2 FaceIndexToOffsetDragon(int index)
		{
			return default(Vector2);
		}

		public void SetFaceAnimation(CharaFaceEye expressionType)
		{
		}

		public void SetFaceAnimation(CharaFaceMouth expressionType)
		{
		}

		public void UpdateAnimation()
		{
		}

		private void UpdateBlink()
		{
		}

		private void UpdateOnce()
		{
		}

		public void SetFaceDirect(int index)
		{
		}
	}
}
