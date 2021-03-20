/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyUICtrl : FastUpdateMonoBehaviour
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
		[HideInInspector]
		public HumanCharacter human;
		[HideInInspector]
		public DragonCharacter dragon;
		[HideInInspector]
		public bool isDragon;
		[CompilerGenerated]
		private int _playerNo_k__BackingField;
		[HideInInspector]
		public MoveControlUI moveControl;
		private bool isActive;
		private bool isAlive;
		private int propertySaturation;
		private int propertyBrightness;
		private CharacterSelector csDragon;
		private VisibleUIObject rebornRootVisible;
		private VisibleUIObject rebornTimeVisible;
		private List<RebornLifeIconUI> rebornIconList;
		private bool isUpdateRebornTimer;
		[HideInInspector]
		public Sprite humanSprite;
		[HideInInspector]
		public Sprite humanSpriteMono;
		[HideInInspector]
		public Sprite dragonSprite;
		[HideInInspector]
		public Sprite dragonSpriteMono;
		[HideInInspector]
		public Material humanMaterial;
		[HideInInspector]
		public Material humanMaterialMono;
		[HideInInspector]
		public Material dragonMaterial;
		[HideInInspector]
		public Material dragonMaterialMono;
		private Dictionary<int, Material> skillMaterialDictionary;
		[HideInInspector]
		public Material dragonButtonMaterial;
		[HideInInspector]
		public Material uniqueTransButtonMaterial;
		[HideInInspector]
		public Material emptyItemSkillMaterial;
		private int uiIndex;
	
		// Properties
		public bool Dying { get; set; }
		[HideInInspector]
		public int playerNo { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public delegate void ButtonDelegate(PartyUICtrl sender);
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass60_0
		{
			// Fields
			public PartyUICtrl __4__this;
			public ButtonDelegate click;
	
			// Constructors
			public __c__DisplayClass60_0();
	
			// Methods
			internal void _Initialize_b__0(float rate);
			internal void _Initialize_b__1();
		}
	
		// Constructors
		public PartyUICtrl();
	
		// Methods
		public void Initialize(ButtonDelegate click, int idx, float scaleFactor, int rebornNum);
		private void OnDestroy();
		public override void FastUpdate();
		public void SetHPGauge(bool immediate);
		public void SetTimeGauge(DragonCharacter dragon, float value, bool immediate);
		public void SetShieldGauge(bool immediate);
		public void SetImage(ElementalType elm, Material face, Material faceMono, Sprite sprite, Sprite spriteMono, bool isDragon);
		private void ChangeImage(bool alive);
		public bool IsActive();
		public void Active(bool b);
		public Vector2 GetButtonPosition();
		private void SetDying(bool value);
		public void SetPlayerNo(int no);
		public Sprite GetPlayerNoImage(int no);
		private static int GetSign(float rate);
		public void LoadMaterial();
		private void LoadDragonButtonMaterial();
		private void LoadUniqueTransButtonMaterial();
		private void LoadSkillMaterial(CharacterBase player, SkillDataElement sde);
		private void LoadSkillMaterial(CharacterBase player, int skillId);
		private void LoadSkillMaterial(CharacterBase player);
		private void LoadAdvanecedSkillMaterial(CharacterBase player, CharacterSkillData data);
		private void LoadBaseIdSkillMaterial(CharacterBase player, CharacterSkillData data);
		private void LoadMaterialForAdvanecedSkill(ActionParts action, CharacterBase player);
		private void LoadSkillMaterialModeChange(HumanCharacter human);
		private void LoadSkillMaterialModeChange(HumanCharacter human, CharaModeDataElement cmde);
		private void LoadChainSkillMaterial(HumanCharacter human);
		private void LoadChainSkillMaterial(HumanCharacter human, SkillChainDataElement cde);
		public bool GetSkillMaterial(int skillId, out Material material);
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
