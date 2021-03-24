/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Firebase;

// Image 40: Firebase.Platform.dll - Assembly: Firebase.Platform, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase.Platform
{
	internal sealed class FirebaseHandler
	{
		// Fields
		private static FirebaseMonoBehaviour firebaseMonoBehaviour;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private static IFirebaseAppUtils _AppUtils_k__BackingField;
		private static int tickCount;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private static Dispatcher _ThreadDispatcher_k__BackingField;
		[CompilerGenerated]
		[DebuggerBrowsable]
		private bool _IsPlayMode_k__BackingField;
		private static FirebaseHandler firebaseHandler;
		private EventHandler<EventArgs> Updated;
		internal Action UpdatedEventWrapper;
		private EventHandler<ApplicationFocusChangedEventArgs> ApplicationFocusChanged;
		[CompilerGenerated]
		private static Func<bool> __f__am_cache0;
	
		// Properties
		public static IFirebaseAppUtils AppUtils { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static int TickCount { get; }
		private static Dispatcher ThreadDispatcher { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsPlayMode { [CompilerGenerated] get; [CompilerGenerated] set; }
		internal static FirebaseHandler DefaultInstance { get; }
	
		// Nested types
		internal class ApplicationFocusChangedEventArgs : EventArgs
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable]
			private bool _HasFocus_k__BackingField;
	
			// Properties
			public bool HasFocus { [CompilerGenerated] set; }
	
			// Constructors
			public ApplicationFocusChangedEventArgs();
		}
	
		[CompilerGenerated]
		private sealed class _CreatePartialOnMainThread_c__AnonStorey0
		{
			// Fields
			internal IFirebaseAppUtils appUtils;
	
			// Constructors
			public _CreatePartialOnMainThread_c__AnonStorey0();
	
			// Methods
			internal void __m__0();
		}
	
		// Constructors
		static FirebaseHandler();
		private FirebaseHandler();
	
		// Methods
		internal void StartMonoBehaviour();
		internal void StopMonoBehaviour();
		public static TResult RunOnMainThread<TResult>(Func<TResult> f);
		public static Task<TResult> RunOnMainThreadAsync<TResult>(Func<TResult> f);
		internal static void CreatePartialOnMainThread(IFirebaseAppUtils appUtils);
		internal static void Create(IFirebaseAppUtils appUtils);
		internal void Update();
		internal void OnApplicationFocus(bool hasFocus);
		internal static void OnMonoBehaviourDestroyed(FirebaseMonoBehaviour behaviour);
		[CompilerGenerated]
		private static bool _StopMonoBehaviour_m__0();
		[CompilerGenerated]
		private void _Update_m__1();
	}
}
