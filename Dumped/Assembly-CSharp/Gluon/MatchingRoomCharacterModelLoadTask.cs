/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	internal class MatchingRoomCharacterModelLoadTask
	{
		// Fields
		private int positionIndex;
		private MatchingRoomPlayerData playerData;
		private int memberIndex;
		private bool isPlayCharaVoice;
		private Action<GameObject> onLoaded;
		private bool isLoadStarted;
		private bool isLoading;
		private const int matchingChangeCharaVoiceId = 14;
	
		// Properties
		public bool IsLoadStarted { get; }
		public bool IsLoading { get; }
	
		// Constructors
		public MatchingRoomCharacterModelLoadTask(int positionIndex, MatchingRoomPlayerData playerData, int memberIndex, bool isPlayCharaVoice, Action<GameObject> onLoaded);
	
		// Methods
		public void LoadStart(AudioPlayback bgmPlayback);
		[CompilerGenerated]
		private void _LoadStart_b__13_0(GameObject obj);
	}
}
