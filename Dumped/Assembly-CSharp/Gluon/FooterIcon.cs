/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FooterIcon : MonoBehaviour
	{
		// Fields
		public Image normalBg;
		public Image normalIcon;
		public Image normalTextImage;
		public Image[] selectedImages;
		public Image selectedTextImage;
		public Image disabledBg;
		public Image disabledIcon;
		public Image disabledTextImage;
		public Image maintenanceObject;
		public Image[] banner;
		public PointerEventHandler transparentButton;
		public Image[] newMarks;
		[HideInInspector]
		public GameObject badge;
		private bool isSelected;
		private bool isEnabled;
		private int currentBannerId;
		private List<int> currentBannerIdList;
		private bool isAlreadyInitialized;
		private bool isOnTempoaryDisabled;
		private Sequence sequence;
		private float disableValue;
		private static float disableAnimationDuration;
		private static float disableWaitDuration;
		private static float disableSaturation;
		private static float disableBrightness;
		private Sequence summonIconSeq;
		private int currentMaterialIndex;
		private Material[] materials;
		private bool isMultipleSummon;
		private const float multipleSummonIconChangeTime = 2.5f;
		private bool isNewMarkMaterialsCreated;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public FooterIcon __4__this;
			public Image[] images;
			public Image[] badgeImages;
			public UnityEngine.UI.Text badgeText;
			public CircleOutline badgeOutline;
			public Color outlineColor;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _DisableTemporary_b__0(float value);
			internal void _DisableTemporary_b__1(float value);
			internal void _DisableTemporary_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _SetEnabledCoroutine_d__44 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FooterIcon __4__this;
			public bool isEnabled;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetEnabledCoroutine_d__44(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public FooterIcon();
		static FooterIcon();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		public void SetAdjustMaterial(Material changeableMaterial, Material disabledMaterial, Material selectedMaterial, Material selectedTextMaterial);
		public void SetBadgeMaterial();
		public void SetSelected(bool isSelected, bool forceReset = false);
		public bool GetSelected();
		public bool ShowSummonBanner(SummonDataElement data);
		public bool ShowSummonBanners(List<SummonDataElement> bannerData);
		private void SetBanner(int index);
		public void HideSummonBanner();
		public void DisableTemporary();
		public void SetTouched(bool isTouched);
		public void SetEnabled(bool isEnabled);
		[IteratorStateMachine]
		private IEnumerator SetEnabledCoroutine(bool isEnabled);
		private void SetEnabledImpl(bool isEnabled);
		private void CreateNewMarkMaterial();
		private void SetNewMarksEnabled(bool isEnabled);
		private void SetBannerEnabled(bool isEnabled);
		private void SetBadgeEnabled(bool isEnabled);
		public void KickAnimation();
		[CompilerGenerated]
		private void _ShowSummonBanners_b__38_0();
		[CompilerGenerated]
		private void _ShowSummonBanners_b__38_1();
		[CompilerGenerated]
		private bool _SetEnabledCoroutine_b__44_0();
	}
}
