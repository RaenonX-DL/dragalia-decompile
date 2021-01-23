/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SpeechRecognizer : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private static Action<string> _OnResult_k__BackingField;
		[CompilerGenerated]
		private static Action<ErrorType> _OnError_k__BackingField;
		private static SpeechRecognizer instance;
	
		// Properties
		public static Action<string> OnResult { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static Action<ErrorType> OnError { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum ErrorType
		{
			ERROR_NETWORK_TIMEOUT = 1,
			ERROR_NETWORK = 2,
			ERROR_AUDIO = 3,
			ERROR_SERVER = 4,
			ERROR_CLIENT = 5,
			ERROR_SPEECH_TIMEOUT = 6,
			ERROR_NO_MATCH = 7,
			ERROR_RECOGNIZER_BUSY = 8,
			ERROR_INSUFFICIENT_PERMISSIONS = 9
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass11_0
		{
			// Fields
			public AndroidJavaClass voiceText;
			public AndroidJavaObject context;
	
			// Constructors
			public __c__DisplayClass11_0();
	
			// Methods
			internal void _StartRecognize_b__0();
		}
	
		// Constructors
		public SpeechRecognizer();
		static SpeechRecognizer();
	
		// Methods
		public static void Initialize(string language);
		public static void StartRecognize();
		public static void StopRecognize();
		public void onResults(string result);
		public void onError(string error);
		private void OnDestroy();
	}
}
