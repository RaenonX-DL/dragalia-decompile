using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class HumanMarkUI : CharacterMarkUI
	{
		[SerializeField]
		[Header("component")]
		private RectTransform conditionRootRt;

		[SerializeField]
		private RectTransform conditionRt;

		[SerializeField]
		private RectTransform markRt;

		[SerializeField]
		private RectTransform gaugeRt;

		[SerializeField]
		private RectTransform nameRt;

		[SerializeField]
		private RectTransform iconRt;

		[SerializeField]
		private RectTransform levelAnimRt;

		[SerializeField]
		private SpriteRenderer markImage;

		[SerializeField]
		private SpriteRenderer iconImage;

		[SerializeField]
		private Text nameText;

		[SerializeField]
		private InGameGaugeUISpriteRenderer gauge;

		[SerializeField]
		private InGameCounterUI levelCounter;

		[SerializeField]
		private InGameAnimUI levelNumberAnim;

		[SerializeField]
		private InGameAnimUI levelBgAnim;

		[SerializeField]
		[Header("resource")]
		private Sprite[] marks;

		[SerializeField]
		private Vector3 namePositionBR;

		[SerializeField]
		private Vector3 markPositionBR;

		[SerializeField]
		private Vector3 gaugePositionBR;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0082¹ã\u0082\u00afã\u0083ªã\u0083¼ã\u0083³åº§æ\u00a8\u0099å¤\u0089æ\u008f\u009bæ\u0099\u0082ã\u0081®èª¿æ\u0095\u00b4å\u0080¤")]
		private float correctPosY;

		[SerializeField]
		[Tooltip("HPè¡\u00a8ç¤ºæ\u0099\u0082é\u0096\u0093(s)")]
		public float durationPlayerMarkHP;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³èª¿æ\u0095\u00b4å\u0080¤")]
		public float iconAdjustPosX;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³èª¿æ\u0095\u00b4æ\u009c\u0080ä½\u008eå\u0080¤")]
		public float iconMinAdjustPosX;

		private InGameUICtrl inGameUI;

		private HumanCharacter owner;

		private RectTransform rootRt;

		private VisibleUIObject rootRtVisible;

		private VisibleUIObject conditionRootRtVisible;

		private VisibleUIObject conditionRtVisible;

		private VisibleUIObject nameRtVisible;

		private VisibleUIObject iconRtVisible;

		private VisibleUIObject levelAnimRtVisible;

		private Sequence seqMark;

		private SandTimerUI sandTimerUI;

		private Dictionary<CharaCircleGaugeUI.Type, CharaCircleGaugeUI> circleGaugeDic;

		private Vector3 iconOriginalPos;

		private DisplayType currentType;

		private float displayDuration;

		private float moveDuration;

		private bool isOwner;

		private Vector2 moveSposS;

		private Vector2 moveSposE;

		private Vector2 prevSpos;

		private const float SandTimerOffsetY = 33f;

		private const float SandTimerMarkAdjustY = 40f;

		private const float CircleGaugeOffsetY = 50f;

		private const float CircleGaugeMarkAdjustY = 82f;

		private const float MoveUpdateDuration = 142f / (339f * (float)Math.PI);

		public void Initialize(HumanCharacter human, InGameUICtrl inGameUI)
		{
		}

		private void OnDestroy()
		{
		}

		private void _Destroy(MonoBehaviour obj)
		{
		}

		private void _Destroy(Transform obj)
		{
		}

		private void LateUpdate()
		{
		}

		private CharacterBase GetCurrentPlayerCharacter()
		{
			return null;
		}

		private void UpdatePlayer()
		{
		}

		private void UpdateIcon(bool isDisplay)
		{
		}

		public override void UpdatePosition(bool interpolation = true)
		{
		}

		private Vector2 GetEasePos(Vector2 startPos, Vector2 endPos, float time, float duration)
		{
			return default(Vector2);
		}

		private Vector2 GetScreenPos(CharacterBase chara)
		{
			return default(Vector2);
		}

		private void InvisibleAll()
		{
		}

		private void InvisibleGauge()
		{
		}

		public override void Show(DisplayType type, [Optional] CharacterBase target)
		{
		}

		private void Show(DisplayType type)
		{
		}

		private void PlayerHPRoutine()
		{
		}

		public override void SetPlayerNo(int no, bool own)
		{
		}

		public override void SetVisible(bool visible)
		{
		}

		public override bool IsVisible()
		{
			return default(bool);
		}

		public void CreateSandTimerUI()
		{
		}

		public void ShowSandTimerUI()
		{
		}

		public void HideSandTimerUI()
		{
		}

		public void SetSandTimerUICount(int count)
		{
		}

		public void SetSandTimerUICountColor(SandTimerUI.CountColorType type)
		{
		}

		private bool IsSandTimerUICountDown()
		{
			return default(bool);
		}

		public override void CreateCircleGaugeUI(CharaCircleGaugeUI.Type type)
		{
		}

		public override void ShowCircleGaugeUI(CharaCircleGaugeUI.Type type)
		{
		}

		public override void HideCircleGaugeUI(CharaCircleGaugeUI.Type type)
		{
		}

		public override void SetCircleGaugeUIGaugeTimer(CharaCircleGaugeUI.Type type, float time, float initialTime)
		{
		}

		public override void SetCircleGaugeUICount(CharaCircleGaugeUI.Type type, int count)
		{
		}
	}
}
