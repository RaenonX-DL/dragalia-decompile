using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class CharaGimmickAddGaugeInputUI : CharaGimmickBaseInputUI
	{
		private class StepData
		{
			public int ShiftInputCount
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int PrevShiftInputCount
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int MaxInputCount
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float ShiftInputRate
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float DiffInputRate
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public StepData()
			{
			}

			public StepData(int maxCount)
			{
			}

			public void Reset()
			{
			}

			public void SetShiftInputCount(int prevShiftInputCount, int shiftInputCount)
			{
			}

			public void SetMaxInputCount(int maxInputCount)
			{
			}
		}

		[SerializeField]
		[Header("component")]
		private RectTransform _fingerRt;

		[SerializeField]
		private RectTransform _fingerBgRt;

		[SerializeField]
		private RectTransform _gaugeRt;

		[SerializeField]
		private RectTransform _gaugeBlinkAnimRt;

		[SerializeField]
		private RectTransform _stepRootRt;

		[SerializeField]
		private SpriteRenderer _gaugeBlinkAnimImage;

		[SerializeField]
		private InGameGaugeUISpriteRenderer _gauge;

		[SerializeField]
		private CharaGimmickAddGaugeInputStepUI _baseStepUI;

		[SerializeField]
		[Header("parameter")]
		private float _showAnimTime;

		[SerializeField]
		private float _hideAnimTime;

		[SerializeField]
		private Vector2 _gaugeAnimScale;

		[SerializeField]
		private Vector2 _gaugeAnimScale2;

		[SerializeField]
		private float _gaugeAnimTime;

		[SerializeField]
		private float _gaugeIntervalTime;

		[SerializeField]
		private float _gaugeAnimTime2;

		[SerializeField]
		[Tooltip("æ®µé\u009a\u008eã\u0081\u0094ã\u0081\u00a8ã\u0081®ã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0081®è\u0089²")]
		private Color[] _gaugeColor;

		private VisibleUIObject _visibleRoot;

		private Sequence _seqShow;

		private Sequence _seqHide;

		private Sequence _seqFinger;

		private Sequence _seqGauge;

		private CharacterBase _owner;

		private int _lastCount;

		private int _maxCount;

		private float _lastGaugeRate;

		private float _originGaugeBlinkAnimRootPosX;

		private List<StepData> _stepDataList;

		private List<CharaGimmickAddGaugeInputStepUI> _stepUIList;

		private bool _show;

		public static CharaGimmickAddGaugeInputUI Create(GameObject parent, CharacterBase owner, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(CharacterBase owner)
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		public override void Show(int num)
		{
		}

		public override void Hide(bool anim = true)
		{
		}

		public override void ReserveItem(int actionId)
		{
		}

		private bool GetActionShiftList(ref List<StepData> list, int actionId, ref int maxInputNum)
		{
			return default(bool);
		}

		private void EnableItem(ref List<StepData> list)
		{
		}

		private void UpdateGaugeStatus(bool force = false)
		{
		}

		private void UpdateGaugeBlinkAnim()
		{
		}

		private void UpdateGaugeStatus(float curGaugevalue, float nextGaugeValue)
		{
		}

		public override void SetCount(int num, bool force = false, bool immediate = false)
		{
		}

		public void OnCompleteMaximum(float value)
		{
		}

		private void PlayShowAnim()
		{
		}

		private void PlayHideAnim()
		{
		}

		private void PlayFingerAnim()
		{
		}

		private void PlayGaugeBgAnim(bool playHideAnim = false)
		{
		}

		private void SetAlpha(ref SpriteRenderer sprite, float alpha)
		{
		}

		private void ClearAnim()
		{
		}

		public override int GetInputType()
		{
			return default(int);
		}

		public override bool IsVisible()
		{
			return default(bool);
		}
	}
}
