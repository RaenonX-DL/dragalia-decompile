using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.AI;

namespace Gluon
{
	public class FortCharaActionController : FastUpdateMonoBehaviour
	{
		private enum State
		{
			None,
			Staying,
			TappedMotion,
			Waiting,
			Walking
		}

		[Serializable]
		public class WeaponColliderInfo
		{
			public WeaponType type;

			public float colliderRadius;

			public float colliderHeight;

			public Vector3 colliderOffset;
		}

		private const int MOTION_INT_DIGIT_NUM_MAX = 10;

		[SerializeField]
		private float afterTalkingWaitSec;

		[SerializeField]
		private float cookingSitSec;

		[SerializeField]
		private float capsuleColliderRadius;

		[SerializeField]
		private List<WeaponColliderInfo> weaponColliderInfoList;

		[SerializeField]
		private WeaponColliderInfo defaultWeaponColliderInfo;

		[SerializeField]
		private float attackIntervalMin;

		[SerializeField]
		private float attackIntervalMax;

		private float attackIntervalTime;

		[SerializeField]
		private float watchingTurnIntervalTime;

		[SerializeField]
		private float watchingTurnDurationTime;

		[SerializeField]
		private float walkingStayTargetPointSec;

		[SerializeField]
		private float walkingInterruptedThresholdDist;

		[SerializeField]
		private float walkingJamThresholdTime;

		[SerializeField]
		private float walkingJamThresholdDist;

		[SerializeField]
		private float walkingJamWaitingSec;

		[SerializeField]
		private float closeJamCheckDist;

		[SerializeField]
		private float remoteJamCheckDist;

		[SerializeField]
		private float remoteJamCheckAngle;

		private float walkingInterruptedTimer;

		private float walkingDistanceTotal;

		private bool isWalkingInterrupted;

		private float watchingRotValuePerFrame;

		private float targetWatchingRotValue;

		[SerializeField]
		private int fortVoiceIndexStart;

		[SerializeField]
		private float fortCharaMipmapBias;

		[SerializeField]
		private float[] attackMotionWrapUpRatioArray;

		private GameObject charaRootObj;

		private Animator charaAnimator;

		private CapsuleCollider charaCapsuleCollider;

		private NavMeshAgent navMeshAgent;

		private FortCharaArrangePlace arrangePlace;

		private FortCharaArrangePlace targetPlace;

		private int targetPlacePointIndex;

		private int talkIndex;

		private State curState;

		private State gobackState;

		private State comeFromState;

		private int motionWhenTapped;

		private bool isTargetMotionWhenTapped;

		private List<string> voiceNameList;

		private float waitingTimer;

		private float curWaitingDuration;

		private FortCharaArrangeController fortCharaArrangeController;

		private int mainFacilityLevel;

		private List<FortCharaArrangePlace> tempPlaceList;

		private FortTalkBalloon talkBalloon;

		private Vector3 destinationBackUp;

		private Vector3 prevPos;

		private string characterName;

		private List<string> talkTextList;

		private int actionCharaId;

		private List<FortCharaArrangeController.Motion> attackMotionList;

		private bool onAttackEffect;

		private bool onWatchingTurn;

		private bool isKATStateAttack2;

		private int arrangePointIndex;

		private string voiceGroupName;

		private Dictionary<Texture, float> charaOriginalMipmapBiasDictionary;

		private List<int> motionHashList;

		private static bool isCharaTapEnable;

		private const float charaTapCoolDownDuration = 0.3f;

		private Vector3 tempVector3;

		private List<FortCharaArrangeController.PlaceType> tempPlaceTypeList;

		private List<GameObject> tempMoveTargetList;

		private List<GameObject> tempMoveTargetAllList;

		public bool isJammed
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

		private bool isForwardJammed
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public FortArrangedCharaWatcher fortArrangedCharaWatcher
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

		public GameObject charaObj => null;

		public event Action<string> loadVoiceEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void OnInit(int pointIndex, Transform parent, FortCharaArrangeController fca, int level, int charaId, GameObject weapon, Texture charaSmallTexture, FortArrangedCharaWatcher charaWatcher)
		{
		}

		public override void FastUpdate()
		{
		}

		private void FastUpdateInStaingState()
		{
		}

		private void FastUpdateInTappedMotionState()
		{
		}

		private void FastUpdateInWaitingState()
		{
		}

		private void FastUpdateInWalkingState()
		{
		}

		private void ChangeStateToWaiting(State afterWaitingState, float waitingDuration)
		{
		}

		protected override void OnDisable()
		{
		}

		public void OnClick()
		{
		}

		private bool LoadVoiceGroup()
		{
			return default(bool);
		}

		private IEnumerator OnClickCharaAction()
		{
			return null;
		}

		private bool IsEnableTap()
		{
			return default(bool);
		}

		private bool GetMoveTargetPos(FortCharaArrangeController.PlaceType prevtargetPlaceType, int prevtargetPlaceIndex, out Vector3 targetPos)
		{
			return default(bool);
		}

		private bool GetMoveTargetPosInOppositeSide(Vector3 curPos, Vector3 curTargetPos, out Vector3 newTargetPos)
		{
			return default(bool);
		}

		private bool GetMoveTargetPosInPlace(FortCharaArrangeController.PlaceType placeType, out Vector3 targetPos)
		{
			return default(bool);
		}

		private FortCharaArrangeController.Motion GetCookingNextMotion()
		{
			return default(FortCharaArrangeController.Motion);
		}

		private Vector3 GetHitEffectPos(FortCharaArrangeController.PlaceType placeType)
		{
			return default(Vector3);
		}

		private void ChangeStateToWalking()
		{
		}

		private float GetAttackMotionWrapUpRatio()
		{
			return default(float);
		}
	}
}
