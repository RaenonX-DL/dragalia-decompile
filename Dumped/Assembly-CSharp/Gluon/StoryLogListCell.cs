/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryLogListCell : TableViewCell<Gluon.StoryLogListCellData>
	{
		// Fields
		public UnityEngine.UI.Text nameText;
		public UnityEngine.UI.Text messageText;
		private string voiceId;
		[SerializeField]
		private Button voiceButton;
		[SerializeField]
		private GameObject[] voiceButtonIcons;
		private const float loopSec = 1f;
	
		// Nested types
		public enum VoiceIcon
		{
			Speaker = 0,
			SoundWave1 = 1,
			SoundWave2 = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass9_0
		{
			// Fields
			public AudioPlayback currentVoice;
			public StoryLogListCell __4__this;
			public Tweener tween;
	
			// Constructors
			public __c__DisplayClass9_0();
	
			// Methods
			internal void _SetVoiceButtonAnimation_b__0(float sec);
		}
	
		// Constructors
		public StoryLogListCell();
	
		// Methods
		public override void UpdateContent(StoryLogListCellData data);
		public void OnButtonPressed();
		private Tweener SetVoiceButtonAnimation();
	}
}
