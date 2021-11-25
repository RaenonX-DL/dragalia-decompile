using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class Header : MonoBehaviour
	{
		[SerializeField]
		private CircleGaugeGraphic levelGauge;

		[SerializeField]
		private Text staminaText;

		[SerializeField]
		private Text rankNumberText;

		[SerializeField]
		private Text stoneNumText;

		[SerializeField]
		private Text dragonDiamondNumText;

		[SerializeField]
		private Text staminaNumText;

		[SerializeField]
		private Text staminaTimerText;

		[SerializeField]
		private Image staminaTimerImage;

		[SerializeField]
		private RectTransform bpIconOn1;

		[SerializeField]
		private RectTransform bpIconOn2;

		[SerializeField]
		private RectTransform bpIconOff;

		[SerializeField]
		private Text bpNumText;

		[SerializeField]
		private Text bpTimerText;

		[SerializeField]
		private Image bpTimerImage;

		[SerializeField]
		private Button dragonDiamondPlusButton;

		[SerializeField]
		private Button staminaPlusButton;

		[SerializeField]
		private Button bpPlusButton;

		[SerializeField]
		private HeaderExpHover[] expHovers;

		[SerializeField]
		private HeaderMissionMessage missionMessage;

		[SerializeField]
		private HeaderPushMessage pushMessage;

		private int updateCount;

		private const int bpDisplayCount = 6;

		private const string staminaSingleNormalColor = "ffffff";

		private const string staminaSingleOverMaxColor = "ffc600";

		private const string staminaMultiNormalColor = "ffffff";

		private const string staminaMultiOverMaxColorOld = "33cccc";

		private const string staminaMultiOverMaxColor = "ffc600";

		private GameObject promotedIAPEnableTester;

		private Sequence staminaTweenSequence;

		private bool isStopUpdate;

		private int stopUpdateCount;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void ReloadAll(bool isInit = false)
		{
		}

		public void SetRank(int num)
		{
		}

		public void SetExp(int level, int exp)
		{
		}

		public void SetCrystal(int num)
		{
		}

		public void SetDragonDiamond(int num)
		{
		}

		public void SetSingleStamina(long num)
		{
		}

		public void StopUpdate()
		{
		}

		public void RestartUpdate()
		{
		}

		public void SetSingleStaminaTween(long startValue, int addValue)
		{
		}

		public void SetMultiStamina(int num)
		{
		}

		public void UpdateNextStaminaSingleTime()
		{
		}

		public void UpdateNextStaminaMultiTime()
		{
		}

		public void OnDragonDiamondPlusButtonTouched()
		{
		}

		public void OnStaminaPlusButtonTouched()
		{
		}

		public void OnBpPlusButtonTouched()
		{
		}

		public void OnExpHoverAreaDown(int index)
		{
		}

		public void OnExpHoverAreaUp()
		{
		}

		public void SetPlusStoneInteractableState(bool bEnable)
		{
		}

		public void UpdateMissionMessage()
		{
		}

		public void UpdatePushMessage()
		{
		}

		public void SetPushMessageAnimEnable(bool enable)
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		public void SetInteractablePlusButtons(bool interactable)
		{
		}

		private void PlusButtonsMaintenance()
		{
		}

		public bool IsDragonDiamondPlusButtonInteractable()
		{
			return default(bool);
		}

		public bool IsDragonDiamondPlusButtonTopMost()
		{
			return default(bool);
		}
	}
}
