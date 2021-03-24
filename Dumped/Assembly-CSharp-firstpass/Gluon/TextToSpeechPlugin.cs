/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TextToSpeechPlugin : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private static Action _OnDone_k__BackingField;
		[CompilerGenerated]
		private static Action<string> _OnError_k__BackingField;
		[CompilerGenerated]
		private static Action _OnCancel_k__BackingField;
		private static TextToSpeechPlugin instance;
	
		// Properties
		public static Action OnDone { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static Action<string> OnError { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static Action OnCancel { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public AndroidJavaClass voiceText;
			public AndroidJavaObject context;
			public string message;
			public string locale;
			public float speed;
			public float pitch;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _Speech_b__0();
		}
	
		// Constructors
		public TextToSpeechPlugin();
		static TextToSpeechPlugin();
	
		// Methods
		public static void Speech(string message, string locale = "ja-jp", float speed = 1f, float pitch = 1f);
		public void onDone();
		public void onError(string error);
		public void onCancel();
		private void OnDestroy();
	}
}
