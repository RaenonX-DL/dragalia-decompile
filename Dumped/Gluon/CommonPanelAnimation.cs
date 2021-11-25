using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class CommonPanelAnimation : MonoBehaviour
	{
		public enum DirectionEnum
		{
			x,
			y
		}

		public static Sequence DoPanelFadeInUpwardAnimation(Transform t, float yDiff, float delay = 0f, float baseDuration = 0.5f)
		{
			return null;
		}

		public static Sequence DoPanelFadeOutUpwardAnimation(Transform t, float yDiff, float delay = 0f, float baseDuration = 0.5f)
		{
			return null;
		}

		public static Sequence DoPartExitToLeftAnimation(Transform t, float delay = 0f, float distance = 0f)
		{
			return null;
		}

		public static Sequence DoPartExitToBottomAnimation(Transform t, float delay = 0f, float distance = 0f)
		{
			return null;
		}

		public static Sequence DoFlashingAnimation(Transform t)
		{
			return null;
		}

		public static Sequence FadeOutAnimation(Transform t, float diff, float delay = 0f, float baseDuration = 0.5f, DirectionEnum direction = DirectionEnum.y, Ease ease = Ease.OutCubic)
		{
			return null;
		}

		public static Sequence FadeInAnimation(Transform t, float diff, float delay = 0f, float baseDuration = 0.5f, DirectionEnum direction = DirectionEnum.y, Ease ease = Ease.OutCubic)
		{
			return null;
		}

		public static Sequence FadeInAnimationXY(Transform t, Vector2 pos, Vector2 nextPos, float delay = 0f, float baseDuration = 0.5f, float nextBaseDuration = 0.5f, Ease ease = Ease.OutCubic, Ease nextEase = Ease.OutCubic)
		{
			return null;
		}
	}
}
