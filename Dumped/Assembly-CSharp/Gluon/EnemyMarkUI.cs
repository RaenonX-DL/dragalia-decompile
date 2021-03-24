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
		private Sprite[] emphasisBaseSprite;
		[SerializeField]
		private Sprite[] emphasisTextSprite;
		[SerializeField]
		private EnemyRareTimerCtrl enemyRareTimerCtrl;
		[Header]
		[SerializeField]
		private float scaleTargetChara;
		[SerializeField]
		private float scaleMobEnemy;
		[SerializeField]
		[Tooltip]
		public float durationMarkHP;
		private EnemyCharacter enemy;
		private Transform trsChara;
		private DisplayType currentType;
		private GameObject go;
		private RectTransform trs;
		private RectTransform trsGauge;
		private float remaining;
		private float correctPosY;
		private bool isContinuous;
		private bool isOwner;
		private InGameUICtrl inGameUI;
		private VisibleUIObject rootVisible;
		private VisibleUIObject labelVisible;
		private VisibleUIObject breakVisible;
		private bool isVisibleEmphasisMark;
		private SpriteRenderer[] rareLabelSpriteRenderer;
		private CharaCircleGaugeUI circleGaugeUI;
		private bool isVisibleCircleGaugeUI;
		private HitCountUI hitCountUI;
		private bool isVisible;
		private const float untargetTime = 0.5f;
		private float currentUntargetTime;
		private const float CIRCLE_GAUGE_OFFSET_Y = 55f;
	
		// Constructors
		public EnemyMarkUI();
	
		// Methods
		public void Initialize(EnemyCharacter enemy, InGameUICtrl inGameUI);
		private void LateUpdate();
		private void Invisible();
		private void CharacterUpdate();
		public override void Show(DisplayType type, CharacterBase target = null);
		private void CharaHPRoutine(bool bTarget);
		public void CharaHpGaugeClear();
		public void ApplyCharaHpGauge(bool immediate = false);
		private void TargetChara(bool bTarget);
		public override void SetPlayerNo(int no, bool own);
		private void RareVisible(bool b);
		public void UpdatePosition();
		public override void SetVisible(bool visible);
		public override bool IsVisible();
		private bool CheckVisible();
		public override void CreateCircleGaugeUI(CharaCircleGaugeUI.Type type);
		public override void ShowCircleGaugeUI();
		public override void HideCircleGaugeUI();
		public override void SetCircleGaugeUIGaugeTimer(float remainTime, float durationTime);
		public override void SetCircleGaugeUICount(int count);
		public override void SetCircleGaugeUIAdjustPos(Vector3 pos);
		public override void SetCircleGaugeUIAdjustScale(float scale);
	}
}
