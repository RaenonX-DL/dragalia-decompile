/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BuffCaption : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform captionRt;
		[SerializeField]
		private RectTransform iconRootRt;
		[SerializeField]
		private RectTransform iconRt;
		[SerializeField]
		private UnityEngine.UI.Text caption;
		[SerializeField]
		private SpriteRenderer iconImage;
		[SerializeField]
		private Material iconMaterial;
		[Header]
		[SerializeField]
		private float controlCharacterScale;
		[SerializeField]
		private float characterScale;
		[SerializeField]
		private float enemyScale;
		[SerializeField]
		private float raidBossScale;
		[SerializeField]
		private float enemyAbilityScale;
		[SerializeField]
		private float enemyAbilityIconScale;
		[SerializeField]
		private float iconPositionAddY;
		[SerializeField]
		private float iconTextMergin;
		[SerializeField]
		private float defStayTime;
		[SerializeField]
		private float fastStayTime;
		private RectTransform ownRt;
		private VisibleUIObject visibleObj;
		private MoveControlUI moveControl;
		private InGameUICtrl inGameUI;
		private CharacterBase character;
		private CharacterBase currentCharacter;
		private List<Param> paramList;
		private Tweener[] tweener;
		private Tweener[] tweenerAlpha;
		private Tweener tweenerNext;
		private Tweener tweenerWait;
		private float moveY;
		private float adjustPosY;
		private bool isFastStayTime;
		private const float enemyStatusAdjustPosY = -1.6f;
	
		// Properties
		public bool IsActive { get; }
	
		// Nested types
		public class Param
		{
			// Fields
			public int type;
			public string iconName;
			public float rate;
			public string text;
			public IconType iconType;
	
			// Nested types
			public enum IconType
			{
				None = 0,
				Buff = 1,
				UniqueBuff = 2,
				Status = 3,
				EnemyAbility = 4
			}
	
			// Constructors
			private Param();
			public Param(int type, string iconName, float rate, string text, IconType iconType);
		}
	
		// Constructors
		public BuffCaption();
	
		// Methods
		public static BuffCaption Create(InGameUICtrl inGameUI, GameObject parent, int siblingIndex = -1);
		private void Initialize(InGameUICtrl inGameUI);
		public override void FastUpdate();
		private void LateUpdate();
		private void UpdateMoveY(float val);
		private void UpdateAlpha(float val);
		private void OnCompleteWait();
		private void OnComplete0();
		private void SetNextParam();
		private void OnComplete1();
		private void SetPosition();
		private void Hide();
		private bool IsSkipAlphaAnimation();
		private void SetParam(Param param);
		private void SetText(string text);
		public void SetCharacter(CharacterBase chara);
		public void Display(CharacterBase character, int type, string iconName, float rate, string text, Param.IconType iconType);
		public void StopAndHide();
		public CharacterBase GetCharacter();
		private float GetEnemyStatusAdjustPosY(ref CharacterBase chara);
		private void CreateTweenerWait();
	}
}
