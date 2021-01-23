/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;
using Gluon.Master;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BgContentManager : SingletonMonoBehaviour<Gluon.BgContentManager>
	{
		// Fields
		private bool isBgLoadCompleted;
		private bool isOnEnemyLoadLoading;
		private int enemyLoadingQuestLocationId;
		private bool isSceneLoadCompleted;
		private Scene createdScene;
		private string fileName;
		private QuestBgSceneSettingKeeper _bgSettingKeeper;
		private const int startFogValue = 0;
		private const int endFogValue = 1000000;
		private const int maxEnemyNum = 3;
		private List<EnemyLoadInfo> enemyInfoList;
		private static DungeonManager.OutDesignerAreaDataCache designerAreaDataCache;
		private List<EnemyCharacter> enemyCharacterList;
		private readonly Vector3[] vecPosList;
		private readonly Vector3[] vecPosListThreeEnemy;
		private readonly Vector3[] vecRotList;
	
		// Properties
		public bool IsBgLoadCompleted { get; }
		public bool IsOnEnemyLoadLoading { get; }
		public bool IsSceneLoadCompleted { get; }
		public QuestBgSceneSettingKeeper bgSettingKeeper { get; private set; }
	
		// Nested types
		public class EnemyLoadInfo
		{
			// Fields
			public int index;
			public int id;
			public bool isLoaded;
	
			// Constructors
			public EnemyLoadInfo();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__27_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _ResisterLoadBgSceneCorutine_b__27_0();
		}
	
		[CompilerGenerated]
		private sealed class _ResisterLoadBgSceneCorutine_d__27 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public int questGroupId;
			private List<string> _scenePathList_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ResisterLoadBgSceneCorutine_d__27(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public bool isLoaded;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal void _LoadBgSceneCoroutine_b__0();
			internal bool _LoadBgSceneCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadBgSceneCoroutine_d__31 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string resourcePath;
			public BgContentManager __4__this;
			public int questLocationId;
			private OutGameAssetLoader _assetsLoader_5__2;
			private WaitForEndOfFrame _wait_5__3;
			private EnvironmentMap _environment_5__4;
			private QuestMainLocationElement _elm_5__5;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadBgSceneCoroutine_d__31(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0
		{
			// Fields
			public BgContentManager __4__this;
			public List<EnemyLoadInfo> showEnemyLoadInfoList;
			public int loadedCount;
	
			// Constructors
			public __c__DisplayClass36_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_1
		{
			// Fields
			public int index;
			public string path;
			public int enemyId;
			public __c__DisplayClass36_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass36_1();
	
			// Methods
			internal void _CreateEnemyModelAll_b__0(UnityEngine.Object loadedEnemy);
		}
	
		[CompilerGenerated]
		private sealed class _LoadEffectResources_d__45 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadEffectResources_d__45(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public BgContentManager();
		static BgContentManager();
	
		// Methods
		public void ResisterLoadBgScene(int questGroup);
		[IteratorStateMachine]
		private IEnumerator ResisterLoadBgSceneCorutine(int questGroupId);
		public void LoadBgScene(int questId);
		public void LoadBgSceneLocationId(int questLocationId);
		public void LoadBgScene(string resourcePath);
		[IteratorStateMachine]
		private IEnumerator LoadBgSceneCoroutine(string resourcePath, int questLocationId = -1);
		public void SetEnemyRenderParam();
		private void InitEnemyLoadInfo(EnemyLoadInfo info, int index, int enemyId);
		private GameObject CreateEnemyModel(int enemyId, int actionId);
		private EnemyCharacter CreateEnemyModel(int enemyId);
		public void CreateEnemyModelAll(List<EnemyLoadInfo> showEnemyLoadInfoList);
		private void SetEnemyAction(EnemyCharacter enemyObj, int enemyId, int actionId);
		public void LoadEnemyOnBg(QuestMainLocationElement elm);
		private bool IsEnemyLoadCompleted();
		private int getElement(int mapElement);
		public void ShowBgScene(bool value);
		protected override void OnDestroy();
		public void Destory();
		public void EnemyDestroy();
		[IteratorStateMachine]
		protected IEnumerator LoadEffectResources();
		public string GetMainLocationBgPath(QuestMainLocationElement qmle);
		public string GetBgSceneName();
		[CompilerGenerated]
		private bool _LoadBgSceneCoroutine_b__31_2();
		[CompilerGenerated]
		private bool _LoadBgSceneCoroutine_b__31_3();
	}
}
