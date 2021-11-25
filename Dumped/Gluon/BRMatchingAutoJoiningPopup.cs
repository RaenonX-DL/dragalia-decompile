using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BRMatchingAutoJoiningPopup : PopupBase
	{
		private const string prefabPath = "Prefabs/OutGame/EventQuest/BattleRoyal/BRMatchingAutoJoiningPopup";

		private int questId;

		private int skinId;

		private int weaponSkinId;

		private bool silent;

		[SerializeField]
		private Text countdownText;

		[SerializeField]
		private GameObject debugGO;

		[SerializeField]
		private CanvasGroup silentCanvasGroup;

		public static BRMatchingAutoJoiningPopup Create(int questId, int skinId, int weaponSkinId, bool silent = false)
		{
			return null;
		}

		public void OnCancelButtonPressed()
		{
		}

		protected override void Start()
		{
		}

		private void MatchingServiceStateChangedEventListener(MatchingService.StateType state)
		{
		}

		private void ErrorTypeCheck(MultiPlayError error, [Optional] Action onClose)
		{
		}

		private void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void StartQuest()
		{
		}

		private IEnumerator LoadSceneLoadingCheck()
		{
			return null;
		}
	}
}
