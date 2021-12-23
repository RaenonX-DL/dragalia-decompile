using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class StrategyDialog2 : StrategyDialogBase
	{
		[SerializeField]
		[Header("components")]
		[Tooltip("Dã\u0083\u009dã\u0082¤ã\u0083³ã\u0083\u0088ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text dpointText;

		[SerializeField]
		[Tooltip("ã\u0083¬ã\u0082¢Dã\u0083\u009dã\u0082¤ã\u0083³ã\u0083\u0088ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text dpointRareText;

		[SerializeField]
		[Tooltip("ã\u0082­ã\u0083£ã\u0083©ã\u0083¬ã\u0083\u0099ã\u0083«ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text charaLevelText;

		[SerializeField]
		[Tooltip("ã\u0082­ã\u0083£ã\u0083©çµ\u008cé\u00a8\u0093å\u0080¤ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text charaExpText;

		[SerializeField]
		[Tooltip("ã\u0082­ã\u0083£ã\u0083©HPã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text charaHpText;

		[SerializeField]
		[Tooltip("ã\u0082­ã\u0083£ã\u0083©æ\u0094»æ\u0092\u0083å\u008a\u009bã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text charaAtkText;

		[SerializeField]
		[Tooltip("ã\u0081\u008aã\u0081\u00a8ã\u0082\u0082ã\u0083\u0089ã\u0083©ã\u0082\u00b4ã\u0083³ã\u0083¬ã\u0083\u0099ã\u0083«ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text servitoLevelText;

		[SerializeField]
		[Tooltip("ã\u0081\u008aã\u0081\u00a8ã\u0082\u0082ã\u0083\u0089ã\u0083©ã\u0082\u00b4ã\u0083³HPã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text servitorHpText;

		[SerializeField]
		[Tooltip("ã\u0081\u008aã\u0081\u00a8ã\u0082\u0082ã\u0083\u0089ã\u0083©ã\u0082\u00b4ã\u0083³æ\u0094»æ\u0092\u0083å\u008a\u009bã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text servitorAtkText;

		[SerializeField]
		[Tooltip("ã\u0082­ã\u0083£ã\u0083©ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8")]
		private Image charaIconImage;

		[SerializeField]
		[Tooltip("ã\u0083\u0089ã\u0083©ã\u0082\u00b4ã\u0083³ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8")]
		private Image servitorIconImage;

		[SerializeField]
		[Tooltip("ã\u0082­ã\u0083£ã\u0083©çµ\u008cé\u00a8\u0093å\u0080¤ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Slider charaExpGauge;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u008aã\u0082¦ã\u0083³ã\u0082¹ã\u0081®æ\u0098\u009fï¼\u0095ã\u0083\u0088ã\u0082°ã\u0083«")]
		private Toggle announceStar5Toggle;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u008aã\u0082¦ã\u0083³ã\u0082¹ã\u0081®æ\u0098\u009fï¼\u0094ã\u0083\u0088ã\u0082°ã\u0083«")]
		private Toggle announceStar4Toggle;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u008aã\u0082¦ã\u0083³ã\u0082¹ã\u0081®æ\u0098\u009fï¼\u0093ã\u0083\u0088ã\u0082°ã\u0083«")]
		private Toggle announceStar3Toggle;

		[SerializeField]
		[Tooltip("ã\u0082¢ã\u0083\u008aã\u0082¦ã\u0083³ã\u0082¹ã\u0081®ã\u0082¹ã\u0082­ã\u0083«ã\u0083\u0088ã\u0082°ã\u0083«")]
		private Toggle announceSkillToggle;

		[SerializeField]
		[Tooltip("ã\u0083©ã\u0082¤ã\u0083\u0095å\u009b\u009eæ\u0095°ã\u0083\u0086ã\u0082­ã\u0082¹ã\u0083\u0088")]
		private Text lifeCountText;

		[SerializeField]
		[Header("parameter")]
		private int maxLevelTextSize;

		private int charaId;

		private int servitorId;

		private DmodeActiveAbilityListPopup abilityPU;

		public static StrategyDialog2 Create(GameObject parent)
		{
			return null;
		}

		protected override void Initialize()
		{
		}

		public override void Open()
		{
		}

		public static void ApplyToggleCheckMark(ref Toggle toggle, DmodeCtrl.AnnounceFlagType type)
		{
		}

		protected override bool ExecCloseButtonPressed()
		{
			return default(bool);
		}

		protected override bool ExecRetryButtonPressed()
		{
			return default(bool);
		}

		protected override bool ExecRetireButtonPressed()
		{
			return default(bool);
		}

		public void OnClickCharaInfoButton()
		{
		}

		public void OnClickServitorInfoButton()
		{
		}

		public void OnClickAnnounceStar5(bool value)
		{
		}

		public void OnClickAnnounceStar4(bool value)
		{
		}

		public void OnClickAnnounceStar3(bool value)
		{
		}

		public void OnClickAnnounceSkill(bool value)
		{
		}
	}
}
