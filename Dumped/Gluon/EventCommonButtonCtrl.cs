using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class EventCommonButtonCtrl : MonoBehaviour, ICustomMessage
	{
		private enum LayoutType
		{
			Button3,
			Button4
		}

		public const string buildRewardImageNormalName = "Btn_Build_01_Normal";

		public const string buildRewardImagePressedName = "Btn_Build_01_Pressed";

		[SerializeField]
		private EventQuestPageBase currentPage;

		[SerializeField]
		private LayoutType layoutType;

		[SerializeField]
		private Button missionButton;

		[SerializeField]
		private Badge missionButtonBadge;

		[SerializeField]
		private Image pickupMissionBadge;

		[SerializeField]
		private Button rewardButton;

		[SerializeField]
		private Badge rewardButtonBadge;

		[SerializeField]
		public Button summonButton;

		[SerializeField]
		private Badge summonButtonBadge;

		[SerializeField]
		private Button metalButton;

		[SerializeField]
		private Badge metalButtonBadge;

		[SerializeField]
		private Button buildMetalButton;

		[SerializeField]
		private Badge buildMetalButtonBadge;

		[SerializeField]
		private Image buildRewardImageNormal;

		[SerializeField]
		private Image buildRewardImagePressed;

		[SerializeField]
		private Button collectNormalQuestButton;

		[SerializeField]
		private Button exchangeButton;

		[SerializeField]
		private Badge exchangeButtonBadge;

		[SerializeField]
		private Button castleStoryButton;

		private bool isInited;

		public bool ShouldEnable
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void CheckBadge()
		{
		}

		public void CheckSummonButtonBadge()
		{
		}

		private void UpdateExchangeButtonBadge()
		{
		}

		private void UpdateMissionBadge()
		{
		}

		public void OnRewardButtonTouched()
		{
		}

		public void OnSummonButtonTouched()
		{
		}

		public void OnMetalButtonTouched()
		{
		}

		public void OnBuildMetalButtonTouched()
		{
		}

		public void OnExchangeButtonTouched()
		{
		}

		public void OnCollectNormalButtonTouched()
		{
		}

		public void OnMissionButtonTouched()
		{
		}

		public void OnMessagReceived(CustomMessageType messageType, object data)
		{
		}

		public void OnCastleStoryButtonTouched()
		{
		}

		private bool ShouldShowRaidTradeButton()
		{
			return default(bool);
		}
	}
}
