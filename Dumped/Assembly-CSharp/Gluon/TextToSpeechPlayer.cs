/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TextToSpeechPlayer
	{
		// Fields
		private List<string> speakTextQueue;
		private const int bgmVolumeDuringSpeech = 20;
	
		// Constructors
		public TextToSpeechPlayer();
	
		// Methods
		~TextToSpeechPlayer();
		public void Clear();
		public void PlaySpeech(string text);
		private void PlayNextSpeech();
		private void Speech(string text);
		private void OnSpeechDone();
		private void OnSpeechError();
		private void ClearSpeechCallback();
		private void ResetBgmVolume();
		[CompilerGenerated]
		private void _Speech_b__6_0(string error);
		[CompilerGenerated]
		private void _Speech_b__6_1();
	}
}
