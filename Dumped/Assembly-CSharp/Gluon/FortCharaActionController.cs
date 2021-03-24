/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon.Master;
using UnityEngine;
using UnityEngine.AI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortCharaActionController : FastUpdateMonoBehaviour
	{
		// Fields
		private const int MOTION_INT_DIGIT_NUM_MAX = 10;
		[SerializeField]
		private float afterTalkingWaitSec;
		[SerializeField]
		private float cookingSitSec;
		[SerializeField]
		private float capsuleColliderRadius;
		[SerializeField]
		private WeaponColliderInfo weaponColliderInfo;
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
		[CompilerGenerated]
		private Action<string> loadVoiceEvent;
		[CompilerGenerated]
		private bool _isJammed_k__BackingField;
		[CompilerGenerated]
		private bool _isForwardJammed_k__BackingField;
		[CompilerGenerated]
		private FortArrangedCharaWatcher _fortArrangedCharaWatcher_k__BackingField;
	
		// Properties
		public bool isJammed { [CompilerGenerated] get; [CompilerGenerated] private set; }
		private bool isForwardJammed { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FortArrangedCharaWatcher fortArrangedCharaWatcher { [CompilerGenerated] get; [CompilerGenerated] set; }
		public GameObject charaObj { get; }
	
		// Events
		public event Action<string> loadVoiceEvent {
			add;
			remove;
		}
	
		// Nested types
		private enum State
		{
			None = 0,
			Staying = 1,
			TappedMotion = 2,
			Waiting = 3,
			Walking = 4
		}
	
		[Serializable]
		public struct WeaponColliderInfo
		{
			// Fields
			public float colliderRadius;
			public float colliderHeight;
			public Vector3 colliderOffset;
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass84_0
		{
			// Fields
			public int charaId;
	
			// Constructors
			public __c__DisplayClass84_0();
	
			// Methods
			internal bool _OnInit_b__0(CharaTalkElement x);
		}
	
		[CompilerGenerated]
		private sealed class _OnClickCharaAction_d__94 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FortCharaActionController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _OnClickCharaAction_d__94(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public FortCharaActionController();
		static FortCharaActionController();
	
		// Methods
		public void OnInit(int pointIndex, Transform parent, FortCharaArrangeController fca, int level, int charaId, GameObject weapon, Texture charaSmallTexture, FortArrangedCharaWatcher charaWatcher);
		public override void FastUpdate();
		private void FastUpdateInStaingState();
		private void FastUpdateInTappedMotionState();
		private void FastUpdateInWaitingState();
		private void FastUpdateInWalkingState();
		private void ChangeStateToWaiting(State afterWaitingState, float waitingDuration);
		protected override void OnDisable();
		public void OnClick();
		private bool LoadVoiceGroup();
		[IteratorStateMachine]
		private IEnumerator OnClickCharaAction();
		private bool IsEnableTap();
		private bool GetMoveTargetPos(FortCharaArrangeController.PlaceType prevtargetPlaceType, int prevtargetPlaceIndex, out Vector3 targetPos);
		private bool GetMoveTargetPosInOppositeSide(Vector3 curPos, Vector3 curTargetPos, out Vector3 newTargetPos);
		private bool GetMoveTargetPosInPlace(FortCharaArrangeController.PlaceType placeType, out Vector3 targetPos);
		private FortCharaArrangeController.Motion GetCookingNextMotion();
		private Vector3 GetHitEffectPos(FortCharaArrangeController.PlaceType placeType);
		private void ChangeStateToWalking();
		private float GetAttackMotionWrapUpRatio();
		[CompilerGenerated]
		private bool _LoadVoiceGroup_b__93_0(CharaDataElement x);
		[CompilerGenerated]
		private bool _OnClickCharaAction_b__94_0();
	}
}
