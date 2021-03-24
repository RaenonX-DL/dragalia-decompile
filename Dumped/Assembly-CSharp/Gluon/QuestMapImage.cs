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
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestMapImage : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private GameObject _rootObj;
		[SerializeField]
		public RawImage render3dImage;
		[SerializeField]
		public RawImage render3dImageBlack;
		[SerializeField]
		public Camera render3dCamera;
		[SerializeField]
		private GameObject render3dCameraParent;
		[SerializeField]
		private GameObject characterShaderSettingsObj;
		[Header]
		[SerializeField]
		private PartyCharacterShaderSettings charaShaderSettings;
		[SerializeField]
		private Image outerFrame;
		[SerializeField]
		private RectTransform dummyRectQuestTop;
		[SerializeField]
		private RectTransform dummyRectQuestTopFrame;
		[SerializeField]
		private RectTransform dummyRectQuestMiddle;
		[SerializeField]
		private RectTransform dummyRectQuestMiddleFrame;
		private const float waitRenderTime = 0.1f;
		private AnimationUIPart[] animationUIParts;
		private QuestDifficultyImageSetter[] difficultyImageSetters;
		public static Action<RenderTexture> onFinishMapInstance;
		[CompilerGenerated]
		private bool _isRenderBgReady_k__BackingField;
		[CompilerGenerated]
		private bool _isCloseCompleted_k__BackingField;
		[SerializeField]
		private Transform campaignTrans;
		private CampaignButtons campaign;
		private string campaginPath;
		public float fedeIn;
		public float mapMoveTime;
		public float fadeout;
		private bool isMapAnim;
		public Vector3 flashScale;
		public float flashSec;
		private FlashPlayerManager fpMgr;
		private FlashPlayer questTransitionEffect;
		private RenderTexture render3dTexture;
		private bool isCompleteStartProcess;
		private bool _isOpenFlag;
	
		// Properties
		public GameObject rootObj { get; }
		public AnimationUIPart[] animationUIPartsProperty { get; }
		public bool isRenderBgReady { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isCloseCompleted { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsCompleteStartProcess { get; }
		public bool isOpenFlag { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _Start_d__44 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestMapImage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__44(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__46_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _SetupRenderBg_b__46_0();
		}
	
		[CompilerGenerated]
		private sealed class _SetupRenderBg_d__46 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestMapImage __4__this;
			public int locationId;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SetupRenderBg_d__46(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitBgAndOpen_d__52 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestMapImage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitBgAndOpen_d__52(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _WaitBackGroundCoroutine_d__55 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestMapImage __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _WaitBackGroundCoroutine_d__55(int __1__state);
	
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
			public QuestMapImage __4__this;
			public bool isDestroyOnCompleted;
	
			// Constructors
			public __c__DisplayClass57_0();
	
			// Methods
			internal void _Close_b__0();
		}
	
		[CompilerGenerated]
		private sealed class _MapFadeOutAnimationCorutine_d__66 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public QuestMapImage __4__this;
			public Action showQuestPrepare3dImage;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _MapFadeOutAnimationCorutine_d__66(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public QuestMapImage();
		static QuestMapImage();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		public void SetUpRenderBg(int backgroundPath);
		[IteratorStateMachine]
		private IEnumerator SetupRenderBg(int locationId);
		public virtual void OnOpen();
		[IteratorStateMachine]
		private IEnumerator WaitBgAndOpen();
		protected virtual void Open();
		private void WaitBackGround();
		[IteratorStateMachine]
		private IEnumerator WaitBackGroundCoroutine();
		public virtual void OnClose();
		protected virtual void Close(bool isDestroyOnCompleted = true);
		public void OnCloseCompleted(bool isDestroyOnCompleted = true);
		public void OnAppear();
		public void OnHide();
		public void SetDifficultyImage(QuestSelectScene.Difficulty difficulty);
		public void EnableRootObj(bool enable);
		public void SetupCharaShader();
		public void MapDownAnimation();
		public void MapFadeOutAnimation(Action showQuestPrepare3dImage);
		[IteratorStateMachine]
		private IEnumerator MapFadeOutAnimationCorutine(Action showQuestPrepare3dImage);
		private void FrameDefault();
		public Tweener SetScreenTransVisible(bool visible);
		private Sequence MapImageDOScaleY(float endValue, float duration, Ease ease, TweenCallback callback = null);
		private static Sequence DOScaleY(GameObject obj, float endValue, float duration, Ease ease, TweenCallback callback = null);
		[CompilerGenerated]
		private bool _WaitBgAndOpen_b__52_0();
		[CompilerGenerated]
		private void _Open_b__53_0();
		[CompilerGenerated]
		private bool _WaitBackGroundCoroutine_b__55_0();
		[CompilerGenerated]
		private void _MapDownAnimation_b__64_0();
		[CompilerGenerated]
		private bool _MapFadeOutAnimationCorutine_b__66_0();
	}
}
