using System;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	[ExecuteAlways]
	public class SummonStageObjectsSettings : SingletonMonoBehaviour<SummonStageObjectsSettings>
	{
		[Serializable]
		public class SETimeDefine
		{
			public int seNum;

			public float seAtFrame;

			public Rarity rarity;
		}

		[Serializable]
		public class CutInSESetting
		{
			public SETimeDefine[] charaSESets;

			public SETimeDefine[] dragonSESets;

			public SETimeDefine[] amuletSESets;

			public SETimeDefine[] moonSESets;

			public SETimeDefine[] commonSESets;

			public SETimeDefine[] GenerateSequence(GiftType giftType, Rarity rarity, bool isNew)
			{
				return null;
			}
		}

		public float shortRangeShadowFarDistance;

		public float longRangeShadowFarDistance;

		public float floatingShadowMaxVal;

		public float fourLeggedShadowMaxVal;

		public float BipedalShadowMaxVal;

		public float humanoidFloatingShadowMaxVal;

		public float floating2ShadowMaxVal;

		public float floatingV2ShadowMaxVal;

		public float fourLeggedV2ShadowMaxVal;

		public float bipedalV2ShadowMaxVal;

		public float humanoidFloatingV2ShadowMaxVal;

		public float floatingShadowFarDistanceAddition;

		public const float settingFPS = 30f;

		public float charaAdventSETime;

		public float dragonAdventSETime;

		public float charaCutinSETime;

		public float charaCutinRaritySETime;

		public float dragonStoneBreakSETime;

		public float dragonSSRUniverseSETime;

		public float dragonCutinSETime;

		public float dragonCutinRaritySETime;

		public float weaponCutinSETime;

		public float weaponCutinRaritySETime;

		public float moonCutinRaritySETime;

		public float charaCutinFlareEffectTime;

		public float charaCutinSSRTextEffectTime;

		public float weaponCutinFlareEffectTime;

		public float weaponCutinSSRTextEffectTime;

		public float dragonCutinFlareEffectTime;

		public float dragonCutinSSRTextEffectTime;

		public float amuletCutinFlareEffectTime;

		public float amuletCutinSSRTextEffectTime;

		public float ssrCutinTextureOffsetChangeTime;

		public float switchToWeaponEffectTime;

		public float switchToWeaponModelTime;

		public float postSwitchToWeaponModelTime;

		public CutInSESetting cutinSESetting;
	}
}
