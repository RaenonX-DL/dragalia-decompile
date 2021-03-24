/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

// Image 43: Firebase.App.dll - Assembly: Firebase.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Firebase
{
	public sealed class FirebaseApp : IDisposable
	{
		// Fields
		private HandleRef swigCPtr;
		private bool swigCMemOwn;
		internal static readonly object disposeLock;
		private string name;
		private EventHandler AppDisposed;
		private static Dictionary<string, FirebaseApp> nameToProxy;
		private static Dictionary<IntPtr, FirebaseApp> cPtrToProxy;
		private static bool AppUtilCallbacksInitialized;
		private static object AppUtilCallbacksLock;
		private static bool PreventOnAllAppsDestroyed;
		private static bool crashlyticsInitializationAttempted;
		private static int CheckDependenciesThread;
		private static object CheckDependenciesThreadLock;
		[CompilerGenerated]
		private static CreateDelegate __f__am_cache0;
		[CompilerGenerated]
		private static Func<bool> __f__am_cache1;
		[CompilerGenerated]
		private static Func<DependencyStatus> __f__am_cache2;
		[CompilerGenerated]
		private static Func<Task<DependencyStatus>, Task<DependencyStatus>> __f__am_cache3;
		[CompilerGenerated]
		private static Func<Task, Task<DependencyStatus>> __f__am_cache4;
	
		// Properties
		public static FirebaseApp DefaultInstance { get; }
		public string Name { get; }
		public static LogLevel LogLevel { get; }
		internal string NameInternal { get; }
		public static string DefaultName { get; }
	
		// Nested types
		public class EnableModuleParams
		{
			// Fields
			[CompilerGenerated]
			[DebuggerBrowsable]
			private string _CppModuleName_k__BackingField;
			[CompilerGenerated]
			[DebuggerBrowsable]
			private string _CSharpClassName_k__BackingField;
			[CompilerGenerated]
			[DebuggerBrowsable]
			private bool _AlwaysEnable_k__BackingField;
	
			// Properties
			public string CppModuleName { [CompilerGenerated] get; [CompilerGenerated] set; }
			public string CSharpClassName { [CompilerGenerated] get; [CompilerGenerated] set; }
			public bool AlwaysEnable { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public EnableModuleParams(string csharp, string cpp, bool always = false);
		}
	
		private delegate FirebaseApp CreateDelegate();
	
		[CompilerGenerated]
		private sealed class _CheckDependencies_c__AnonStorey2
		{
			// Fields
			internal DependencyStatus status;
	
			// Constructors
			public _CheckDependencies_c__AnonStorey2();
	
			// Methods
			internal void __m__0();
		}
	
		[CompilerGenerated]
		private sealed class _FixDependenciesAsync_c__AnonStorey3
		{
			// Fields
			internal Task task;
			private static Action<Task> __f__am_cache0;
	
			// Constructors
			public _FixDependenciesAsync_c__AnonStorey3();
	
			// Methods
			internal void __m__0();
			private static void __m__1(Task t);
		}
	
		// Constructors
		internal FirebaseApp(IntPtr cPtr, bool cMemoryOwn);
		static FirebaseApp();
	
		// Methods
		internal static HandleRef getCPtr(FirebaseApp obj);
		~FirebaseApp();
		public void Dispose();
		internal static void TranslateDllNotFoundException(Action closureToExecute);
		public static FirebaseApp GetInstance(string name);
		public static FirebaseApp Create();
		private void AddReference();
		private void RemoveReference();
		private static void InitializeAppUtilCallbacks();
		private static void OnAllAppsDestroyed();
		private static bool InitializeCrashlyticsIfPresent();
		private static FirebaseApp CreateAndTrack(CreateDelegate createDelegate, FirebaseApp existingProxy);
		private static void SetCheckDependenciesThread(int threadId);
		private static void ThrowIfCheckDependenciesRunning();
		private static bool IsCheckDependenciesRunning();
		public static Task<DependencyStatus> CheckDependenciesAsync();
		public static Task<DependencyStatus> CheckAndFixDependenciesAsync();
		public static DependencyStatus CheckDependencies();
		private static DependencyStatus CheckDependenciesInternal();
		public static Task FixDependenciesAsync();
		private static void ResetDefaultAppCPtr();
		internal static FirebaseApp CreateInternal();
		internal static void ReleaseReferenceInternal(FirebaseApp app);
		internal static void RegisterLibraryInternal(string library, string version);
		internal static void AppSetDefaultConfigPath(string path);
		[CompilerGenerated]
		private static FirebaseApp _Create_m__0();
		[CompilerGenerated]
		private static bool _CreateAndTrack_m__1();
		[CompilerGenerated]
		private static DependencyStatus _CheckDependenciesAsync_m__2();
		[CompilerGenerated]
		private static Task<DependencyStatus> _CheckAndFixDependenciesAsync_m__3(Task<DependencyStatus> checkTask);
		[CompilerGenerated]
		private static Task<DependencyStatus> _CheckAndFixDependenciesAsync_m__4(Task t);
	}
}
