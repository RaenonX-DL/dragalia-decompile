using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthBaseInfoFrame : MonoBehaviour
	{
		public Text baseNameText;

		public Text plusParamText;

		public LimitStarBase starBase;

		public Image manaStar;

		public Image baseImage;

		public Text baseLvText;

		public Text baseMaxLvText;

		public Text lvInfoText;

		public Text hpText;

		public Text atkText;

		public Text powerText;

		public Text overExpBase;

		public Text overExpText;

		public int growExpParam;

		public int growHpPlusParam;

		public int growAtkPlusParam;

		public UnityAction<bool, bool> growAnimationEndCallBack;

		public Coroutine gaugeUpAnimationCoroutine;

		public Image beforeExpGaugeImage;

		public bool isShowTotalExp;

		public bool isPlayGrowEffect;

		public bool isShowPlusParam;

		public Button changeLvInfoButton;

		public Button changePlusParamButton;

		public Button skipTouchGuardForFrame;

		[SerializeField]
		private Slider baseLvSlider;

		[SerializeField]
		private Transform[] starEffectTransform;

		[SerializeField]
		private Text hpNameText;

		[SerializeField]
		private Text atkNameText;

		[SerializeField]
		private Text powerNameText;

		private Image nowExpGaugeImage;

		private int _expSliderMax;

		private int _expSliderValue;

		private float animationFillAmount;

		private int animationGrowLv;

		private int animationGrowExp;

		private int growLvParam;

		private int growAtkParam;

		private int growHpParam;

		private int animeExpParam;

		private float beforeNextLvExpGaugeAnchorMax;

		private float beforeTotalExpGaugeAnchorMax;

		private readonly Color growthYellow;

		public GrowthBaseInfoData growthBaseInfoData
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

		public int expSliderMax
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int expSliderValue
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		private void OnDestroy()
		{
		}

		private void Awake()
		{
		}

		public void SetupBaseData(ulong baseKeyId, bool isUpdate = true)
		{
		}

		private void UpdateBaseStatusInfo()
		{
		}

		private void UpdateLvInfo(int growHpPlus, int growAtkPlus, int growLv)
		{
		}

		private void UpdateStatusParamInfo(int growHp, int growAtk, int growHpPlus, int growAtkPlus)
		{
		}

		private void UpdatePlusParamInfo(int growPlusHp, int growPlusAtk)
		{
		}

		private void UpdateExpGaugeInfo(int expParam, int growLv)
		{
		}

		public void ChangeLvInfo()
		{
		}

		public void ChangePlusInfo()
		{
		}

		public void BaseInfoUpdate(int getExp, int getHpPlus, int getAtkPlus, int overExp)
		{
		}

		public void ResetGrowData()
		{
		}

		public void StartGrowAnimation(bool isRepeat)
		{
		}

		private IEnumerator GaugeUpAnimation()
		{
			return null;
		}

		private int easeOutAnimation(float time, int startValue, int paramDiff, float totalTime)
		{
			return default(int);
		}

		public void CloseGaugeUpAnimation()
		{
		}

		public void SkillAbilityButtonPressed(int tag)
		{
		}

		private void ShowSkillDetailDialog(int dataId, int level, int maxLevel)
		{
		}

		private void ShowAbilityDetailDialog(int dataId, bool isLockAbility, ElementalType type)
		{
		}

		public void baseIconLongPress()
		{
		}

		public void ShowLimitBreakStarPlus(Transform parentTransform, int index, int total)
		{
		}

		public void ChangeMaxLimitBreakStar(int index)
		{
		}

		public void UpdateGrowthBaseIcon()
		{
		}
	}
}
