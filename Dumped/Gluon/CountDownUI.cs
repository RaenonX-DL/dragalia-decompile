using System;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class CountDownUI : FastUpdateMonoBehaviour
	{
		private enum AnimType
		{
			Loop,
			Blink,
			Hide
		}

		[SerializeField]
		[Header("component")]
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

		[SerializeField]
		[Header("resource")]
		private Sprite[] timeSprite;

		[SerializeField]
		private Sprite[] bgSprite;

		[SerializeField]
		private Sprite[] bgEffectSprite;

		[SerializeField]
		[Header("parameter")]
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

		private AnimType animType;

		private Sequence seqAnim;

		private float headerMargin;

		private readonly Color32 blueBgAddColor;

		public static CountDownUI Create(GameObject parent, bool isRaid, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		private bool UpdateCount(bool isPlayEffect, bool isForce = false)
		{
			return default(bool);
		}

		private void UpdateAnim(int remain, int remainMin, int remainSec)
		{
		}

		public void SetTime(float time)
		{
		}

		public void Play(float time, Action timeUpFunc)
		{
		}

		public void Visible(bool b)
		{
		}

		private void OnUpdateBgFade(float v)
		{
		}

		private void OnUpdateBgAddFade(float v)
		{
		}

		private void OnUpdateBgEffectFade(float v)
		{
		}

		private void OnUpdateBgEffectScale(float v)
		{
		}

		private void OnUpdateBgEffectScale2(float v)
		{
		}

		private void OnUpdateTimerFade(float v)
		{
		}

		private void SetupLoopAnim()
		{
		}

		private void PlayLoopAnim()
		{
		}

		private void SetupBlinkAnim()
		{
		}

		private void PlayBlinkAnim(bool isBlink)
		{
		}

		private void SetupHideAnim()
		{
		}

		private void PlayHideAnim()
		{
		}

		public void Pause(bool isPause)
		{
		}

		private bool IsPlayAnim(AnimType type)
		{
			return default(bool);
		}
	}
}
