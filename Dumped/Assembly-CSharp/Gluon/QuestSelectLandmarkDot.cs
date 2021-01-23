/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectLandmarkDot : QuestSelectRoutePoint
	{
		// Fields
		public int startAnimationFrame;
		private FlashPlayer flashLandmark;
		public landmarkStateType landmarkState;
		private QuestSelectScene.Difficulty difficulty;
		private float landmarkMove;
		private FlPlane _landmarkIcon;
		private GameObject uiObj;
		private bool _isPrepareFlyAnimation;
		private const int flashSortOrder = 4;
		private const float landmarkmoveDuration = 1f;
		private const float startFlame = 1f;
		private const float appearFlame = 1.33f;
		private const float shadowAnimScale = 1.364f;
		private const int ribbonOpenFrame = 16;
		private const string ribbonMotionObjectName = "MOT_ribbon_container";
		private const string appearedLabelName = "appeared";
		private const string appearedEndLabelName = "appear_end";
		private const string motBaseIcon = "MOT_base_icon";
		private const string motBaseIconEnd = "end";
		private const string ribbonClose = "out";
		private Sequence landmarkAnimationTween;
	
		// Properties
		public FlPlane landmarkIcon { get; private set; }
		public float moveDuration { get; }
		public bool isPrepareFlyAnimation { get; }
	
		// Nested types
		public enum landmarkStateType
		{
			Start = 0,
			Appear = 1,
			Appeared = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public GameObject ui;
			public QuestSelectLandmarkDot __4__this;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _Initialize_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_1
		{
			// Fields
			public FlPlane plane;
	
			// Constructors
			public __c__DisplayClass30_1();
	
			// Methods
			internal void _Initialize_b__1(Texture2D tex2d);
		}
	
		// Constructors
		public QuestSelectLandmarkDot();
	
		// Methods
		private void OnDestroy();
		public void Initialize(QuestSelectScene scene, FlashPlayerManager flashLandmarkManager, QuestMainLocationElement qmle, GameObject ui, int flashSortOrder);
		public void SetAutoDestroyFlagOff();
		public override void StartActivation();
		public override void ActivateImmediately();
		public int GetPlainCount();
		public void LandmarkAnimation();
		private FlPlane GetPlane(string str);
		private List<FlPlane> GetPlaneList(string str);
		public void RibbonPlayClose();
		public void RibbonPlayMomentOpen();
		public void ShadowEnable(bool enable);
		[CompilerGenerated]
		private void _StartActivation_b__32_0();
		[CompilerGenerated]
		private void _StartActivation_b__32_1();
		[CompilerGenerated]
		private void _StartActivation_b__32_2();
	}
}
