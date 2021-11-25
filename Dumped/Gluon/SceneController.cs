using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gluon
{
	public class SceneController : SingletonMonoBehaviour<SceneController>
	{
		public enum FadeInType
		{
			ShowFadeIn,
			InstantFadeIn,
			WaitStartFadeIn
		}

		public class AddSceneStack
		{
			public string prevSceneName;

			public Action loadSceneCallback;

			public SceneBase prevSceneBase;

			public bool entity;

			public AddSceneStack(string name, Action callback)
			{
			}
		}

		private List<string> currentOptionalSceneNames;

		private List<string> nextOptionalSceneNames;

		private List<string> currentDuplicatedOptionalSceneNames;

		private List<string> nextDuplicatedOptionalSceneNames;

		public bool isOnAnimation;

		public bool isOnAsyncLoad;

		private string beforeLeavingNextSceneName;

		public string preservedNextSceneName;

		public SceneBase currentSceneBase;

		public List<SceneBase> additionalSceneBases;

		private List<AddSceneStack> addSceneList;

		public static string currentSceneName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static string prevSceneName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isOnTransition
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string BeforeLeavingNextSceneName => null;

		public string PreservedNextSceneName => null;

		public Coroutine loadSceneAsyncCoroutine
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SceneModelBase model
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected override void Awake()
		{
		}

		public bool LoadScene(string nextSceneName, bool isAdditive = true, bool gotoSameScene = false, bool needRequestEventQuest = true, bool isForce = false)
		{
			return default(bool);
		}

		private string GetThroughSceneName(string nextSceneName)
		{
			return null;
		}

		public bool LoadSceneAndReleaseResources(string nextSceneName)
		{
			return default(bool);
		}

		public bool LoadSceneAsync(string nextSceneName, [Optional] Action onLoadedCallback, bool needRequestEventQuest = true, bool isAddSceneClearInstantly = true, bool forceLoadSameScene = false, [Optional] SceneModelBase model)
		{
			return default(bool);
		}

		private IEnumerator LoadSceneAsyncCoroutine(string nextSceneName, Action onLoadedCallback, [Optional] SceneModelBase model)
		{
			return null;
		}

		private void ClearOldScenes(bool isAddSceneClearInstantly = true, bool showExitAnimation = true)
		{
		}

		public AsyncOperation UnloadPrevScene()
		{
			return null;
		}

		private static Scene GetSceneByName(string sceneName)
		{
			return default(Scene);
		}

		private void DoLoadScene(string nextSceneName, bool isAdditive)
		{
		}

		private IEnumerator UnloadSceneFunction(string sceneName)
		{
			return null;
		}

		public void ResetActiveScene()
		{
		}

		public void LoadOptionalScene(string sceneName, [Optional] Action onOptionSceneLoaded, bool autoBlockTouchWhileLoading = false)
		{
		}

		public Coroutine StartLoadOptionalSceneAsyncCoroutine(string sceneName, [Optional] Action onOptionSceneLoaded, bool autoBlockTouchWhileLoading = false)
		{
			return null;
		}

		public IEnumerator LoadOptionalSceneAsyncCoroutine(string sceneName, [Optional] Action onOptionSceneLoaded, bool autoBlockTouchWhileLoading = false)
		{
			return null;
		}

		private IEnumerator WaitForOptionSceneLoaded(string sceneName, Action onOnptionSceneLoaded, bool autoBlockTouchWhileLoading)
		{
			return null;
		}

		private IEnumerator CorrectActiveScene()
		{
			return null;
		}

		public bool HasOptionalScene(string sceneName)
		{
			return default(bool);
		}

		public AsyncOperation UnloadOptionalScene(string sceneName)
		{
			return null;
		}

		public AsyncOperation UnloadOptionalScene(Scene scene)
		{
			return null;
		}

		public IEnumerator UnloadAllOptionalScenesWaitCoroutine()
		{
			return null;
		}

		public void UnloadDuplicatedOptionalScene(string sceneName)
		{
		}

		public void AddLoadScene(string addSceneName, [Optional] Action callback, bool lastSceneChange = false)
		{
		}

		private IEnumerator AddLoadSceneCoroutine(string addSceneName, Action callback, bool lastSceneChange)
		{
			return null;
		}

		public void UnloadAddLoadScene()
		{
		}

		private IEnumerator UnloadAddLoadSceneCoroutine()
		{
			return null;
		}

		public void AddloadSceneClear()
		{
		}

		public string PrevAddScene()
		{
			return null;
		}

		public bool IsAddScene(string sceneName)
		{
			return default(bool);
		}

		public bool IsOptionalScene(string sceneName)
		{
			return default(bool);
		}

		public void SetActiveBg(Footer.MenuTab menuTab)
		{
		}

		public bool IsTransitionReady()
		{
			return default(bool);
		}

		public static void LoadBase()
		{
		}

		public static void UnloadBase()
		{
		}

		public static void LoadOutGameBase()
		{
		}

		private static AsyncOperation UnloadOutGameBase()
		{
			return null;
		}

		public static void LoadHeader()
		{
		}

		private static AsyncOperation UnloadHeader()
		{
			return null;
		}

		public static void LoadFooter()
		{
		}

		private static AsyncOperation UnloadFooter()
		{
			return null;
		}

		public static AsyncOperation UnloadScene(string scene)
		{
			return null;
		}

		public bool CheckDateChangeOnCurrentScene(bool withCallEvent = false)
		{
			return default(bool);
		}

		public void ClearAllSceneInfo()
		{
		}

		public static void CallOnPresentReceived()
		{
		}
	}
}
