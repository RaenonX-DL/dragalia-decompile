using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class BossAppearProduction : ProductionBase
	{
		private enum State
		{
			First,
			WaitPreload,
			WaitOtherPlayersAfterPreload,
			PlayBossAppear,
			WaitAnimation,
			WaitFade,
			WaitActivateEnemy,
			WaitOtherPlayersAfterFade
		}

		private class BlinkCharaData
		{
			public BlinkCharacter chara;

			public CharaFaceEyeMotion eyeMotion;

			public CharaFaceMouthMotion mouthMotion;
		}

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

		public BossAppearProduction(bool keepPausingRelease)
		{
		}

		public override bool Update()
		{
			return default(bool);
		}

		public bool IsWaiting()
		{
			return default(bool);
		}

		private void Release()
		{
		}

		private void SetupEnemy(int index, EnemyDataElement dataElem, int paramId, int positionId, GameObject enemy, CharacterBase owner)
		{
		}
	}
}
