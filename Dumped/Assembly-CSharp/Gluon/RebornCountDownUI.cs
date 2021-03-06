﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class RebornCountDownUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform _rootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _bgRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _iconRt;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _timeImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _unlimitAddIconImage;
		[SerializeField]
		[Tooltip]
		private CircleGauge _gaugeCtrl;
		[Header]
		[SerializeField]
		[Tooltip]
		private Sprite[] _numberSprites;
		[Header]
		[SerializeField]
		[Tooltip]
		private float _iconMerginX;
		private VisibleUIObject _rootVisible;
		private List<RebornLifeIconUI> _iconList;
		private Sequence _seqAnim;
		private Tweener _twUnlimitAddIconAnim;
		private int lastTimeImageIndex;
		[CompilerGenerated]
		private bool _IsPlaying_k__BackingField;
		[CompilerGenerated]
		private bool _IsVisible_k__BackingField;
		private const int TIME_MAX_NUM = 9;
	
		// Properties
		public bool IsPlaying { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsVisible { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public RebornCountDownUI();
	
		// Methods
		public static RebornCountDownUI Create(GameObject parent, bool isUnlimitReborn, int rebornNum, int siblingIndex = -1);
		private void Initialize(GameObject lifePobj, bool isUnlimitReborn, int rebornNum);
		private void OnDestroy();
		public override void FastUpdate();
		public void Show(int restRebornCount, int consumeRebornCount);
		public void Hide();
		public void SetVisible(bool visible);
		public void SetTime(float elapsed, float duration);
		private void PlayShow();
		private void PlayHide();
		private void PlayIconBlink(int restRebornCount, int consumeRebornCount);
		private void PlayUnlimitAddIconBlink();
		private void OnUpdateUnlimitAddIconBlink(float fade);
		private void SetFade(SpriteRenderer obj, float fade);
		public static void SetEnableIcon(ref List<RebornLifeIconUI> list, int enableCount);
		public static void SetVisibleIcon(ref List<RebornLifeIconUI> list, int enableCount);
		public static int GetTimeToImageIndex(float time);
		public static int GetPartyCharaRebornNum(int rebornNum, int partyCharaNum, int partyIndex);
		[CompilerGenerated]
		private void _PlayShow_b__30_0();
		[CompilerGenerated]
		private void _PlayHide_b__31_0();
	}
}
