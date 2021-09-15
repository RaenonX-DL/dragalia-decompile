/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CountDownUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private SpriteRenderer[] spriteMinute;
		[SerializeField]
		private SpriteRenderer[] spriteSecond;
		[SerializeField]
		private SpriteRenderer spriteSeparator;
		[SerializeField]
		private SpriteRenderer spriteIcon;
		[SerializeField]
		private SpriteRenderer spriteBg;
		[SerializeField]
		private SpriteRenderer spriteBgAdd;
		[SerializeField]
		private SpriteRenderer spriteBgEffect;
		[SerializeField]
		private RectTransform bgEffectRt;
		[Header]
		[SerializeField]
		private Sprite[] timeSprite;
		[SerializeField]
		private Sprite[] bgSprite;
		[SerializeField]
		private Sprite[] bgEffectSprite;
		[Header]
		[SerializeField]
		private int warningRemainTime1;
		[SerializeField]
		private int warningRemainTime2;
		private RectTransform rootRt;
		private VisibleUIObject rootVisible;
		private float remainTime;
		private int lastRemain;
		private Action timeUpFunc;
		private bool isCountDown;
		private bool isAuto;
		private Vector3 tmpVec;
		private Sequence[] sequence;
		private bool[] seqPauseFlag;
		private bool[] seqPlayingFlag;
		private float headerMargin;
		private readonly Color32 blueBgAddColor;
	
		// Nested types
		private enum SeqType
		{
			Step0 = 0,
			Step1 = 1,
			Step2 = 2,
			Max = 3
		}
	
		// Constructors
		public CountDownUI();
	
		// Methods
		public static CountDownUI Create(GameObject parent, bool isRaid, int siblingIndex = -1);
		private void Initialize();
		private void OnDestroy();
		public override void FastUpdate();
		private bool UpdateCount(bool isPlayEffect, bool isForce = false);
		public void SetTime(float time);
		public void Play(float time, Action timeUpFunc);
		public void Visible(bool b);
		private void OnUpdateBgFade(float v);
		private void OnUpdateBgAddFade(float v);
		private void OnUpdateBgEffectFade(float v);
		private void OnUpdateBgEffectScale(float v);
		private void OnUpdateBgEffectScale2(float v);
		private void OnUpdateTimerFade(float v);
		private void OnCompleteSequenceStep2();
		private void SetupSequenceStep0();
		private void StartSequenceStep0();
		private void SetupSequenceStep1();
		private void StartSequenceStep1(bool isBlink);
		private void SetupSequenceStep2();
		private void StartSequenceStep2();
		public void Pause(bool isPause);
		private void PauseSequence(SeqType type, bool isPause);
		private void StopSequence(SeqType type);
	}
}
