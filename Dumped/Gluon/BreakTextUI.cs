using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BreakTextUI : MonoBehaviour
	{
		private enum PlayMode
		{
			None,
			PlayingStart,
			Visible,
			PlayingEnd
		}

		[SerializeField]
		[Header("component")]
		private Image sparkImage;

		[SerializeField]
		private Image breakImage1;

		[SerializeField]
		private Image breakImage2;

		[SerializeField]
		[Header("parameter (chance)")]
		private Vector3 chanceScale0;

		[SerializeField]
		private float chanceTime0;

		[SerializeField]
		private Vector3 chanceScale1;

		[SerializeField]
		private float chanceTime1;

		[SerializeField]
		private Vector3 chanceScale2;

		[SerializeField]
		private float chanceTime2;

		[SerializeField]
		[Header("parameter (break)")]
		private Vector3 breakScale0;

		[SerializeField]
		private float breakRotz0;

		[SerializeField]
		private float breakTime0;

		[SerializeField]
		private Vector3 breakScale1;

		[SerializeField]
		private float sparkScale1;

		[SerializeField]
		private float breakTime1;

		[SerializeField]
		private Vector3 breakScale2;

		[SerializeField]
		private float breakTime2;

		private RectTransform sparkRT;

		private RectTransform breakRT1;

		private RectTransform breakRT2;

		private Tweener breakTweener;

		private Tweener chanceTweener;

		private PlayMode breakMode;

		public void Initialize()
		{
		}

		public void PlayBreak()
		{
		}

		public void StopBreak()
		{
		}

		public void Stop()
		{
		}

		public bool IsPlayBreak()
		{
			return default(bool);
		}

		public bool IsPlayChance()
		{
			return default(bool);
		}

		public bool IsVisibleBreak()
		{
			return default(bool);
		}

		private void StartBreak()
		{
		}

		private void OnUpdateBreak0(float v)
		{
		}

		private void OnCompleteBreak0()
		{
		}

		private void OnUpdateBreak1(float v)
		{
		}

		private void OnCompleteBreak1()
		{
		}

		private void EndBreak(bool immediate = false)
		{
		}

		private void OnUpdateBreak2(float v)
		{
		}

		private void OnCompleteBreak2()
		{
		}
	}
}
