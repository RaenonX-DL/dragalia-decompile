/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BossAppearProduction : ProductionBase
	{
		// Fields
		private DungeonManager dungeonManager;
		private Transform playerParent;
		private GameObject bossCameraRoot;
		private EffectObject blurEffect;
		private string bossBlurEffectName;
		private State state;
		private bool isEndPreload;
		private float motionStartTime;
		private float procutionTime;
		private float currentTime;
		private float cameraAnimationCutTime;
		private List<Animator> animatorList;
		private List<BlinkCharaData> blinkCharacterList;
		private List<DragonFacialController> dragonFacialCtrls;
		private bool keepPausingRelease;
		private float waitActivateEnemyTimer;
		private CharacterAnimationEvent bossAnimEvent;
	
		// Nested types
		private enum State
		{
			First = 0,
			WaitPreload = 1,
			WaitOtherPlayersAfterPreload = 2,
			PlayBossAppear = 3,
			WaitAnimation = 4,
			WaitFade = 5,
			WaitActivateEnemy = 6,
			WaitOtherPlayersAfterFade = 7
		}
	
		private class BlinkCharaData
		{
			// Fields
			public BlinkCharacter chara;
			public CharaFaceEyeMotion eyeMotion;
			public CharaFaceMouthMotion mouthMotion;
	
			// Constructors
			public BlinkCharaData();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public EnemyCharacter enemyChara;
			public BlinkCharacter blinkChara;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _SetupEnemy_b__0();
		}
	
		// Constructors
		public BossAppearProduction(bool keepPausingRelease);
	
		// Methods
		public override bool Update();
		public bool IsWaiting();
		private void Release();
		private void SetupEnemy(int index, EnemyDataElement dataElem, int paramId, int positionId, GameObject enemy, CharacterBase owner);
		[CompilerGenerated]
		private void _.ctor_b__19_0(PlayFTU playFTU);
	}
}
