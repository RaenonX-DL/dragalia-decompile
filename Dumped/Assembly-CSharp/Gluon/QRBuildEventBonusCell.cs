/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QRBuildEventBonusCell : SimpleAnimationCell
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text infoText;
		[SerializeField]
		private UnityEngine.UI.Text valueText;
		[SerializeField]
		private Image effectImage;
		[SerializeField]
		private Transform flashPosTransform;
		[SerializeField]
		private GameObject notClearImage;
		[CompilerGenerated]
		private float _pointValue_k__BackingField;
		public Action checkLabelAction;
		[CompilerGenerated]
		private bool _isMissionCleared_k__BackingField;
		private FlashPlayer flashPlayer;
		private bool isCancelled;
		private Action onCheckDone;
		private const float moveBackDis = 20f;
	
		// Properties
		public float pointValue { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isMissionCleared { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass20_0
		{
			// Fields
			public QRBuildEventBonusCell __4__this;
			public FlashPlayerManager flashPlayerManager;
			public Action onCheckDone;
			public TweenCallback __9__5;
	
			// Constructors
			public __c__DisplayClass20_0();
	
			// Methods
			internal void _ShowStartAnimation_b__0();
			internal void _ShowStartAnimation_b__5();
			internal void _ShowStartAnimation_b__2();
			internal void _ShowStartAnimation_b__3();
			internal void _ShowStartAnimation_b__4();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static TweenCallback __9__20_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _ShowStartAnimation_b__20_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public QRBuildEventBonusCell __4__this;
			public Action onCheckDone;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _ShowFlashAnimation_b__0();
		}
	
		// Constructors
		public QRBuildEventBonusCell();
	
		// Methods
		protected override void Awake();
		public void SetContent(string info, float value, bool isStageClear);
		public void ShowStartAnimation(FlashPlayerManager flashPlayerManager, Action onCheckDone);
		public void ShowBlinkAnimation();
		private void ShowFlashAnimation(FlashPlayerManager flashPlayerManager, Action onCheckDone);
		private void CreateFlash(FlashPlayerManager flashPlayerManager);
		public void CancelAnimation(FlashPlayerManager flashPlayerManager);
		private void CancelAnimationImpl(FlashPlayerManager flashPlayerManager);
	}
}
