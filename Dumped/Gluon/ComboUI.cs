using System;
using System.Collections.Generic;
using DG.Tweening;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class ComboUI : MonoBehaviour
	{
		private enum Admiration
		{
			Normal,
			Cool,
			Great,
			Excellent,
			Amazing,
			Fantastic
		}

		private enum FadeState
		{
			Idle = -1,
			FadeIn,
			Stay,
			FadeOut
		}

		[Serializable]
		private class ComboData
		{
			public Sprite admirationSprite;

			public int comboCount;

			public HSVParameter hsvParameter;

			public void Update()
			{
			}
		}

		private class VisibleCtrl
		{
			private bool visible;

			private SpriteRenderer renderer;

			private VisibleCtrl parent;

			public void Initialize(SpriteRenderer r, VisibleCtrl p)
			{
			}

			public void Visible(bool b)
			{
			}

			public bool IsVisible()
			{
				return default(bool);
			}

			public void UpdateVisibility()
			{
			}
		}

		[SerializeField]
		[Header("component")]
		private Transform digitTransform;

		[SerializeField]
		private RectTransform timerGaugeRt;

		[SerializeField]
		private SpriteRenderer[] imageDigit;

		[SerializeField]
		private SpriteRenderer[] imageHit;

		[SerializeField]
		private SpriteRenderer imageAdmiration;

		[SerializeField]
		private SpriteRenderer imageBg;

		[SerializeField]
		[Header("resource")]
		private Material comboMaterial;

		[SerializeField]
		private Sprite[] numbers;

		[SerializeField]
		[Header("parameter")]
		private ComboData[] _comboData;

		[SerializeField]
		private Color _comboAddColor;

		[SerializeField]
		private AnimationCurve _comboColorCurve;

		[SerializeField]
		private Vector2 fadeTime;

		[SerializeField]
		private Vector2 scaleTime;

		[SerializeField]
		private Vector2 scaleAnim;

		[SerializeField]
		private Vector2 admirationScaleTime;

		[SerializeField]
		private Vector2 admirationScaleAnim;

		[SerializeField]
		private Vector3 under100Offset;

		[SerializeField]
		private Vector3[] offset001;

		[SerializeField]
		private Vector3[] offset010;

		[SerializeField]
		private Vector3[] offset100;

		[SerializeField]
		[Tooltip("æ\u0095°å\u0080¤ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0081®é\u0081\u0085å»¶å\u0086\u008dç\u0094\u009fæ\u0099\u0082é\u0096\u0093")]
		private float delayDigitAnimTime;

		private CharacterBase _owner;

		private Tweener _twFadeIn;

		private Tweener _twFadeOut;

		private Sequence _seqDigitScale;

		private Sequence _seqDigitColor;

		private Sequence _seqAdmirationScale;

		private RectTransform _rootRt;

		private RectTransform[] _digitRtArray;

		private VisibleUIObject _rootVisible;

		private VisibleCtrl _bgVisible;

		private VisibleCtrl _admirationVisible;

		private VisibleCtrl[] _digitVisibleArray;

		private VisibleCtrl[] _hitTextVisibleArray;

		private Vector3[] _initDigitPosArray;

		private FadeState _fadeState;

		private Admiration _lastAdmiration;

		private int[] _digitValueArray;

		private bool[] _digitVisibleStateArray;

		private float _currentCountupTime;

		private float _countupTime;

		private float _initTimerGaugeScaleX;

		private float _initChainTime;

		private float _chainTime;

		private float _delayDigitAnimDuration;

		private int _countupNum;

		private int _currentCombo;

		private int _targetCombo;

		private Dictionary<Tweener, bool> _twPauseDict;

		private Dictionary<Sequence, bool> _seqPauseDict;

		private const int NumDigit = 3;

		private const int MaxComboCount = 999;

		private const float DefaultCountupTime = 71f / (339f * (float)Math.PI);

		private const float MinCountupTime = 71f / (678f * (float)Math.PI);

		private static readonly Vector3 DefaultScale;

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		public void PauseCombo(bool isPause)
		{
		}

		private void SetPauseSequence(Sequence seq, bool isPause)
		{
		}

		private void SetPauseTweener(Tweener tw, bool isPause)
		{
		}

		private void GetComboData(int combo, out ComboData data, out Admiration type)
		{
		}

		private void DisplayCombo(int comboVal, bool isPlayDigitAnim, bool isUpdateChainTime)
		{
		}

		public void Display(CharacterBase chara, int comboVal)
		{
		}

		private bool IsEnableChara(CharacterBase chara)
		{
			return default(bool);
		}

		private void Update()
		{
		}

		private float GetChainTime()
		{
			return default(float);
		}

		private float GetFadeOutElapsed()
		{
			return default(float);
		}

		private void ClearValue()
		{
		}

		private void OnUpdateFade(float value)
		{
		}

		private void OnCompleteFade2()
		{
		}

		private void OnUpdateDigitScale(float value)
		{
		}

		private void OnCompleteDigitScale()
		{
		}

		private void OnUpdateDigitColor(float value)
		{
		}

		private void OnCompleteDigitColor()
		{
		}

		private void OnUpdateAdmiration(float value)
		{
		}

		private void OnCompleteAdmiration()
		{
		}
	}
}
