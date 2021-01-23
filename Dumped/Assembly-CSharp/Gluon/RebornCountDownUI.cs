/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		private Sequence _animSeq;
		[CompilerGenerated]
		private bool _isPlaying_k__BackingField;
		private int lastTimeImageIndex;
		private const int TIME_MAX_NUM = 9;
	
		// Properties
		public bool isPlaying { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public RebornCountDownUI();
	
		// Methods
		public static RebornCountDownUI Create(GameObject parent, int rebornNum, int siblingIndex = -1);
		private void Initialize(GameObject lifePobj, int rebornNum);
		private void OnDestroy();
		public override void FastUpdate();
		public void Show(int restRebornCount, int consumeRebornCount);
		public void Hide();
		public void SetVisible(bool visible);
		public void SetTime(float elapsed, float duration);
		private void PlayShow();
		private void PlayHide();
		private void PlayBlink(int restRebornCount, int consumeRebornCount);
		public static void SetEnableIcon(ref List<RebornLifeIconUI> list, int enableCount);
		public static void SetVisibleIcon(ref List<RebornLifeIconUI> list, int enableCount);
		public static int GetTimeToImageIndex(float remain, float duration);
		public static int GetPartyCharaRebornNum(int rebornNum, int partyCharaNum, int partyIndex);
		[CompilerGenerated]
		private void _PlayShow_b__24_0();
		[CompilerGenerated]
		private void _PlayHide_b__25_0();
	}
}
