using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cute.Cri;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class QuestCharacterCtrl : MonoBehaviour
	{
		public enum State
		{
			Idle = 0,
			Walk = 1,
			Run = 2,
			Jump = 3,
			BeforeIdle = 8
		}

		public const string animationStateBeforeIdle = "before idle";

		public const string animationStateIdle = "idle";

		private const string animationStateWalk = "walk";

		private const string aniamtionStateAction = "action";

		private const string animationStateAfterAction = "after action";

		private Animator _animator;

		public WeaponType weaponType;

		public int motionType;

		public Vector3 idleCharaRotation;

		private Transform cachedTransform;

		public UnityAction playLandAnimationCallBack;

		public UnityAction runAnimationEndCallBack;

		public UnityAction<int> animationLoadCompleteCallBack;

		public bool isReloadModelComplete;

		public bool isStartLandAnimation;

		public float motionSpeed;

		public int myIndex;

		public SceneShaderSettings charaShaderSettings;

		public Animator animator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject character
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isCompleteLandAnimation
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void LoadCharacterModelAsync(int charaId, int weaponSkinId, SimpleCharacterModel.ShadowCastMethod shadowCastMethod, float shadowCastMargin, float shadowScale, bool useLightProbe, Action<GameObject> onCompleteAction, int drawLayer)
		{
		}

		public void ReloadCharaWeaponModel(int charaId, int weaponSkinId, int drawLayer)
		{
		}

		public void ReloadAttachEffect(bool includeInactive = false)
		{
		}

		public void ApplyLightProbe()
		{
		}

		public void StartTakeOffAnimation()
		{
		}

		public void StartRunAnimation(bool isToLeft, float startPosX, float endPosX, float duration, bool shouldPlayIdleWhenFinished, bool shouldCancelCurrentPlayAnimation)
		{
		}

		public void PlayIdleAnimation()
		{
		}

		public void PlayIdleAnimation(int charaId, bool isQuestAnimation)
		{
		}

		public void PlayLandAnimation(int charaId, AudioPlayback bgmPlayback, int delayIndex, bool isEmptyIndex, bool isQuestAnimation, Func<float> getIdleSyncDelayTimePred)
		{
		}

		private IEnumerator AnotherCharaLoadCompleteCoroutine(AudioPlayback bgmPlayback, int delayIndex, Func<float> getIdleSyncDelayTimePred)
		{
			return null;
		}

		private IEnumerator LandAnimationWaitCoroutine(Animator animator, AudioPlayback bgmPlayback, int delayIndex, Func<float> getIdleSyncDelayTimePred)
		{
			return null;
		}

		public void PlayCharaOutAnimation(bool showWarpEffect = true)
		{
		}

		private IEnumerator PlayLandSe(float delayTime)
		{
			return null;
		}

		public void RemoveShadow()
		{
		}
	}
}
