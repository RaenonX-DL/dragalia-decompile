using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DropViewController : MonoBehaviour
	{
		public delegate void dropMovedDelegate(int dropType, long startValue, int value);

		public Vector2 widthXRange;

		public Vector2 topYRange;

		public Vector2 bottomYRange;

		[SerializeField]
		private float jumpDurationDiffRange;

		[SerializeField]
		private Sprite[] coinAnimImages;

		[SerializeField]
		private float coinPopupAnimSpeedChangeRatio;

		[SerializeField]
		private int coinPopupAnimFirstSpeed;

		[SerializeField]
		private int coinPopupAnimSecondSpeed;

		[SerializeField]
		private AnimationCurve scaleAnimCurveX;

		[SerializeField]
		private AnimationCurve scaleAnimCurveY;

		[SerializeField]
		private Vector3[] staminaPos;

		[SerializeField]
		private float[] staminaScale;

		[SerializeField]
		private CanvasGroup canvasGroup;

		private Image coinImage;

		private int curCoinImageIndex;

		protected dropMovedDelegate dropMovedCallback;

		private const float moveTime = 0.5666667f;

		private const float delayUnit = 0.05f;

		private int dropType;

		private int addValue;

		private long startValue;

		public virtual void AddDropMovedCallback(dropMovedDelegate callback)
		{
		}

		private void Start()
		{
		}

		public void StartMoveAnim(int dropType, long startValue, int addValue, float delayIndex, Vector3 target, MaterialHarvester.HarvestType harvestType, Transform parentFacilityTrans)
		{
		}

		public void StartStaminaMoveAnim(int delayIndex, Vector3 target)
		{
		}

		private void ReflectParentMovement(Transform parentTrans, Vector3 initialScreenPos)
		{
		}

		private void ExchangeCoinImage(int imageNumPerFrame)
		{
		}

		private void OnMoveFinished()
		{
		}
	}
}
