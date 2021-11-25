using UnityEngine;

namespace Gluon
{
	public class SimpleCharacterFacialControl : SimpleCharacterFacialControlBase
	{
		protected enum Type
		{
			Blink,
			Once
		}

		protected class AnimationTableData
		{
			public int intervalMin;

			public int intervalMax;

			public int intervalRatio;

			public int[] textureIndex;

			public Vector2[] offset;
		}

		protected Type animationType;

		protected float currentTime;

		protected const int keepFrame = 4;

		protected const float targetFps = 30f;

		protected float blinkIntervalTime;

		protected bool isBlinkContinue;

		protected AnimationTableData tableData;

		protected void UpdateOnce()
		{
		}

		protected void UpdateBlink()
		{
		}

		protected void SetFaceAnimation(Type animationType)
		{
		}

		protected static Vector2 FaceIndexToOffsetCharacter(int index)
		{
			return default(Vector2);
		}

		protected override void OnSetup(out Vector2 defaultTextureOffset)
		{
		}

		protected override bool OnLateUpdate(out Vector2 outTextureOffset)
		{
			return default(bool);
		}
	}
}
