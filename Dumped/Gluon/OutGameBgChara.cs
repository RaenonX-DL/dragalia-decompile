using System;
using System.Collections;
using System.Runtime.InteropServices;
using Cute.Cri;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class OutGameBgChara : AnimationUIBase, ICustomMessage
	{
		public DifferenceImageController imageCtrl;

		public string assetPath;

		public bool isAutoInit;

		public bool isLipSyncOnStart;

		protected Tweener eyeBlinkTween;

		protected Tweener lipSynchTween;

		protected const float DefaultEyeBlinkIntervalMin = 2f;

		protected const float DefaultEyeBlinkIntervalMax = 5f;

		protected const float DefaultEyeBlinkingTime = 0.05f;

		protected const float DefaultLipSynchIntervalMin = 71f / (339f * (float)Math.PI);

		protected const float DefaultLipSynchIntervalMax = 71f / (339f * (float)Math.PI);

		protected const float DefaultLipSynchingTime = 0.1f;

		protected float eyeBlinkIntervalMin;

		protected float eyeBlinkIntervalMax;

		protected float eyeBlinkingTime;

		protected float lipSynchIntervalMin;

		protected float lipSynchIntervalMax;

		protected float lipSynchingTime;

		protected bool isLipSynch;

		public AudioPlayback voice;

		private string voiceGroupName;

		private Coroutine waitCoroutine;

		private void Start()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		private void RemoveCharaVoiceGroup()
		{
		}

		private void OnDestroy()
		{
		}

		public void Init(string path, Action<bool> onCompleted)
		{
		}

		protected void InitDifferenceImage(string path, Action<bool> onCompleted)
		{
		}

		public override void StartExitAnimation([Optional] Action onAnimationDone)
		{
		}

		public void ShowDifference(bool show)
		{
		}

		public void DoLipSynch()
		{
		}

		private IEnumerator WaitWhileVoicePlay()
		{
			return null;
		}

		private void SetEyeBlink()
		{
		}

		private void SetLipSynch()
		{
		}

		public void PlayTalkSound(string voiceGroupName, string voiceName)
		{
		}
	}
}
