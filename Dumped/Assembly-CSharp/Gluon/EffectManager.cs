/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using SPFX;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EffectManager : FastUpdateMonoBehaviour
	{
		// Fields
		public static readonly int ElementTriggerBegin;
		private static string effectSce2dCommonGroupName;
		private static readonly int effectSubdivisonIndex;
		private static string[] subdivisonGroupArrary;
		private Dictionary<string, List<string>> groupDictionary;
		private Dictionary<string, EffectData> effectDictionary;
		private bool _isUsePreloadShift;
		private const int LIMIT_PRELOAD_SHIFT_USE_MEMSIZE = 1024;
		private bool _isUseGluonPool;
		private Dictionary<string, int> poolCountDict;
		private static EffectManager _instance;
		private HashSet<string> _loadGroupSet;
		private HashSet<string> _loadEffectSet;
		private FontEffectManager _fontEffMan;
	
		// Properties
		public bool isUsePreloadShift { get; private set; }
		public bool isUseGluonPool { get; set; }
		public static EffectManager instance { get; }
		public static bool hasInstance { get; }
		public FontEffectManager fontEffMan { get; }
	
		// Nested types
		public enum TriggerType
		{
			None = 0,
			Stop = 1,
			Max = 14
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static SPFXInstanceBase.OnLoadResourceEvent __9__29_0;
			public static SPFXInstanceBase.OnUnloadResourceEvent __9__29_1;
			public static Func<KeyValuePair<string, EffectData>, string> __9__47_1;
			public static Func<KeyValuePair<string, EffectData>, string> __9__48_0;
			public static Func<string, string> __9__49_0;
			public static Func<KeyValuePair<string, EffectData>, string> __9__49_2;
			public static Func<KeyValuePair<string, EffectData>, string> __9__50_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal TextAsset _Awake_b__29_0(string name);
			internal void _Awake_b__29_1(string name, TextAsset asset);
			internal string _ReleaseUniqueGroup_b__47_1(KeyValuePair<string, EffectData> d);
			internal string _ReleaseAllGroups_b__48_0(KeyValuePair<string, EffectData> e);
			internal string _ReleaseEffect_b__49_0(string e);
			internal string _ReleaseEffect_b__49_2(KeyValuePair<string, EffectData> d);
			internal string _ReleaseAllGroupsWithExceptions_b__50_0(KeyValuePair<string, EffectData> e);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0
		{
			// Fields
			public Action<GameObject> onLoaded;
			public int loadedCount;
			public int effectCountToLoad;
			public Action onAllLoaded;
	
			// Constructors
			public __c__DisplayClass43_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_1
		{
			// Fields
			public EffectData effectData;
			public __c__DisplayClass43_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass43_1();
	
			// Methods
			internal void _LoadEffect_b__0(GameObject go);
		}
	
		[CompilerGenerated]
		private sealed class _WaitForAllLoaded_d__44 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public EffectManager __4__this;
			public Action onAllLoaded;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForAllLoaded_d__44(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass47_0
		{
			// Fields
			public string groupName;
	
			// Constructors
			public __c__DisplayClass47_0();
	
			// Methods
			internal bool _ReleaseUniqueGroup_b__0(KeyValuePair<string, EffectData> d);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0
		{
			// Fields
			public string group;
	
			// Constructors
			public __c__DisplayClass49_0();
	
			// Methods
			internal bool _ReleaseEffect_b__1(KeyValuePair<string, EffectData> d);
		}
	
		// Constructors
		public EffectManager();
		static EffectManager();
	
		// Methods
		public static bool IsSubdivisionGroupName(string effectName);
		public static string ConvertEffectGroupName(string effectName);
		private void Awake();
		public void CheckMemorySize();
		public void LoadEffectTable();
		public override void FastUpdate();
		private void OnDestroy();
		public void RegisterLoadGroup(string groupName);
		public void LoadGroup();
		public HashSet<string> GetCopiedLoadGroupSet();
		public void ReplaceLoadGroupSet(HashSet<string> effectGroupSet);
		public void LoadGroup(string groupName, Action<GameObject> onLoaded = null, Action onAllLoaded = null, bool isAsync = true);
		private void LoadUniqueGroup(string groupName, Action<GameObject> onLoaded = null, Action onAllLoaded = null, bool isAsync = true);
		public void RegisterLoadEffect(string effectName);
		public void LoadRegisteredEffects();
		public void LoadEffect(List<string> effectNames, Action<GameObject> onLoaded = null);
		private void LoadEffect(string groupName, List<string> effectNameList, bool isAsync, Action<GameObject> onLoaded = null, Action onAllLoaded = null);
		[IteratorStateMachine]
		private IEnumerator WaitForAllLoaded(Action onAllLoaded);
		private static string GetEffectPath(string fileName);
		public void ReleaseGroup(string groupName);
		private void ReleaseUniqueGroup(string groupName);
		public void ReleaseAllGroups();
		public void ReleaseEffect(List<string> effectNames);
		public void ReleaseAllGroupsWithExceptions(string[] list);
		public bool IsLoaded();
		public bool IsEffectNameInEffectDictionary(string effectName);
		public EffectObject CreateSimpleEffect(string effectName);
		public void PlaySimpleEffect(EffectObject effectObject);
		public EffectObject Play(string effectName, Vector3 pos, Quaternion rot, Vector3 scale, GameObject go = null, float duration = 0f, int trigger = 0, CommonObjectStatus owner = null, EffectObject.EraseType eraseType = EffectObject.EraseType.DELETE);
		public EffectObject PlayNotDependedMaster(string effectName, Vector3 pos, Quaternion rot, Vector3 localScale, GameObject go, float duration, EffectObject.EraseType eraseType, float dissapearTime, int trigger = 0, CommonObjectStatus owner = null);
		public void PlayFontEffect(string effectName, CharacterBase owner, Vector3 pos, Vector3 offset, Quaternion rot, Vector3 localScale, GameObject attach = null, EffectObject.FollowRotType followRot = EffectObject.FollowRotType.NONE, float duration = 0f, EffectObject.EraseType eraseType = EffectObject.EraseType.DELETE, float dissapearTime = 0f, int trigger = 0);
		public EffectObject Play(string effectName, GameObject go, CommonObjectStatus owner = null);
		public EffectObject Play(string effectName, Vector3 pos, Quaternion rot, CommonObjectStatus owner = null);
		public EffectObject Play(string effectName, Vector3 pos, CommonObjectStatus owner = null);
		public void KickTrigger(EffectObject eo, TriggerType trigger);
		public void KickTrigger(EffectObject eo, int trigger);
		public void Stop(EffectObject eo, float life = 0f);
		public void Release(EffectObject eo);
		public void ReleaseEffectGroupInPool(string groupName);
		public void StopAll();
		public void ReleaseAll();
		public void PauseAll(bool isPause);
		public void Pause(EffectObject eo, bool isPause);
		public void PausePlaySpeed(EffectObject eo, bool isPause);
		public void PausePlayerEffect(bool isPause);
		public void SetShowAll(bool isShow);
		public void SetVisible(EffectObject eo, bool isShow);
		public void SetEraseType(EffectObject eo, EffectObject.EraseType type, float time = 0f);
		public GameObject GetEffectObject(string name);
		public void CreatePools(string name, int poolCount);
		public void CreatePoolsByStartName(string startName, int poolCount);
		public static bool NeedsLoadInPerformanceMode(string name);
		[CompilerGenerated]
		private bool _WaitForAllLoaded_b__44_0();
	}
}
