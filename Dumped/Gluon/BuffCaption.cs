using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
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

			public DisplayIconType IconType
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

			public int IconElement
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

			public string IconName
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

			public int ConditionId
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

			public float Rate
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

			public string Text
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

			public bool IsBuff => default(bool);

			private Param()
			{
			}

			public Param(DisplayIconType iconType, int iconElement, string iconName, int conditionId, float rate, string text)
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

		private string _text;

		private List<Param> _paramList;

		private Tweener[] _twAnimList;

		private Tweener[] _twAlphaAnimList;

		private Tweener _twNextDisp;

		private Tweener _twWait;

		private float _moveY;

		private float _adjust3DPosY;

		private bool _isFastStayTime;

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

		public void Display(CharacterBase chara, Param.DisplayIconType iconType, int iconElement, string iconName, int conditionId, float rate, string text)
		{
		}

		public void StopAndHide()
		{
		}

		public bool IsMatch(CharacterBase chara, string text, bool isIncludeStack)
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
	}
}
