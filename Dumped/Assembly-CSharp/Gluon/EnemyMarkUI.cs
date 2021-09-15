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
	public class EnemyMarkUI : CharacterMarkUI
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform conditionRt;
		[SerializeField]
		[Tooltip]
		private RectTransform hpGaugeShineRootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform hpGaugeShineImageAdjustRt;
		[SerializeField]
		private ElementIconUISpriteRenderer element;
		[SerializeField]
		private UnityEngine.UI.Text labelText;
		[SerializeField]
		private InGameGaugeUISpriteRenderer gauge;
		[SerializeField]
		private GameObject gobjLabel;
		[SerializeField]
		private GameObject rareLabel;
		[SerializeField]
		private SpriteRenderer emphasisBase;
		[SerializeField]
		private SpriteRenderer emphasisText;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer hpGaugeShineGaugeImage;
		[SerializeField]
		private EnemyRareTimerCtrl enemyRareTimerCtrl;
		[Header]
		[SerializeField]
		private Sprite[] emphasisBaseSprite;
		[SerializeField]
		private Sprite[] emphasisTextSprite;
		[Header]
		[SerializeField]
		private float scaleTargetChara;
		[SerializeField]
		private float scaleMobEnemy;
		[SerializeField]
		[Tooltip]
		public float durationMarkHP;
		[SerializeField]
		private float hpGaugeShineAdjustStartPosX;
		[SerializeField]
		private float hpGaugeShineAdjustEndPosX;
		private InGameUICtrl inGameUI;
		private EnemyCharacter owner;
		private RectTransform rootRt;
		private RectTransform gaugeRt;
		private VisibleUIObject conditionVisible;
		private VisibleUIObject labelVisible;
		private VisibleUIObject hpGaugeShineVisible;
		private SpriteRenderer[] rareLabelSpriteRenderer;
		private CharaCircleGaugeUI circleGaugeUI;
		private HitCountUI hitCountUI;
		private DisplayType currentType;
		private float displayDuration;
		private float correctPosY;
		private bool isVisibleEmphasisMark;
		private bool isVisibleCircleGaugeUI;
		private float untargetDuration;
		private const float UntargetTime = 0.5f;
		private const float CircleGaugeOffsetY = 55f;
	
		// Constructors
		public EnemyMarkUI();
	
		// Methods
		public void Initialize(EnemyCharacter enemy, InGameUICtrl inGameUI);
		private void LateUpdate();
		private void UpdateChara();
		public void UpdateHpGaugeShine();
		private void Invisible();
		public override void Show(DisplayType type, CharacterBase target = null);
		private void CharaHPRoutine(bool bTarget);
		public void CharaHpGaugeClear();
		public void ApplyCharaHpGauge(bool immediate = false);
		private void TargetChara(bool bTarget);
		public override void SetPlayerNo(int no, bool own);
		private void RareVisible(bool b);
		public override void UpdatePosition(bool interpolation = true);
		public override void SetVisible(bool visible);
		public override bool IsVisible();
		public override void CreateCircleGaugeUI(CharaCircleGaugeUI.Type type);
		public override void ShowCircleGaugeUI(CharaCircleGaugeUI.Type type);
		public override void HideCircleGaugeUI(CharaCircleGaugeUI.Type type);
		public override void SetCircleGaugeUIGaugeTimer(CharaCircleGaugeUI.Type type, float time, float initialTime);
		public override void SetCircleGaugeUICount(CharaCircleGaugeUI.Type type, int count);
		public override void SetCircleGaugeUIAdjustPos(CharaCircleGaugeUI.Type type, Vector3 pos);
		public override void SetCircleGaugeUIAdjustScale(CharaCircleGaugeUI.Type type, float scale);
		public override void OnUpdateHpGaugeShineGaugeFade(float value);
		public override void OnUpdateHpGaugeShineLocalPosX(float value);
	}
}
