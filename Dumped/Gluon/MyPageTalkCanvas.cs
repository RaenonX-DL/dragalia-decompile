using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.Cri;
using UnityEngine;

namespace Gluon
{
	public class MyPageTalkCanvas : MonoBehaviour
	{
		public MyPageScene scene;

		public Camera mainCamera;

		public Canvas canvas;

		public MyPageBalloon[] balloons;

		public bool[] existsBaloon;

		public GameObject[] characters;

		public SimpleCharacterModel[] characterModels;

		public int[] characterIds;

		public Vector2[] windowOffset;

		public bool[] playedInMoveMap;

		private MyPageTransitionController.MapGroup mapGroup;

		private RectTransform rectTransform;

		private GameObject balloonAsset;

		private List<string> lastVoiceGroup;

		private AudioPlayback playBack;

		private AudioPlayback lastPlayBack;

		private bool onMapTransition;

		private float lastPlayVoiceTime;

		private const int numOfBalloons = 5;

		private const float voiceInterval = 0.5f;

		private const float voiceFadeDuration = 0.4f;

		private const string prefabPath = "Prefabs/OutGame/MyPage/UI/Balloon";

		private bool isFirstPop;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void ReleaseAllVoiceGroup()
		{
		}

		public void CloseVoiceBalloon()
		{
		}

		public void Reset(MyPageTransitionController.MapGroup mapGroup)
		{
		}

		public void Setup(int index, MyPageBalloon.IconType iconType, MyPageBalloon.TextType textType, GameObject character, bool isRunning, int characterId = 0, string characterName = "", [Optional] OutGameCharacterTalkManager.TalkEntity talk, MyPageBalloon.MoveMapCharaType moveMapCharaType = MyPageBalloon.MoveMapCharaType.None, bool isEventTalk = false)
		{
		}

		private void GetBalloonAsset(Action<GameObject> onCompletedAction)
		{
		}

		public void StartMapTransition()
		{
		}

		public void FinishMapTransition()
		{
		}

		public void OpenInitialSkitMapBalloon()
		{
		}

		private IEnumerator OpenInitialSkitMapBalloonCoroutine()
		{
			return null;
		}

		public void CloseOtherBaloons(int myIndex)
		{
		}

		public void PlayWalkerVoice()
		{
		}

		public void PlayVoice(string voiceGroup, string voiceId)
		{
		}

		private IEnumerator PlayVoiceCoroutine(string voiceGroup, string voiceId)
		{
			return null;
		}

		public void StopCurrentVoice()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
