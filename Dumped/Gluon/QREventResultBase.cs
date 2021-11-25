using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class QREventResultBase : MonoBehaviour
	{
		[SerializeField]
		protected RectTransform topInfoTrans;

		[SerializeField]
		protected RectTransform gotRewardTrans;

		[SerializeField]
		protected RectTransform charaTrans;

		[SerializeField]
		protected RectTransform seriTrans;

		[SerializeField]
		protected UIAnimationPublisher publisher;

		[SerializeField]
		protected Image commonIconEffectImage;

		protected float enterDuration;

		protected float exitDuration;

		protected float moveUpDuration;

		protected float moveUpDistance;

		private float commonIconEffectDuration;

		public float overshootOrAmplitudeCustom;

		private CustomEaseFunction _easeFunction;

		protected Color bonusTextColor;

		protected QuestResultTopPage resultTop;

		private bool isButtonSlidedIn;

		[SerializeField]
		private Image seriArrowImage;

		private Vector3 arrowInitPos;

		private Tweener arrowTweener;

		public CustomEaseFunction easeFunction => null;

		public int bonusValue
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected virtual void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public virtual void StartEnterAnimation(bool isFadeInOutAnimation, UnityAction onComplete)
		{
		}

		public virtual void StartExitAnimation(bool isFadeInOutAnimation, UnityAction onComplete)
		{
		}

		protected void MoveAndFade(RectTransform trans, bool isEnter, [Optional] UnityAction onComplete, float delay = 0f)
		{
		}

		protected void PlayGotRewardNumberAnimation(Text nowGetMedal, TweenCallback onComplete)
		{
		}

		protected void SlideInBottomButtons()
		{
		}

		protected void SetVisiblePageIcon(bool visible)
		{
		}

		protected IEnumerator WaitForPlayDifferenceImages(OutGameBgChara bgCharacter)
		{
			return null;
		}

		protected void ShowCommonIconEffectAnimation()
		{
		}
	}
}
