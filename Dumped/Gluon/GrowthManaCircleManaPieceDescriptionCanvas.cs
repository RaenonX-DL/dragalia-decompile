using UnityEngine;

namespace Gluon
{
	public class GrowthManaCircleManaPieceDescriptionCanvas : MonoBehaviour
	{
		public GrowthManaCircleManaPieceDescription[] pointDescs;

		public GrowthManaCircleManaPieceDescription limitDesc;

		private RectTransform limitRect;

		private const float xPointOffset = 0f;

		private const float yPointOffset = -70f;

		private const float xLimitOffset = 0f;

		private const float yLimitOffset = -70f;

		private const float xMaxLimitOffset = 0f;

		private const float yMaxLimitOffset = -110f;

		private const float xPlusOffset = 0f;

		private const float yPlusOffset = 70f;

		public Camera mainCamera;

		private RectTransform rectTransform;

		public int endPieceIndex;

		public Vector2 endPieceDescOffset;

		public Vector2 allSecondPieceDescOffset;

		private void Start()
		{
		}

		private void SetPointDescPosition(int descIndex, Vector3 worldPos, Vector2 centerOffset, float xOffset = 0f, float yOffset = 70f)
		{
		}

		private void SetPointDescText(int descIndex, string titleStr, string mpStr, string subTitleStr)
		{
		}

		private void SetPointColor(int descIndex, Color bgColor, Color fontColor)
		{
		}

		private void SetPointDescAlpha(int descIndex, float alpha)
		{
		}

		private void SetPointDescScale(int descIndex, float scale)
		{
		}

		public void UpdatePointDesc(GrowthManaCircleModel model, GrowthManaCircleManaCircleObject circle, int centerTouchPointIndex, float rotateCenter, int numOfPoint)
		{
		}

		public void UpdatePointDesc(GrowthSecondManaCircleManaPieceObject[] points, float totalRotationY, int centerTouchPointIndex, float rotateCenter, int numOfPoint)
		{
		}

		public void UpdateLimitDesc(GrowthManaCircleMotifObject obj)
		{
		}

		public void ShowLimitDesc(bool arg)
		{
		}
	}
}
