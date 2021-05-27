/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DragonMarkUI : CharacterMarkUI
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform conditionRt;
		[SerializeField]
		private RectTransform markRt;
		[SerializeField]
		private RectTransform nameRt;
		[SerializeField]
		private RectTransform iconRt;
		[SerializeField]
		private SpriteRenderer markImage;
		[SerializeField]
		private SpriteRenderer iconImage;
		[SerializeField]
		private SpriteRenderer sandTimerImage;
		[SerializeField]
		private UnityEngine.UI.Text nameText;
		[SerializeField]
		private InGameGaugeUISpriteRenderer timeGauge;
		[Header]
		[SerializeField]
		private Sprite[] marks;
		[Header]
		[SerializeField]
		[Tooltip]
		public float iconAdjustPosX;
		private InGameUICtrl inGameUI;
		private DragonCharacter owner;
		private RectTransform rootRt;
		private VisibleUIObject rootRtVisible;
		private VisibleUIObject conditionRtVisible;
		private VisibleUIObject nameRtVisible;
		private VisibleUIObject iconRtVisible;
		private SandTimerUI sandTimerUI;
		private CharaCircleGaugeUI circleGaugeUI;
		private Vector3 iconOriginalPos;
		private bool isOwner;
		private bool isEnableGaugeAnim;
		private const float SandTimerOffsetY = 40f;
		private const float SandTimerMarkAdjustY = 27f;
		private const float CircleGaugeOffsetY = 58f;
		private const float CircleGaugeMarkAdjustY = 60f;
	
		// Constructors
		public DragonMarkUI();
	
		// Methods
		public void Initialize(DragonCharacter dragon, InGameUICtrl inGameUI);
		private void LateUpdate();
		private void UpdateIcon();
		private void UpdatePosition();
		public void SetEnableGaugeAnim(bool enable);
		public bool IsChangingGaugeAnim();
		public void SetTimeGauge(float value, bool immediate);
		private void InvisibleAll();
		public override void Show(DisplayType type, CharacterBase target = null);
		private void Show();
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
	}
}
