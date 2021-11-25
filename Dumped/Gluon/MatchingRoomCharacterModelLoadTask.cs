using System;
using Cute.Cri;
using UnityEngine;

namespace Gluon
{
	internal class MatchingRoomCharacterModelLoadTask
	{
		private int positionIndex;

		private MatchingRoomPlayerData playerData;

		private int memberIndex;

		private bool isPlayCharaVoice;

		private Action<GameObject> onLoaded;

		private bool isLoadStarted;

		private bool isLoading;

		private const int matchingChangeCharaVoiceId = 14;

		public bool IsLoadStarted => default(bool);

		public bool IsLoading => default(bool);

		public MatchingRoomCharacterModelLoadTask(int positionIndex, MatchingRoomPlayerData playerData, int memberIndex, bool isPlayCharaVoice, Action<GameObject> onLoaded)
		{
		}

		public void LoadStart(AudioPlayback bgmPlayback)
		{
		}
	}
}
