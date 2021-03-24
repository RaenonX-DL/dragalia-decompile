/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
		private RectTransform markRt;
		[SerializeField]
		private RectTransform gaugeRt;
		[SerializeField]
		private SpriteRenderer markIcon;
		[SerializeField]
		private SpriteRenderer levelImage;
		[SerializeField]
		private UnityEngine.UI.Text labelText;
		[SerializeField]
		private InGameGaugeUISpriteRenderer gauge;
		[SerializeField]
		private InGameCounterUI levelCounter;
		[SerializeField]
		private GameObject gobjLabel;
		[Header]
		[SerializeField]
		private Sprite[] marks;
		[SerializeField]
		private Vector3 labelPositionBR;
		[SerializeField]
		private Vector3 markPositionBR;
		[SerializeField]
		private Vector3 gaugePositionBR;
		[Header]
		[SerializeField]
		private float posY;
		[SerializeField]
		[Tooltip]
		public float durationPlayerMarkHP;
		private CharacterBase owner;
		private DisplayType currentType;
		private RectTransform rootRt;
		private float remaining;
		private float correctPosY;
		private bool isOwner;
		private InGameUICtrl inGameUI;
		private VisibleUIObject labelVisible;
		private VisibleUIObject rootVisible;
		private Sequence sequenceIdleMark;
		private SandTimerUI sandTimerUI;
		private CharaCircleGaugeUI circleGaugeUI;
		private float moveTime;
		private bool isVisible;
		private Vector2 moveSposS;
		private Vector2 moveSposE;
		private Vector2 prevSpos;
		private const float SAND_TIMER_OFFSET_Y = 23f;
		private const float SAND_TIMER_MARK_ADJUST_Y = 30f;
		private const float CIRCLE_GAUGE_OFFSET_Y = 40f;
		private const float CIRCLE_GAUGE_MARK_ADJUST_Y = 64f;
		private const float MOVE_UPDATE_DURATION_TIME = 0.16666667f;
	
		// Constructors
		public HumanMarkUI();
	
		// Methods
		public void Initialize(CharacterBase player, InGameUICtrl inGameUI);
		private void OnDestroy();
		private void LateUpdate();
		private void InvisibleAll();
		private void InvisibleGauge();
		private void UpdatePosition(CharacterBase chara);
		private Vector2 GetEasePos(Vector2 startPos, Vector2 endPos, float time, float duration);
		private Vector2 GetScreenPos(CharacterBase chara);
		private void PlayerUpdate();
		public override void Show(DisplayType type, CharacterBase target = null);
		private void DisplayMark(DisplayType type);
		private void PlayerHPRoutine();
		public override void SetPlayerNo(int no, bool own);
		private CharacterBase GetCurrentPlayerCharacter();
		public override void SetVisible(bool visible);
		public override bool IsVisible();
		private bool CheckVisible();
		public void CreateSandTimerUI();
		public void ShowSandTimerUI();
		public void HideSandTimerUI();
		public void SetSandTimerUICount(int count);
		public void SetSandTimerUICountColor(SandTimerUI.CountColorType type);
		private bool IsSandTimerUICountDown();
		public override void CreateCircleGaugeUI(CharaCircleGaugeUI.Type type);
		public override void ShowCircleGaugeUI();
		public override void HideCircleGaugeUI();
		public override void SetCircleGaugeUIGaugeTimer(float remainTime, float durationTime);
		public override void SetCircleGaugeUICount(int count);
	}
}
