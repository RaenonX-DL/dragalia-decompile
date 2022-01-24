using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BuffCaption : FastUpdateMonoBehaviour
	{
		public class Param
		{
			public enum DisplayIconType
			{
				None,
				BuffType,
				UniqueBuffType,
				Status,
				EnemyAbility,
				Aura,
				BuffIconId
			}

			public DisplayIconType iconType
			{
				[CompilerGenerated]
				get
				{
					return default(DisplayIconType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int iconElement
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public string iconName
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int conditionId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float rate
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public string text
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public AbilityConst.UnitType abilityOwnerUnit
			{
				[CompilerGenerated]
				get
				{
					return default(AbilityConst.UnitType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int abilityOwnerId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public bool isBuff => default(bool);

			public Param()
			{
			}

			public Param(DisplayIconType iconType, int iconElement, string iconName, int conditionId, float rate, string text, AbilityConst.UnitType abilityOwnerUnit, int abilityOwnerId)
			{
			}

			public void Reset()
			{
			}

			public void CopyTo(Param param)
			{
			}

			public bool IsMatch(string text, AbilityConst.UnitType abilityOwnerUnit, int abilityOwnerId)
			{
				return default(bool);
			}
		}

		public class DispAbilityData
		{
			public AbilityConst.UnitType unitType
			{
				[CompilerGenerated]
				get
				{
					return default(AbilityConst.UnitType);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int unitId
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public AbilityDataElement ade
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public int expireCnt
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			private DispAbilityData()
			{
			}

			public DispAbilityData(AbilityConst.UnitType unitType, int unitId, AbilityDataElement ade, int expireCnt)
			{
			}

			public void SetExpireCnt(int expireCnt)
			{
			}
		}

		[SerializeField]
		[Header("component")]
		private RectTransform captionRt;

		[SerializeField]
		private RectTransform iconRootRt;

		[SerializeField]
		private RectTransform iconRt;

		[SerializeField]
		private Text caption;

		[SerializeField]
		private SpriteRenderer iconImage;

		[SerializeField]
		private Material iconMaterial;

		[SerializeField]
		[Header("parameter")]
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
		[Tooltip("ã\u0082­ã\u0083£ã\u0083©ã\u0081®3D Yåº§æ\u00a8\u0099èª¿æ\u0095\u00b4å\u0080¤")]
		protected float humanAdjust3DPosY;

		[SerializeField]
		[Tooltip("æ\u0095µã\u0081®3D Yåº§æ\u00a8\u0099èª¿æ\u0095\u00b4å\u0080¤")]
		protected float enemyAdjust3DPosY;

		private RectTransform _rootRt;

		private VisibleUIObject _rootVisible;

		private InGameUICtrl _inGameUI;

		private CharacterBase _chara;

		private Param _param;

		private List<Param> _paramList;

		private Tweener[] _twAnimList;

		private Tweener[] _twAlphaAnimList;

		private Tweener _twNextDisp;

		private Tweener _twWait;

		private float _moveY;

		private float _adjust3DPosY;

		private bool _isFastStayTime;

		public static Dictionary<AbilityConst.UnitType, List<DispAbilityData>> displayedAbilityDataDict;

		public bool IsActive => default(bool);

		public static BuffCaption Create(InGameUICtrl inGameUI, GameObject parent, int siblingIndex = -1)
		{
			return null;
		}

		private void Initialize(InGameUICtrl inGameUI)
		{
		}

		public override void FastUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateMoveY(float val)
		{
		}

		private void UpdateAlpha(float val)
		{
		}

		private void OnCompleteWait()
		{
		}

		private void OnComplete0()
		{
		}

		private void SetNextParam()
		{
		}

		private void OnComplete1()
		{
		}

		private void UpdatePosition()
		{
		}

		private CharacterBase GetCurrentCharacter(CharacterBase chara)
		{
			return null;
		}

		private void Hide()
		{
		}

		private bool IsSkipAlphaAnimation()
		{
			return default(bool);
		}

		private void SetParam(Param param)
		{
		}

		private void SetText(string text)
		{
		}

		public void SetCharacter(CharacterBase chara)
		{
		}

		public void Display(CharacterBase chara, Param.DisplayIconType iconType, int iconElement, string iconName, int conditionId, float rate, string text, AbilityConst.UnitType abilityOwnerUnit, int abilityOwnerId)
		{
		}

		public void Remove(CharacterBase chara, string text, AbilityConst.UnitType abilityOwnerUnit = AbilityConst.UnitType.None, int abilityOwnerId = 0)
		{
		}

		public void StopAndHide()
		{
		}

		public bool IsMatch(CharacterBase chara, string text, bool isIncludeStack, AbilityConst.UnitType abilityOwnerUnit, int abilityOwnerId)
		{
			return default(bool);
		}

		public bool IsMatchChara(CharacterBase chara)
		{
			return default(bool);
		}

		private float GetAdjust3DPosY(ref CharacterBase chara)
		{
			return default(float);
		}

		private void CreateTweenerWait()
		{
		}

		public static void ClearDisplayedAbilityData()
		{
		}

		public static void AddDisplayedAbilityData(AbilityConst.UnitType unitType, int unitId, AbilityDataElement ade, int expireCnt)
		{
		}

		public static void RemoveDisplayedAbilityData(AbilityConst.UnitType unitType, int unitId)
		{
		}

		public static bool FindDisplayedAbilityData(AbilityConst.UnitType unitType, int unitId, out DispAbilityData dispAbilityData)
		{
			return default(bool);
		}

		public static bool FindDisplayedAbilityData(AbilityConst.UnitType unitType, int unitId)
		{
			return default(bool);
		}
	}
}
