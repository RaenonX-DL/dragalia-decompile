/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGamePartyButtonUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform rootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform rebornRootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform rebornIconRt;
		[SerializeField]
		[Tooltip]
		private RectTransform rebornTimeRt;
		[SerializeField]
		private Button button;
		[SerializeField]
		private ElementIconUISpriteRenderer element;
		[SerializeField]
		private InGameGaugeUISpriteRenderer hpGauge;
		[SerializeField]
		private InGameGaugeUISpriteRenderer timeGauge;
		[SerializeField]
		private InGameGaugeUISpriteRenderer shieldGauge;
		[SerializeField]
		private SpriteRenderer playerNoImage;
		[SerializeField]
		private SpriteRenderer frameImage;
		[SerializeField]
		private PlayerBuffUI playerBuffUI;
		[SerializeField]
		private SpriteRenderer faceImage;
		[SerializeField]
		private SpriteRenderer monoFaceImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer rebornTimeImage;
		[Header]
		[SerializeField]
		private Sprite[] playerNoIcon;
		[SerializeField]
		[Tooltip]
		private Sprite[] numberSprites;
		[SerializeField]
		private Material colorAdjustMaterial;
		[Header]
		[SerializeField]
		private float dispBuffSec;
		[SerializeField]
		private float monochromeSaturation;
		[SerializeField]
		private float monochromeBrightness;
		[SerializeField]
		[Tooltip]
		private float rebornIconMerginX;
		private bool _dying;
		[SerializeField]
		private Color dyingColorMax;
		[SerializeField]
		private Color dyingColorMin;
		[HideInInspector]
		public int index;
		[CompilerGenerated]
		private int _playerNo_k__BackingField;
		[HideInInspector]
		public MoveControlUI moveControl;
		[CompilerGenerated]
		private CharacterBase _owner_k__BackingField;
		private bool isActive;
		private bool isAlive;
		private int propertySaturation;
		private int propertyBrightness;
		private CharacterSelector csDragon;
		private VisibleUIObject rebornRootVisible;
		private VisibleUIObject rebornTimeVisible;
		private List<RebornLifeIconUI> rebornIconList;
		private bool isUpdateRebornTimer;
	
		// Properties
		public bool Dying { get; set; }
		[HideInInspector]
		public int playerNo { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CharacterBase owner { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public delegate void ButtonDelegate(CharacterBase chara, int index);
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass48_0
		{
			// Fields
			public InGamePartyButtonUI __4__this;
			public ButtonDelegate click;
	
			// Constructors
			public __c__DisplayClass48_0();
	
			// Methods
			internal void _Initialize_b__0(float rate);
			internal void _Initialize_b__1();
		}
	
		// Constructors
		public InGamePartyButtonUI();
	
		// Methods
		public void Initialize(ButtonDelegate click, int idx, float scaleFactor, int rebornNum);
		public override void FastUpdate();
		public void SetHPGauge(bool immediate);
		public void SetTimeGauge(DragonCharacter dragon, float value, bool immediate);
		public void SetShieldGauge(bool immediate);
		public void SetImage(CharacterBase chara, Material face, Material faceMono, Sprite sprite, Sprite spriteMono);
		private void ChangeImage(bool alive);
		public bool IsActive();
		public void Active(bool b);
		public Vector2 GetButtonPosition();
		private void SetDying(bool value);
		public void SetPlayerNo(int no);
		public Sprite GetPlayerNoImage(int no);
		private static int GetSign(float rate);
		public void SetEnableButton(bool isEnable);
		public void SetEnableRebornIcon(int enableCount);
		public void SetEnableRebornIconOtherPlayer(int playerNo, int rebornNum);
		public void SetVisibleRebornIcon(int enableCount);
		public void SetRebornTime(float elapsed, float duration);
		public int GetVisibleRebornIconNum();
		public int GetEnablelRebornIconNum();
		private bool IsShowRebornCountUI();
	}
}
