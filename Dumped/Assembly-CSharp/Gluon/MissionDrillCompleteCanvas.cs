/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using Spine;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MissionDrillCompleteCanvas : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CanvasGroup canvasGroup;
		[SerializeField]
		private GameObject spineRoot;
		[SerializeField]
		private UnityEngine.UI.Text messageTitle;
		[SerializeField]
		private UnityEngine.UI.Text messageBody;
		[SerializeField]
		private CanvasGroup messageBoardCanvasGroup;
		[SerializeField]
		private RectTransform messageBoardRect;
		[SerializeField]
		private float enterFadeFrame;
		[SerializeField]
		private float boardMoveFrame;
		private SkeletonGraphic nhaamCompleteSkeletonGraphic;
		private Action onCompleteDirectionFinish;
		private const string nhaamCompleteAnimationPath = "Prefabs/OutGame/MissionDrill/pf_TeacherNhaamComplete";
		private const string seComplete = "SE_OUT_COMMONUSE_0004";
		private Vector3 messageBoardRectInitPosition;
		private float messageBoardMoveHeight;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public string voice;
			public MissionDrillCompleteCanvas __4__this;
	
			// Constructors
			public __c__DisplayClass17_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_1
		{
			// Fields
			public TouchGuardObject guardObject;
			public __c__DisplayClass17_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass17_1();
	
			// Methods
			internal void _PlayNhaamCompleteAnimation_b__0(TrackEntry _);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _PlayNhaamExitAnimation_b__0(TrackEntry _);
		}
	
		// Constructors
		public MissionDrillCompleteCanvas();
	
		// Methods
		public void Initialize(Action onPlayComplete);
		public void PlayCompleteDirection(DrillTalkElement talk);
		public void PlayExitAnimation();
		private void PlayNhaamCompleteAnimation(string skinName, string motionName, string idleName, string voice);
		private void PlayNhaamExitAnimation(Action onComplete);
		public void OnPressed();
		[CompilerGenerated]
		private void _PlayExitAnimation_b__16_0();
	}
}
