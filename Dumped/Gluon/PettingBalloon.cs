using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class PettingBalloon : MonoBehaviour
	{
		[SerializeField]
		public GameObject uiBalloon;

		public Text uiBalloonText;

		public AnimationUITalkWindow talkWindowAnimation;

		public DragonStrokeMain strokeMain;

		public float minimumBalloonSkipableTime;

		public float blockNextBalloonTime;

		private Coroutine showWindowCoroutine;

		private string voiceName;

		private float delay;

		private Action onVoiceDone;

		private string message;

		private float minimumDisplayTime;

		private const float defaultMinimumBalloonDisplayTime = 3f;

		public const float greetingBalloonDelayTime = 0.85f;

		private bool showingBalloon;

		private bool skipButtonClicked;

		private bool skippable;

		private bool blockNextBalloon;

		public bool IsBalloonDisplay()
		{
			return default(bool);
		}

		public void StartBalloon(string message, string voiceName, float delayTime = 0f, [Optional] Action onVoiceDone, float minimumDisplayTime = -1f, bool ignoreDelay = false)
		{
		}

		private IEnumerator ShowTalkWindowCoroutine(bool closeAndReOpen, bool ignoreDelay)
		{
			return null;
		}

		public void StopBalloon()
		{
		}

		public void OnButtonPressed()
		{
		}
	}
}
