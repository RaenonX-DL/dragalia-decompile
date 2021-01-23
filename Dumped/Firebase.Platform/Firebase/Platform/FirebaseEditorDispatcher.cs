/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 39: Firebase.Platform.dll - Assembly: Firebase.Platform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Platform
{
	internal sealed class FirebaseEditorDispatcher
	{
		// Fields
		[CompilerGenerated]
		private static Action __f__mg_cache0;
		[CompilerGenerated]
		private static Action __f__mg_cache1;
		[CompilerGenerated]
		private static Action __f__mg_cache2;
	
		// Properties
		private static Type EditorApplicationType { get; }
		public static bool EditorIsPlaying { get; }
		public static bool EditorIsPlayingOrWillChangePlaymode { get; }
	
		// Methods
		public static void StartEditorUpdate();
		public static void StopEditorUpdate();
		public static void Update();
		public static void ListenToPlayState(bool start = true);
		private static void PlayModeStateChanged();
		private static void PlayModeStateChangedWithArg<T>(T t);
		private static void AddRemoveCallbackToField(FieldInfo eventField, Action callback, object target = null, bool add = true, string errorMessage = null);
	}
}
