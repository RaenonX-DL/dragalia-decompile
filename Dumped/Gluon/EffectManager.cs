using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class EffectManager : FastUpdateMonoBehaviour
	{
		public enum TriggerType
		{
			None = 0,
			Stop = 1,
			Max = 14
		}

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

		public bool isUsePreloadShift
		{
			get
			{
				return default(bool);
			}
			private set
			{
			}
		}

		public bool isUseGluonPool
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static EffectManager instance => null;

		public static bool hasInstance => default(bool);

		public FontEffectManager fontEffMan => null;

		public static bool IsSubdivisionGroupName(string effectName)
		{
			return default(bool);
		}

		public static string ConvertEffectGroupName(string effectName)
		{
			return null;
		}

		private void Awake()
		{
		}

		public void CheckMemorySize()
		{
		}

		public void LoadEffectTable()
		{
		}

		public override void FastUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		public void RegisterLoadGroup(string groupName)
		{
		}

		public void LoadGroup()
		{
		}

		public HashSet<string> GetCopiedLoadGroupSet()
		{
			return null;
		}

		public void ReplaceLoadGroupSet(HashSet<string> effectGroupSet)
		{
		}

		public void LoadGroup(string groupName, [Optional] Action<GameObject> onLoaded, [Optional] Action onAllLoaded, bool isAsync = true)
		{
		}

		private void LoadUniqueGroup(string groupName, [Optional] Action<GameObject> onLoaded, [Optional] Action onAllLoaded, bool isAsync = true)
		{
		}

		public void RegisterLoadEffect(string effectName)
		{
		}

		public void LoadRegisteredEffects()
		{
		}

		public void LoadEffect(List<string> effectNames, [Optional] Action<GameObject> onLoaded)
		{
		}

		private void LoadEffect(string groupName, List<string> effectNameList, bool isAsync, [Optional] Action<GameObject> onLoaded, [Optional] Action onAllLoaded)
		{
		}

		private IEnumerator WaitForAllLoaded(Action onAllLoaded)
		{
			return null;
		}

		private static string GetEffectPath(string fileName)
		{
			return null;
		}

		public void ReleaseGroup(string groupName)
		{
		}

		private void ReleaseUniqueGroup(string groupName)
		{
		}

		public void ReleaseAllGroups()
		{
		}

		public void ReleaseEffect(List<string> effectNames)
		{
		}

		public void ReleaseAllGroupsWithExceptions(string[] list)
		{
		}

		public bool IsLoaded()
		{
			return default(bool);
		}

		public bool IsEffectNameInEffectDictionary(string effectName)
		{
			return default(bool);
		}

		public EffectObject CreateSimpleEffect(string effectName)
		{
			return null;
		}

		public void PlaySimpleEffect(EffectObject effectObject)
		{
		}

		public EffectObject Play(string effectName, Vector3 pos, Quaternion rot, Vector3 scale, [Optional] GameObject go, float duration = 0f, int trigger = 0, [Optional] CommonObjectStatus owner, EffectObject.EraseType eraseType = EffectObject.EraseType.DELETE)
		{
			return null;
		}

		public EffectObject PlayNotDependedMaster(string effectName, Vector3 pos, Quaternion rot, Vector3 localScale, GameObject go, float duration, EffectObject.EraseType eraseType, float dissapearTime, int trigger = 0, [Optional] CommonObjectStatus owner)
		{
			return null;
		}

		public void PlayFontEffect(string effectName, CharacterBase owner, Vector3 pos, Vector3 offset, Quaternion rot, Vector3 localScale, [Optional] GameObject attach, EffectObject.FollowRotType followRot = EffectObject.FollowRotType.NONE, float duration = 0f, EffectObject.EraseType eraseType = EffectObject.EraseType.DELETE, float dissapearTime = 0f, int trigger = 0)
		{
		}

		public EffectObject Play(string effectName, GameObject go, [Optional] CommonObjectStatus owner)
		{
			return null;
		}

		public EffectObject Play(string effectName, Vector3 pos, Quaternion rot, [Optional] CommonObjectStatus owner)
		{
			return null;
		}

		public EffectObject Play(string effectName, Vector3 pos, [Optional] CommonObjectStatus owner)
		{
			return null;
		}

		public void KickTrigger(EffectObject eo, TriggerType trigger)
		{
		}

		public void KickTrigger(EffectObject eo, int trigger)
		{
		}

		public void Stop(EffectObject eo, float life = 0f)
		{
		}

		public void Release(EffectObject eo)
		{
		}

		public void ReleaseEffectGroupInPool(string groupName)
		{
		}

		public void StopAll()
		{
		}

		public void ReleaseAll()
		{
		}

		public void PauseAll(bool isPause)
		{
		}

		public void Pause(EffectObject eo, bool isPause)
		{
		}

		public void PausePlaySpeed(EffectObject eo, bool isPause)
		{
		}

		public void PausePlayerEffect(bool isPause)
		{
		}

		public void SetShowAll(bool isShow)
		{
		}

		public void SetVisible(EffectObject eo, bool isShow)
		{
		}

		public void SetEraseType(EffectObject eo, EffectObject.EraseType type, float time = 0f)
		{
		}

		public GameObject GetEffectObject(string name)
		{
			return null;
		}

		public void CreatePools(string name, int poolCount)
		{
		}

		public void CreatePoolsByStartName(string startName, int poolCount)
		{
		}

		public static bool NeedsLoadInPerformanceMode(string name)
		{
			return default(bool);
		}
	}
}
