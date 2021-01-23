/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyBgManager : SingletonMonoBehaviour<Gluon.PartyBgManager>
	{
		// Fields
		public PartyBgContent currentBgContent;
		public PartyBgContent nextBgContent;
		private string lastLightMapSceneName;
		private QuestBgSceneSettingKeeper bgSettingKeeper;
		public bool isSceneLoadCompleted;
		public bool dontDestroyOnDestroy;
		private static Scene createdScene;
		private static DungeonManager.OutDesignerAreaDataCache designerAreaDataCache;
		private EnvironmentMap environment;
		private SceneShaderSettings sceneShaderSettings;
		public static string bgFileName;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _LoadBgSceneCoroutine_b__0();
			internal bool _LoadBgSceneCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadBgSceneCoroutine_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string filename;
			public string resourcePath;
			public PartyBgManager __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadBgSceneCoroutine_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ShowBgCoroutine_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyBgManager __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowBgCoroutine_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _SetCharaLightProbeParamCoroutine_d__22 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public PartyBgManager __4__this;
			public GameObject character;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetCharaLightProbeParamCoroutine_d__22(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public PartyBgManager();
		static PartyBgManager();
	
		// Methods
		public void LoadBgScene();
		public void LoadBgScene(string resourcePath, string filename, int selectQuestId);
		[IteratorStateMachine]
		private IEnumerator LoadBgSceneCoroutine(string resourcePath, string filename);
		public void ApplyBgSceneShader();
		public bool ReloadBgFileNameFromCreatedScene();
		public void ReflectBgSettings(PostEffect pe);
		private Scene GetLatestSceneByName(string filename);
		public void ShowBg();
		[IteratorStateMachine]
		private IEnumerator ShowBgCoroutine();
		public void Destroy();
		public void SetCharaLightProbeParam(GameObject character);
		[IteratorStateMachine]
		public IEnumerator SetCharaLightProbeParamCoroutine(GameObject character);
		[CompilerGenerated]
		private bool _SetCharaLightProbeParamCoroutine_b__22_0();
	}
}
