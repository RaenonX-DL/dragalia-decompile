/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QRTreasureIcon : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public CommonIcon icon;
		public Image[] sackIcons;
		public Image[] weaponIcons;
		public Image[] pieceIcons;
		public Image[] amuletIcons;
		public Image updatedImage;
		public Image completedImage;
		public GameObject bonusImage;
		[SerializeField]
		private RectTransform _animRoot;
		public GameObject glowFlashParent;
		public GameObject convertFlashParent;
		private const string seItemSwitch = "SE_OUT_COMMON_0026";
		private QuestResultModel.TopPageModel.RewardItemInfo info;
		private QuestResultTopPage topPage;
		private QuestWallResultTopPage topPageWall;
		private float animationDelay;
		private TreasureIconType _treasureIconType;
		private FlashPlayer openFlashPlayer;
		private FlashPlayer rareGlowFlashPlayer;
		private FlashPlayer convertToDewFlashPlayer;
		private Sequence openAnimSequence;
		[SerializeField]
		private GameObject newIcon;
		[CompilerGenerated]
		private bool _isAnimCompleted_k__BackingField;
		public Action<QuestResultModel.TopPageModel.RewardItemInfo> onOpen;
		[CompilerGenerated]
		private int _rowCount_k__BackingField;
		private Color bonusCountTextColor;
		private const string kRareBubbleFlashObjectName = "MOT_result_rare_get";
		private const string kOverLimitBubbleFlashObjectName = "MOT_result_item_max";
		private const string kSRareBubbleFlashObjectName = "MOT_result_ultra_rare_get";
		private const string kRareGlowFlashObjectName = "MOT_icon_rare_effect_front";
		private const string kSRareGlowFlashObjectName = "MOT_icon_ultra_rare_effect_front";
		private const string iconShaderPath = "FlashToUnity/uGUI/GraphicNormalEx";
	
		// Properties
		public RectTransform animRoot { get; }
		public bool isAnimCompleted { [CompilerGenerated] get; [CompilerGenerated] set; }
		public TreasureIconType treasureIconType { get; private set; }
		public int rowCount { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum TreasureIconType
		{
			Normal = 0,
			Rare = 1,
			SuperRare = 2,
			Raid = 3,
			TreasureTime = 4,
			RaidNormal = 5,
			Bonus = 9
		}
	
		[CompilerGenerated]
		private sealed class _WaitForAnimationDelay_d__50 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QRTreasureIcon __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForAnimationDelay_d__50(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass57_0
		{
			// Fields
			public QRTreasureIcon __4__this;
			public QuestResultModel.TopPageModel.RewardItemInfo info;
			public Action __9__0;
			public Action __9__1;
			public Action __9__2;
			public Action __9__3;
			public Action __9__4;
			public Action __9__5;
	
			// Constructors
			public __c__DisplayClass57_0();
	
			// Methods
			internal void _SetupConvertDewFlash_b__0();
			internal void _SetupConvertDewFlash_b__1();
			internal void _SetupConvertDewFlash_b__2();
			internal void _SetupConvertDewFlash_b__3();
			internal void _SetupConvertDewFlash_b__4();
			internal void _SetupConvertDewFlash_b__5();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass61_0
		{
			// Fields
			public Action action;
	
			// Constructors
			public __c__DisplayClass61_0();
	
			// Methods
			internal void _SetPlayOpenFlashCallback_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_0
		{
			// Fields
			public Transform tempTrans;
	
			// Constructors
			public __c__DisplayClass76_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass76_1
		{
			// Fields
			public FlMotion flMotion;
			public __c__DisplayClass76_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass76_1();
	
			// Methods
			internal void _MoveAndReturn_b__0();
		}
	
		// Constructors
		public QRTreasureIcon();
	
		// Methods
		public static QRTreasureIcon Create(QuestResultModel.TopPageModel.RewardItemInfo info, Transform parent, float animationDelay, QuestResultTopPage topPage);
		public static QRTreasureIcon Create(QuestResultModel.TopPageModel.RewardItemInfo info, Transform parent, float animationDelay, QuestWallResultTopPage topPage);
		private void Start();
		public void SetActiveForImages();
		private int GetIconImageIndex();
		public void StartAnimation();
		[IteratorStateMachine]
		private IEnumerator WaitForAnimationDelay();
		private void OnOpenCallback();
		public void SetAnimCompleted();
		public void SwitchBagToTreasureIcon();
		private void SwitchToNormalView();
		public void SkipAnimation();
		public void SetFlashPlayer(FlashPlayer open, FlashPlayer rareGlow, FlashPlayer convertToDew);
		private void SetupConvertDewFlash(FlashPlayer flashPlayer, QuestResultModel.TopPageModel.RewardItemInfo info);
		private void ChangeItemCount(int count);
		private static void ReplacePlane(FlPlane plane, Material srcMat, string name, string str);
		public void PlayOpenFlash();
		public void SetPlayOpenFlashCallback(Action action, FlMotionActionTypes type);
		public void PlayRareGlowFlash();
		public void PlayConvertToDewFlash();
		public void PlayBubbleFlash();
		private string GetBubbleFlashObjectName();
		private string GetRareGlowObjectName();
		public void SetBubbleFlashCallBack(Action action, FlMotionActionTypes type);
		public void PlayRarePopupFlashSkip();
		public void PlayConvertToDewFlashSkip();
		private void SetRarityIndex(QuestResultModel.TopPageModel.RewardItemInfo info);
		public QuestResultModel.TopPageModel.RewardItemInfo GetRewardItemInfo();
		public bool IsPlayBalloonFlash();
		private bool IsPlayRareGrow();
		private bool IsPlayOverLimitFlash();
		public bool IsPlayConvertDewFlash();
		public void MoveAndReturn(Transform trans);
		[CompilerGenerated]
		private void _Start_b__46_0();
		[CompilerGenerated]
		private void _WaitForAnimationDelay_b__50_0();
		[CompilerGenerated]
		private void _WaitForAnimationDelay_b__50_1();
		[CompilerGenerated]
		private void _WaitForAnimationDelay_b__50_2();
	}
}
