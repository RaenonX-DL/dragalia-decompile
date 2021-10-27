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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

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
		[SerializeField]
		[Tooltip]
		protected float humanAdjust3DPosY;
		[SerializeField]
		[Tooltip]
		protected float enemyAdjust3DPosY;
		private RectTransform _rootRt;
		private VisibleUIObject _rootVisible;
		private InGameUICtrl _inGameUI;
		private CharacterBase _chara;
		private string _text;
		private List<Param> _paramList;
		private Tweener[] _twAnimList;
		private Tweener[] _twAlphaAnimList;
		private Tweener _twNextDisp;
		private Tweener _twWait;
		private float _moveY;
		private float _adjust3DPosY;
		private bool _isFastStayTime;
	
		// Properties
		public bool IsActive { get; }
	
		// Nested types
		public class Param
		{
			// Fields
			[CompilerGenerated]
			private DisplayIconType _IconType_k__BackingField;
			[CompilerGenerated]
			private int _IconElement_k__BackingField;
			[CompilerGenerated]
			private string _IconName_k__BackingField;
			[CompilerGenerated]
			private int _ConditionId_k__BackingField;
			[CompilerGenerated]
			private float _Rate_k__BackingField;
			[CompilerGenerated]
			private string _Text_k__BackingField;
	
			// Properties
			public DisplayIconType IconType { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int IconElement { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public string IconName { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public int ConditionId { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public float Rate { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public string Text { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public bool IsBuff { get; }
	
			// Nested types
			public enum DisplayIconType
			{
				None = 0,
				BuffType = 1,
				UniqueBuffType = 2,
				Status = 3,
				EnemyAbility = 4,
				Aura = 5,
				BuffIconId = 6
			}
	
			// Constructors
			private Param();
			public Param(DisplayIconType iconType, int iconElement, string iconName, int conditionId, float rate, string text);
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
		private void UpdatePosition();
		private CharacterBase GetCurrentCharacter(CharacterBase chara);
		private void Hide();
		private bool IsSkipAlphaAnimation();
		private void SetParam(Param param);
		private void SetText(string text);
		public void SetCharacter(CharacterBase chara);
		public void Display(CharacterBase chara, Param.DisplayIconType iconType, int iconElement, string iconName, int conditionId, float rate, string text);
		public void StopAndHide();
		public bool IsMatch(CharacterBase chara, string text, bool isIncludeStack);
		public bool IsMatchChara(CharacterBase chara);
		private float GetAdjust3DPosY(ref CharacterBase chara);
		private void CreateTweenerWait();
	}
}
