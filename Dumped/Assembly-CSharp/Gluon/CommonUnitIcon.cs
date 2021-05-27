/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonUnitIcon : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject outButtonGO;
		public GameObject normalGO;
		[Header]
		[SerializeField]
		public CommonIcon icon;
		public GameObject sortDecoAttachNode;
		public GameObject lockImageGO;
		public GameObject flagImageGO;
		public UnityEngine.UI.Text flagText;
		public GameObject newImageGO;
		public GameObject selectingImageGO;
		public GameObject selectCountImageGO;
		public GameObject skinImageGO;
		public GameObject spUpgradeWeaponImageGO;
		public GameObject useEventItemTextGo;
		public UnityEngine.UI.Text selectCountText;
		public CanvasGroup canvasGroup;
		public GameObject favorIcon;
		public UnityEngine.UI.Text plusText;
		public bool noExpanededIcon;
		public int maxLimitHpPlus;
		public int maxLimitAtkPlus;
		public GameObject selectedEquippedCountGO;
		public UnityEngine.UI.Text selectedEquippedCountText;
		public Badge IconBadge;
		public GameObject skinBlackMask;
		public GameObject favoriteImageGO;
		public static readonly Vector2 expandedIconSize;
		public static readonly float expandedIconScale;
		private Coroutine waitForUpdateContentCoroutine;
		private bool isStarted;
		private Tweener ribbonTextBlinkTween;
		private const float ribbonTextBlinkTime = 1f;
	
		// Nested types
		private enum RibbonTextState
		{
			Equipping = 0,
			Target = 1,
			InTeam = 2,
			SupportEquipping = 3,
			Max = 4
		}
	
		[CompilerGenerated]
		private sealed class _WaitForUpdateContentCoroutine_d__46 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CommonIconListCellData data;
			public CommonUnitIcon __4__this;
			public GiftType giftType;
			public IconLoader.Size iconSize;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForUpdateContentCoroutine_d__46(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitForUpdateContentCoroutineAlbum_d__48 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CommonIconListCellData data;
			public CommonUnitIcon __4__this;
			public GiftType giftType;
			public IconLoader.Size iconSize;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitForUpdateContentCoroutineAlbum_d__48(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public CommonUnitIcon __4__this;
			public string[] blinkTexts;
			public Action<float> __9__1;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal void _SetRibbonInfoBlink_b__1(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_1
		{
			// Fields
			public int currentState;
			public UnityAction<bool> blinkCallback;
			public __c__DisplayClass54_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass54_1();
	
			// Methods
			internal void _SetRibbonInfoBlink_b__0(bool visible);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_2
		{
			// Fields
			public bool visible;
			public __c__DisplayClass54_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass54_2();
	
			// Methods
			internal void _SetRibbonInfoBlink_b__2();
		}
	
		// Constructors
		public CommonUnitIcon();
		static CommonUnitIcon();
	
		// Methods
		private void Start();
		public void SetLockState(bool locked);
		public void SetRibbonInfo(string text);
		public void SetRibbonState(bool isEquipping = false, bool isTarget = false, bool isInTeam = false, bool isSupportEquipping = false);
		public virtual void SetBlackMask(bool isOn);
		public void SetNew(bool isOn);
		public void SetAsSelecting(bool isOn);
		public void SetSkinIcon(bool isOn);
		public void SetSpUpgradeWeaponIcon(bool isOn);
		public void SetEventItem(bool isUsed);
		public void SetSelectCount(int count);
		public void SetEquippedCount(bool selected, int equippedCount, int equippableCount, bool isSupportFriend);
		public void SetActiveEquippedCount(bool active);
		public void UpdateByData(CommonIconListCellData data);
		[IteratorStateMachine]
		private IEnumerator WaitForUpdateContentCoroutine(CommonIconListCellData data, GiftType giftType, IconLoader.Size iconSize);
		public void UpdateByDataAlbum(CommonIconListCellData data);
		[IteratorStateMachine]
		private IEnumerator WaitForUpdateContentCoroutineAlbum(CommonIconListCellData data, GiftType giftType, IconLoader.Size iconSize);
		private int SetDecoTextColor(CommonIconListCellData data);
		public void SetDecoInfoByManual(int num, GiftType giftType, CommonSortModel.Condition.SortCondition.SortType type);
		public void SetDecoInfoByManual(Color color, int value, GiftType giftType, CommonSortModel.Condition.SortCondition.SortType type);
		private void OnDestroy();
		private string GetRibbonText(RibbonTextState state);
		public void SetRibbonInfoBlink(string[] blinkTexts);
		private void ReleaseRibbonTextBlinkTween();
		public void SetFavoriteIcon(bool enable, bool isSmallScale = false);
		[CompilerGenerated]
		private bool _WaitForUpdateContentCoroutine_b__46_0();
		[CompilerGenerated]
		private bool _WaitForUpdateContentCoroutineAlbum_b__48_0();
	}
}
