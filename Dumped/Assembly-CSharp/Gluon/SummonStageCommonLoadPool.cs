/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonStageCommonLoadPool
	{
		// Fields
		private static SummonStageCommonLoadPool instance;
		public GameObject mikoModel;
		public RuntimeAnimatorController mikoAnimationController;
		public EffectObject[] moonObjects;
		public Dictionary<string, List<EffectObject>> effectPreloadPool;
		public bool isAllLoadedDone;
		private const int mikoBaseId = 100027;
		private const int mikoVariationId = 1;
		private const int prophetShadowIndex = 11;
		private const string animatorPath = "Animations/OutGame/Summon/";
		private const string characterModelBasePath = "Characters/model/";
		private const string characterAppealBasePath = "Character/Appeal/";
		private const string mikoAnimatorPath = "SMN_NPC_100027_01_PRAY";
	
		// Properties
		public static SummonStageCommonLoadPool Instance { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public int loadedCount;
			public int toLoadCount;
			public Action onLoaded;
			public SummonStageCommonLoadPool __4__this;
			public Action proceedLoading;
			public int multiCount;
			public string path;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _LoadAllAsync_b__0();
			internal void _LoadAllAsync_b__1();
			internal void _LoadAllAsync_b__2(GameObject go, int index);
			internal void _LoadAllAsync_b__3(RuntimeAnimatorController rc, int index);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public int loadedCount;
			public int toLoadCount;
			public Action onLoaded;
			public SummonStageCommonLoadPool __4__this;
			public Action proceedLoading;
			public int multiCount;
			public string path;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _LoadAllAsyncForBoxSummon_b__0();
			internal void _LoadAllAsyncForBoxSummon_b__1();
			internal void _LoadAllAsyncForBoxSummon_b__2(GameObject go, int index);
			internal void _LoadAllAsyncForBoxSummon_b__3(RuntimeAnimatorController rc, int index);
		}
	
		// Constructors
		private SummonStageCommonLoadPool();
		static SummonStageCommonLoadPool();
	
		// Methods
		public static void DeleteInstance();
		public void LoadAllAsync(Action onLoaded, int multiCount);
		public void LoadAllAsyncForBoxSummon(Action onLoaded, int multiCount);
		private void LoadAllBindingEffectsAsync(Action onLoaded, int multiCount);
		private void LoadAllBindingEffectsAsyncForBoxSummon(Action onLoaded, int multiCount);
		public EffectObject PopOneUsableEffect(string effectName);
		private void LoadSingleEffect(string effectName, int loadCount);
		public void LoadMoonObject(Action onLoaded);
		public string GetMikoModelPath();
		public string GetMikoAnimatorPath();
		public void EffectPreloadPoolDestroy();
		public void MoonObjectDestroy();
		public void ProcessBinding();
		private void BindMikoShadow();
		private void BindMoonEffectLocation();
	}
}
