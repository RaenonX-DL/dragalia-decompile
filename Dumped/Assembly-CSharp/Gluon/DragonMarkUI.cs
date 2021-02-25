/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DragonMarkUI : CharacterMarkUI
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform markRt;
		[SerializeField]
		private SpriteRenderer markIcon;
		[SerializeField]
		private SpriteRenderer sandTimerIcon;
		[SerializeField]
		private UnityEngine.UI.Text labelText;
		[SerializeField]
		private InGameGaugeUISpriteRenderer timeGauge;
		[SerializeField]
		private RectTransform labelRt;
		[Header]
		[SerializeField]
		private Sprite[] marks;
		[Header]
		[SerializeField]
		private float posY;
		private InGameUICtrl inGameUI;
		private RectTransform rootRt;
		private DragonCharacter owner;
		private CharacterSelector csDragon;
		private SandTimerUI sandTimerUI;
		private CharaCircleGaugeUI circleGaugeUI;
		private bool isActive;
		private bool isOwner;
		private bool enableGaugeAnimation;
		private bool isVisible;
		private const float SAND_TIMER_OFFSET_Y = 40f;
		private const float SAND_TIMER_MARK_ADJUST_Y = 27f;
		private const float CIRCLE_GAUGE_OFFSET_Y = 58f;
		private const float CIRCLE_GAUGE_MARK_ADJUST_Y = 60f;
	
		// Constructors
		public DragonMarkUI();
	
		// Methods
		public void Initialize(DragonCharacter dragon, InGameUICtrl inGameUI);
		private void LateUpdate();
		public void SetEnableGaugeAnimation(bool enable);
		public bool IsChanging();
		public void SetTimeGauge(float value, bool immediate);
		private void Visible(bool b, bool force = false);
		public override void SetVisible(bool visible);
		public override bool IsVisible();
		private bool CheckVisible();
		public override void Show(DisplayType type, CharacterBase target = null);
		public void Display();
		public override void SetPlayerNo(int no, bool own);
		private void UpdatePosition();
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
