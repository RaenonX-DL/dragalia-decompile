using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class SummonStageCommonLoadPool
	{
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

		public static SummonStageCommonLoadPool Instance => null;

		public static void DeleteInstance()
		{
		}

		private SummonStageCommonLoadPool()
		{
		}

		static SummonStageCommonLoadPool()
		{
		}

		public void LoadAllAsync(Action onLoaded, int multiCount)
		{
		}

		public void LoadAllAsyncForBoxSummon(Action onLoaded, int multiCount)
		{
		}

		public void LoadAllAsyncForAlbumSummon(Action onLoaded, int multiCount)
		{
		}

		private void LoadAllBindingEffectsAsync(Action onLoaded, int multiCount)
		{
		}

		private void LoadAllBindingEffectsAsyncForBoxSummon(Action onLoaded, int multiCount)
		{
		}

		public EffectObject PopOneUsableEffect(string effectName)
		{
			return null;
		}

		private void LoadSingleEffect(string effectName, int loadCount)
		{
		}

		public void LoadMoonObject(Action onLoaded)
		{
		}

		public string GetMikoModelPath()
		{
			return null;
		}

		public string GetMikoAnimatorPath()
		{
			return null;
		}

		public void EffectPreloadPoolDestroy()
		{
		}

		public void MoonObjectDestroy()
		{
		}

		public void ProcessBinding()
		{
		}

		private void BindMikoShadow()
		{
		}

		private void BindMoonEffectLocation()
		{
		}
	}
}
