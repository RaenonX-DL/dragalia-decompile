/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SceneController : SingletonMonoBehaviour<Gluon.SceneController>
	{
		// Fields
		[CompilerGenerated]
		private static string _currentSceneName_k__BackingField;
		[CompilerGenerated]
		private static string _prevSceneName_k__BackingField;
		private List<string> currentOptionalSceneNames;
		private List<string> nextOptionalSceneNames;
		private List<string> currentDuplicatedOptionalSceneNames;
		private List<string> nextDuplicatedOptionalSceneNames;
		[CompilerGenerated]
		private bool _isOnTransition_k__BackingField;
		public bool isOnAnimation;
		public bool isOnAsyncLoad;
		private string beforeLeavingNextSceneName;
		public string preservedNextSceneName;
		public SceneBase currentSceneBase;
		public List<SceneBase> additionalSceneBases;
		private List<AddSceneStack> addSceneList;
		[CompilerGenerated]
		private Coroutine _loadSceneAsyncCoroutine_k__BackingField;
		[CompilerGenerated]
		private SceneModelBase _model_k__BackingField;
	
		// Properties
		public static string currentSceneName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static string prevSceneName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isOnTransition { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string BeforeLeavingNextSceneName { get; }
		public string PreservedNextSceneName { get; }
		public Coroutine loadSceneAsyncCoroutine { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public SceneModelBase model { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum FadeInType
		{
			ShowFadeIn = 0,
			InstantFadeIn = 1,
			WaitStartFadeIn = 2
		}
	
		public class AddSceneStack
		{
			// Fields
			public string prevSceneName;
			public Action loadSceneCallback;
			public SceneBase prevSceneBase;
			public bool entity;
	
			// Constructors
			public AddSceneStack(string name, Action callback);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass38_0
		{
			// Fields
			public string nextSceneName;
			public bool isAdditive;
			public SceneController __4__this;
	
			// Constructors
			public __c__DisplayClass38_0();
	
			// Methods
			internal void _LoadScene_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public string nextSceneName;
			public SceneController __4__this;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _LoadSceneAndReleaseResources_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public SceneController __4__this;
			public string nextSceneName;
			public bool isAddSceneClearInstantly;
			public SceneModelBase model;
			public Action onLoadedCallback;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _LoadSceneAsync_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _LoadSceneAsyncCoroutine_d__42 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string nextSceneName;
			public Action onLoadedCallback;
			public SceneController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadSceneAsyncCoroutine_d__42(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _UnloadSceneFunction_d__47 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string sceneName;
			public SceneController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UnloadSceneFunction_d__47(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadOptionalSceneAsyncCoroutine_d__51 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SceneController __4__this;
			public string sceneName;
			public Action onOptionSceneLoaded;
			public bool autoBlockTouchWhileLoading;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadOptionalSceneAsyncCoroutine_d__51(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForOptionSceneLoaded_d__52 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool autoBlockTouchWhileLoading;
			public SceneController __4__this;
			public string sceneName;
			public Action onOnptionSceneLoaded;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForOptionSceneLoaded_d__52(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CorrectActiveScene_d__53 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CorrectActiveScene_d__53(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _UnloadAllOptionalScenesWaitCoroutine_d__57 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SceneController __4__this;
			private int _count_5__2;
			private int _i_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UnloadAllOptionalScenesWaitCoroutine_d__57(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass58_0
		{
			// Fields
			public string sceneName;
	
			// Constructors
			public __c__DisplayClass58_0();
	
			// Methods
			internal bool _UnloadDuplicatedOptionalScene_b__0(string str);
		}
	
		[CompilerGenerated]
		private sealed class _AddLoadSceneCoroutine_d__60 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SceneController __4__this;
			public bool lastSceneChange;
			public string addSceneName;
			public Action callback;
			private AddSceneStack _loadScene_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _AddLoadSceneCoroutine_d__60(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _UnloadAddLoadSceneCoroutine_d__62 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public SceneController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UnloadAddLoadSceneCoroutine_d__62(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public SceneController();
	
		// Methods
		protected override void Awake();
		public bool LoadScene(string nextSceneName, bool isAdditive = true, bool gotoSameScene = false, bool needRequestEventQuest = true, bool isForce = false);
		private string GetThroughSceneName(string nextSceneName);
		public bool LoadSceneAndReleaseResources(string nextSceneName);
		public bool LoadSceneAsync(string nextSceneName, Action onLoadedCallback = null, bool needRequestEventQuest = true, bool isAddSceneClearInstantly = true, bool forceLoadSameScene = false, SceneModelBase model = null);
		[IteratorStateMachine]
		private IEnumerator LoadSceneAsyncCoroutine(string nextSceneName, Action onLoadedCallback, SceneModelBase model = null);
		private void ClearOldScenes(bool isAddSceneClearInstantly = true, bool showExitAnimation = true);
		public AsyncOperation UnloadPrevScene();
		private static Scene GetSceneByName(string sceneName);
		private void DoLoadScene(string nextSceneName, bool isAdditive);
		[IteratorStateMachine]
		private IEnumerator UnloadSceneFunction(string sceneName);
		public void ResetActiveScene();
		public void LoadOptionalScene(string sceneName, Action onOptionSceneLoaded = null, bool autoBlockTouchWhileLoading = false);
		public Coroutine StartLoadOptionalSceneAsyncCoroutine(string sceneName, Action onOptionSceneLoaded = null, bool autoBlockTouchWhileLoading = false);
		[IteratorStateMachine]
		public IEnumerator LoadOptionalSceneAsyncCoroutine(string sceneName, Action onOptionSceneLoaded = null, bool autoBlockTouchWhileLoading = false);
		[IteratorStateMachine]
		private IEnumerator WaitForOptionSceneLoaded(string sceneName, Action onOnptionSceneLoaded, bool autoBlockTouchWhileLoading);
		[IteratorStateMachine]
		private IEnumerator CorrectActiveScene();
		public bool HasOptionalScene(string sceneName);
		public AsyncOperation UnloadOptionalScene(string sceneName);
		public AsyncOperation UnloadOptionalScene(Scene scene);
		[IteratorStateMachine]
		public IEnumerator UnloadAllOptionalScenesWaitCoroutine();
		public void UnloadDuplicatedOptionalScene(string sceneName);
		public void AddLoadScene(string addSceneName, Action callback = null, bool lastSceneChange = false);
		[IteratorStateMachine]
		private IEnumerator AddLoadSceneCoroutine(string addSceneName, Action callback, bool lastSceneChange);
		public void UnloadAddLoadScene();
		[IteratorStateMachine]
		private IEnumerator UnloadAddLoadSceneCoroutine();
		public void AddloadSceneClear();
		public string PrevAddScene();
		public bool IsAddScene(string sceneName);
		public bool IsOptionalScene(string sceneName);
		public void SetActiveBg(Footer.MenuTab menuTab);
		public bool IsTransitionReady();
		public static void LoadBase();
		public static void UnloadBase();
		public static void LoadOutGameBase();
		private static AsyncOperation UnloadOutGameBase();
		public static void LoadHeader();
		private static AsyncOperation UnloadHeader();
		public static void LoadFooter();
		private static AsyncOperation UnloadFooter();
		public static AsyncOperation UnloadScene(string scene);
		public bool CheckDateChangeOnCurrentScene(bool withCallEvent = false);
		public void ClearAllSceneInfo();
		public static void CallOnPresentReceived();
		[CompilerGenerated]
		private bool _AddLoadSceneCoroutine_b__60_0();
		[CompilerGenerated]
		private bool _UnloadAddLoadSceneCoroutine_b__62_0();
	}
}
