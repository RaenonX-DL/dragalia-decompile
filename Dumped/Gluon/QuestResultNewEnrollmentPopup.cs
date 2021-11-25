using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestResultNewEnrollmentPopup : CommonPopup
	{
		public enum NewEnrollmentType
		{
			None,
			Character,
			Dragon,
			Weapon,
			Amulet
		}

		[SerializeField]
		private GameObject flashNode;

		[SerializeField]
		private Camera _sparkCamera;

		[SerializeField]
		private Camera _flashCamera;

		[SerializeField]
		private FlashPlayerManager _flashPlayerManager;

		[SerializeField]
		private UnitDetailCanvasSetting canvasSetting;

		public Action onInAnimationEnd;

		public Action onOutAnimationStart;

		private FlashPlayer flashPlayerNewCharacter;

		private const float flashIconScale = 1f;

		private NewEnrollmentType newEnrollmentType;

		private int newEnrollmentId;

		private Rarity rarity;

		private ElementalType elementType;

		private WeaponType weaponType;

		public Canvas canvas;

		private const string effectGather = "effect_gather";

		private const string flashOut = "out";

		private Action onFinish;

		private List<EffectObject> effectObject;

		private Vector2 orthographicSize;

		private const string effectGroup = "EFF_CMN_OUT";

		private const string charaEffectNearName = "EFF_CMN_OUT_010";

		private const string charaEffectFrontName = "EFF_CMN_OUT_011";

		private const string rarity2WeaponDragonEffectNearName = "EFF_CMN_OUT_002";

		private const string rarity2WeaponDragonEffectFrontName = "EFF_CMN_OUT_003";

		private const string rarity3WeaponDragonEffectNearName = "EFF_CMN_OUT_004";

		private const string rarity3WeaponDragonEffectFrontName = "EFF_CMN_OUT_005";

		private const string rarity4WeaponDragonEffectNearName = "EFF_CMN_OUT_006";

		private const string rarity4WeaponDragonEffectFrontName = "EFF_CMN_OUT_007";

		private const string rarity5WeaponDragonEffectNearName = "EFF_CMN_OUT_008";

		private const string rarity5WeaponDragonEffectFrontName = "EFF_CMN_OUT_009";

		private const string rarity9AbilityCrestEffectNearName = "EFF_CMN_OUT_139";

		private const string rarity9AbilityCrestEffectFrontName = "EFF_CMN_OUT_140";

		private const string summonSeGroup = "COMMON";

		private const string cutinRarity2SEName = "SE_OUT_COMMON_0042";

		private const string cutinRarity3SEName = "SE_OUT_COMMON_0043";

		private const string cutinRarity4SEName = "SE_OUT_COMMON_0044";

		private const string cutinRarity5SEName = "SE_OUT_COMMON_0045";

		private const string cutinMainDragon = "SE_OUT_COMMON_0052";

		private const string newCommerSeGroup = "STORY_COMMON";

		private const string newCommerSe = "SE_OUT_COMMON_0039";

		private Camera popypUiCamera;

		private string displayName;

		private string replaceRarityPath;

		private string replaceDragonGetRarity2;

		private string replaceDragonGetRarity3;

		private string replaceDragonGetRarity4;

		private string replaceDragonGetRarity5;

		private string replaceWeaponGetRarity2;

		private string replaceWeaponGetRarity3;

		private string replaceWeaponGetRarity4;

		private string replaceWeaponGetRarity5;

		private string replaceAmuletGetRarity2;

		private string replaceAmuletGetRarity3;

		private string replaceAmuletGetRarity4;

		private string replaceAmuletGetRarity5;

		private string replaceAmuletGetRarity9;

		public RawImage modelViewImage;

		public float detailModelZoom;

		public GameObject unitModelNode;

		public Vector3 detailModelPos;

		public Camera render3dCamera;

		public UnitDetailUnitShaderSettings unitShaderSettings;

		private GameObject unitObject;

		private bool isSkip;

		private bool isPrepare;

		private int baseId;

		private int variationId;

		private Coroutine flashPlayCorutine;

		private Coroutine voicePlayCorutine;

		private Coroutine sePlayCorutine;

		private Coroutine sparkPlayCorutine;

		public Camera sparkCamera => null;

		public Camera flashCamera => null;

		public FlashPlayerManager flashPlayerManager => null;

		public int sortingOrder => default(int);

		public static QuestResultNewEnrollmentPopup Create()
		{
			return null;
		}

		public void NewCharacterPrepare(int id, NewEnrollmentType type, Camera uiCamera, Action finish)
		{
		}

		private void LoadAsync()
		{
		}

		private void OnNewCharacterF2ULoad(int index)
		{
		}

		private void Play()
		{
		}

		private void OnPlayNewCommerSe()
		{
		}

		public void OnFlashPlay()
		{
		}

		private IEnumerator OnFlashPlayCorutine()
		{
			return null;
		}

		private void OnInAnimationEnd()
		{
		}

		public void OnNewCharacterSparkEffect()
		{
		}

		private IEnumerator OnNewCharacterSparkEffectCorutine()
		{
			return null;
		}

		private void OnNewCharacterSparkOut()
		{
		}

		private void OnVoicePlay()
		{
		}

		private IEnumerator OnVoicePlayCorutine()
		{
			return null;
		}

		private void OnCutinSePlay()
		{
		}

		private IEnumerator OnCutinSePlayCorutine()
		{
			return null;
		}

		private void OnOutAnimation()
		{
		}

		public void ClosePage()
		{
		}

		public void OnSkip()
		{
		}

		public void SetWeaponModel(int id)
		{
		}

		public GameObject LoadWeapon(int baseId, int variationId)
		{
			return null;
		}

		public void SetupModelViewImage()
		{
		}

		public void SetupInitWeaponPos(int id)
		{
		}
	}
}
