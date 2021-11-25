using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class RandomMatchingAutoJoiningPopup : PopupBase
	{
		[SerializeField]
		private GameObject debugGO;

		private const string prefabPath = "Prefabs/OutGame/EventQuest/RamdomMathing/RandomMatchingAutoJoiningPopup";

		private int questId;

		private int eventId;

		private bool is16Matching;

		public static bool isRandomMatchingAutoJoining;

		public static RandomMatchingAutoJoiningPopup Create(int questId, int eventId)
		{
			return null;
		}

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		private void MatchingServiceStateChangedEventListener(MatchingService.StateType state)
		{
		}

		private void ErrorTypeCheck(MultiPlayError error, [Optional] Action onClose)
		{
		}

		public void OnCancelButtonPressed()
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
