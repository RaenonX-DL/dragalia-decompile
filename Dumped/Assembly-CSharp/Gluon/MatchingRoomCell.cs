/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Http;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingRoomCell : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Image backgroudImage;
		public Image[] overlayBGs;
		[Header]
		[SerializeField]
		private UIImageMaskToAlpha[] maskToAlpha;
		[Header]
		[SerializeField]
		public Image illustration;
		public Image dragonEmpty;
		[Header]
		[SerializeField]
		private RawImageWithAlphaBlend render3DImage;
		[Header]
		[SerializeField]
		public Image characterInfoBG;
		public Image elementalIcon;
		public UnityEngine.UI.Text characterNameText;
		public UnityEngine.UI.Text combatPowerText;
		public UnityEngine.UI.Text raidCombatPowerText;
		public Image combatPowerInfoBG;
		public Image raidCombatPowerInfoBG;
		[SerializeField]
		private Image isEquipWeaponSkinIcon;
		[SerializeField]
		private Image effectiveAbilityImage1;
		[SerializeField]
		private Image effectiveAbilityImage2;
		public Image youMark;
		[Header]
		[SerializeField]
		public Image playerInfoBG;
		public CanvasGroup playerInfoHiderCanvasGroup;
		public AnotherNameIcons anotherNameIcon;
		public UnityEngine.UI.Text anotherNameText;
		public UnityEngine.UI.Text playerNameText;
		[Header]
		[SerializeField]
		public Transform stampLocation;
		public Transform statusControlLocation;
		public CanvasGroup whiteFlashCanvasGroup;
		public Image[] playerIndexImages;
		public Button detailButton;
		[Header]
		[SerializeField]
		public AnimationUIAutoPublisher insideAnimationPublisher;
		public AnimationUIAutoPublisher insideWithoutPlayerNameAnimationPublisher;
		[Header]
		[SerializeField]
		public bool isLeft;
		public CanvasGroup emptyContentControl;
		[Header]
		[SerializeField]
		public ContentSizeFitter rightCellNamgeLayoutFitter;
		[HideInInspector]
		public MatchingRoomCellStatusControl statusControl;
		[HideInInspector]
		public int positionIndex;
		[HideInInspector]
		public Camera render3DCamera;
		private MatchingReadyState lastReadyState;
		private const float delayByDelayIndex = 0.1f;
		private const float landingAlphaTime = 1f;
		private const float takingOffAlphaTime = 0.6f;
		private const string statusControlPrefabPath = "Prefabs/OutGame/Matching/MatchingRoom/MatchingRoomCellStatusControl";
		private int power;
		private UpdatableUserData dataForDetail;
		private UpdatableUserData latestData;
		private UpdatableUserData processingData;
		private UpdatableUserData pendingData;
		private int _updatingCounter;
		private bool trySkipping;
		private List<Sequence> runningSkippableSequenceList;
		private ColorSet[] colorSet;
		[HideInInspector]
		public MatchingRoomScene matchingRoomScene;
		[CompilerGenerated]
		private int _questId_k__BackingField;
		public bool isEnableRaidBoost;
		public static readonly int[] usingLayerList;
		private bool isFlushing;
	
		// Properties
		private bool isUpdatingData { get; set; }
		public int questId { [CompilerGenerated] private get; [CompilerGenerated] set; }
	
		// Nested types
		public enum PanelMovementType
		{
			None = 0,
			SlideInWithPlayerInfo = 1,
			SlideOutAndClearToEmpty = 2,
			SlideOutThenIn = 3,
			SlideOutThenInWithPlayerInfo = 4
		}
	
		private class UpdatableUserData
		{
			// Fields
			public MatchingRoomPlayerData playerData;
			public int playerIndex;
			public int memberIndex;
			public PanelMovementType movementType;
			public bool isPlayVoice;
	
			// Constructors
			public UpdatableUserData();
			public UpdatableUserData(MatchingRoomPlayerData data, int playerIndex, int memberIndex, PanelMovementType movementType, bool isPlayVoice);
	
			// Methods
			public UpdatableUserData MergeData(UpdatableUserData data);
		}
	
		private class ColorSet
		{
			// Fields
			public Color panelColor;
			public Color combatPowerPanelColor;
			public Color characterNameColor;
			public Color characterNameOutlineColor;
			public Color illustrationShadeColor;
	
			// Constructors
			public ColorSet();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass69_0
		{
			// Fields
			public Sequence seq;
	
			// Constructors
			public __c__DisplayClass69_0();
	
			// Methods
			internal void _AppendSkippableTweener_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass70_0
		{
			// Fields
			public MatchingRoomCell __4__this;
			public Action<UpdatableUserData> onComplete;
			public UpdatableUserData data;
	
			// Constructors
			public __c__DisplayClass70_0();
	
			// Methods
			internal void _DoSlideOut_b__0(float x);
			internal void _DoSlideOut_b__1();
			internal void _DoSlideOut_b__2();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0
		{
			// Fields
			public MatchingRoomCell __4__this;
			public UpdatableUserData data;
	
			// Constructors
			public __c__DisplayClass73_0();
	
			// Methods
			internal void _UpdateByPlayerDataCoroutine_b__0();
			internal void _UpdateByPlayerDataCoroutine_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _UpdateByPlayerDataCoroutine_d__73 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MatchingRoomCell __4__this;
			public UpdatableUserData data;
			private __c__DisplayClass73_0 __8__1;
			public int delayIndex;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdateByPlayerDataCoroutine_d__73(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0
		{
			// Fields
			public MatchingRoomCell __4__this;
			public Action<UpdatableUserData> onComplete;
			public UpdatableUserData data;
			public Action<float> __9__3;
	
			// Constructors
			public __c__DisplayClass74_0();
	
			// Methods
			internal void _DoSlideIn_b__0(GameObject model);
			internal void _DoSlideIn_b__3(float x);
			internal void _DoSlideIn_b__1();
			internal void _DoSlideIn_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _LayoutRebuildCoroutine_d__76 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MatchingRoomCell __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LayoutRebuildCoroutine_d__76(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_0
		{
			// Fields
			public MatchingService.Player playerData;
			public MatchingRoomCell __4__this;
	
			// Constructors
			public __c__DisplayClass78_0();
	
			// Methods
			internal void _OnDetailButtonPressed_b__0(FriendGetSupportCharaDetailResponse responce);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass78_1
		{
			// Fields
			public ulong playerId;
	
			// Constructors
			public __c__DisplayClass78_1();
	
			// Methods
			internal void _OnDetailButtonPressed_b__1(FriendGetSupportCharaDetailResponse responce);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass83_0
		{
			// Fields
			public AbilityDataElement masterAbilityData;
	
			// Constructors
			public __c__DisplayClass83_0();
	
			// Methods
			internal void _SetAbilityIcon_b__0();
			internal void _SetAbilityIcon_b__1();
		}
	
		// Constructors
		public MatchingRoomCell();
		static MatchingRoomCell();
	
		// Methods
		private void Awake();
		private void Start();
		public void InitializeRenderTexture();
		private void SetupModelViewImage(bool enableAlphaBlend);
		public void DisableStamp();
		private void FlushSkippableSequences();
		private void AppendSkippableTweener(Tweener t);
		private void DoSlideOut(UpdatableUserData data, Action<UpdatableUserData> onComplete, bool withPlayerInfo);
		private void DoPanelMovement(UpdatableUserData data);
		public void UpdateByPlayerData(MatchingRoomPlayerData playerData, int playerIndex, int memberIndex, int delayIndex, PanelMovementType movementType, bool isPlayVoice);
		[IteratorStateMachine]
		private IEnumerator UpdateByPlayerDataCoroutine(UpdatableUserData data, int delayIndex);
		private void DoSlideIn(UpdatableUserData data, Action<UpdatableUserData> onComplete, bool withPlayerInfo);
		public void ClearToEmpty();
		[IteratorStateMachine]
		private IEnumerator LayoutRebuildCoroutine();
		private void UpdateUIByData(UpdatableUserData data);
		public void OnDetailButtonPressed();
		public void UpdateReadyState(MatchingReadyState state);
		public MatchingReadyState GetReadyState(MatchingService.Room myRoom);
		public int GetPower();
		private void ShowEffectiveAbilityIcon(UpdatableUserData userData);
		private bool SetAbilityIcon(Image iconImage, int showAbility);
		private bool CheckEnableAbility(MatchingRoomDetailData detailData, UnitDetailModel.DetailDataBase.SkillAbilityInfo skillAbilityInfo);
		[CompilerGenerated]
		private void _DoPanelMovement_b__71_0(UpdatableUserData x);
		[CompilerGenerated]
		private void _DoPanelMovement_b__71_1(UpdatableUserData x);
		[CompilerGenerated]
		private void _DoPanelMovement_b__71_2(UpdatableUserData x);
	}
}
