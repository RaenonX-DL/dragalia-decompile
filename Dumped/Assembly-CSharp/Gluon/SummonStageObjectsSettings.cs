/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	[ExecuteAlways]
	public class SummonStageObjectsSettings : SingletonMonoBehaviour<Gluon.SummonStageObjectsSettings>
	{
		// Fields
		public float shortRangeShadowFarDistance;
		public float longRangeShadowFarDistance;
		public float floatingShadowMaxVal;
		public float fourLeggedShadowMaxVal;
		public float BipedalShadowMaxVal;
		public float humanoidFloatingShadowMaxVal;
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
	
		// Nested types
		[Serializable]
		public class SETimeDefine
		{
			// Fields
			public int seNum;
			public float seAtFrame;
			public Rarity rarity;
	
			// Constructors
			public SETimeDefine();
		}
	
		[Serializable]
		public class CutInSESetting
		{
			// Fields
			public SETimeDefine[] charaSESets;
			public SETimeDefine[] dragonSESets;
			public SETimeDefine[] amuletSESets;
			public SETimeDefine[] moonSESets;
			public SETimeDefine[] commonSESets;
	
			// Nested types
			[CompilerGenerated]
			private sealed class __c__DisplayClass5_0
			{
				// Fields
				public Rarity rarity;
	
				// Constructors
				public __c__DisplayClass5_0();
	
				// Methods
				internal bool _GenerateSequence_b__0(SETimeDefine x);
			}
	
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Func<SETimeDefine, float> __9__5_1;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal float _GenerateSequence_b__5_1(SETimeDefine x);
			}
	
			// Constructors
			public CutInSESetting();
	
			// Methods
			public SETimeDefine[] GenerateSequence(GiftType giftType, Rarity rarity, bool isNew);
		}
	
		// Constructors
		public SummonStageObjectsSettings();
	}
}
