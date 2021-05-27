/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class HumanMarkUI : CharacterMarkUI
	{
		// Fields
		[Header]
		[SerializeField]
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
		private UnityEngine.UI.Text nameText;
		[SerializeField]
		private InGameGaugeUISpriteRenderer gauge;
		[SerializeField]
		private InGameCounterUI levelCounter;
		[SerializeField]
		private InGameAnimUI levelNumberAnim;
		[SerializeField]
		private InGameAnimUI levelBgAnim;
		[Header]
		[SerializeField]
		private Sprite[] marks;
		[SerializeField]
		private Vector3 namePositionBR;
		[SerializeField]
		private Vector3 markPositionBR;
		[SerializeField]
		private Vector3 gaugePositionBR;
		[Header]
		[SerializeField]
		[Tooltip]
		private float correctPosY;
		[SerializeField]
		[Tooltip]
		public float durationPlayerMarkHP;
		[SerializeField]
		[Tooltip]
		public float iconAdjustPosX;
		[SerializeField]
		[Tooltip]
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
		private const float CircleGaugeMarkAdjustY = 74f;
		private const float MoveUpdateDuration = 0.13333334f;
	
		// Constructors
		public HumanMarkUI();
	
		// Methods
		public void Initialize(HumanCharacter human, InGameUICtrl inGameUI);
		private void OnDestroy();
		private void _Destroy(MonoBehaviour obj);
		private void _Destroy(Transform obj);
		private void LateUpdate();
		private CharacterBase GetCurrentPlayerCharacter();
		private void UpdatePlayer();
		private void UpdateIcon(bool isDisplay);
		private void UpdatePosition(CharacterBase chara);
		private Vector2 GetEasePos(Vector2 startPos, Vector2 endPos, float time, float duration);
		private Vector2 GetScreenPos(CharacterBase chara);
		private void InvisibleAll();
		private void InvisibleGauge();
		public override void Show(DisplayType type, CharacterBase target = null);
		private void Show(DisplayType type);
		private void PlayerHPRoutine();
		public override void SetPlayerNo(int no, bool own);
		public override void SetVisible(bool visible);
		public override bool IsVisible();
		public void CreateSandTimerUI();
		public void ShowSandTimerUI();
		public void HideSandTimerUI();
		public void SetSandTimerUICount(int count);
		public void SetSandTimerUICountColor(SandTimerUI.CountColorType type);
		private bool IsSandTimerUICountDown();
		public override void CreateCircleGaugeUI(CharaCircleGaugeUI.Type type);
		public override void ShowCircleGaugeUI(CharaCircleGaugeUI.Type type);
		public override void HideCircleGaugeUI(CharaCircleGaugeUI.Type type);
		public override void SetCircleGaugeUIGaugeTimer(CharaCircleGaugeUI.Type type, float time, float initialTime);
		public override void SetCircleGaugeUICount(CharaCircleGaugeUI.Type type, int count);
		[CompilerGenerated]
		private void _Initialize_b__47_0(int cur, int next);
		[CompilerGenerated]
		private void _Initialize_b__47_1();
		[CompilerGenerated]
		private void _Initialize_b__47_2();
	}
}
