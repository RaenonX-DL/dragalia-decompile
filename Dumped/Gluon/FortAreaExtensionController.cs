using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class FortAreaExtensionController : MonoBehaviour
	{
		public enum FinishFlashAnimType
		{
			AreaExtension,
			Complete
		}

		[SerializeField]
		[Header("ã\u0082\u00a8ã\u0083ªã\u0082¢è§£æ\u0094¾æ\u0099\u0082ã\u0082«ã\u0083¡ã\u0083©æ¼\u0094å\u0087ºè\u00a8­å®\u009a â\u0080»æ\u0099\u0082é\u0096\u0093ã\u0081\u00afç§\u0092")]
		[Header("1.ã\u0082«ã\u0083¡ã\u0083©å¼\u0095ã\u0081\u008f")]
		[Tooltip("1.1 å¾\u0085ã\u0081¡æ\u0099\u0082é\u0096\u0093")]
		private float step1WaitTime;

		[SerializeField]
		[Tooltip("1.2 å¼\u0095ã\u0081\u008fè·\u009dé\u009b¢")]
		private float step1BackMoveDistance;

		[SerializeField]
		[Tooltip("1.2 å¼\u0095ã\u0081\u008fã\u0081®ã\u0081«ã\u0081\u008bã\u0081\u0091ã\u0082\u008bæ\u0099\u0082é\u0096\u0093")]
		private float step1BackMoveDuration;

		[SerializeField]
		[Tooltip("1.2 Easingæ\u008c\u0087å®\u009a")]
		private Ease step1Easing;

		[SerializeField]
		[Header("2.è§£æ\u0094¾ã\u0081\u0099ã\u0082\u008bã\u0082\u00a8ã\u0083ªã\u0082¢ã\u0081¾ã\u0081§ç§»å\u008b\u0095")]
		[Tooltip("2.1 ä\u00b8»å\u009f\u008eã\u0081®å\u0090\u0084Level UPã\u0081®ã\u0082«ã\u0083¡ã\u0083©ç§»å\u008b\u0095speed")]
		private float[] mainFacilityLvUpMoveSpeeds;

		private const float defaultSpeed = 30f;

		[SerializeField]
		[Tooltip("2.2 Easingæ\u008c\u0087å®\u009a")]
		private Ease step2Easing;

		[SerializeField]
		[Header("3.å¤§å·¥é\u0085\u008dç½®")]
		[Tooltip("3.1 å¤§å·¥é\u0085\u008dç½®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		private Vector3[] smithPosDiff;

		[SerializeField]
		[Tooltip("3.2 å¤§å·¥ä½\u009cæ¥­æ\u0099\u0082é\u0096\u0093")]
		private float step3WorkingWait;

		[SerializeField]
		[Tooltip("3.3 å¤§å·¥æ¶\u0088æ»\u0085å¾\u0085ã\u0081¡æ\u0099\u0082é\u0096\u0093")]
		private float step3VanishingWait;

		[SerializeField]
		[Tooltip("3.4 è§£æ\u0094¾ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088å¾\u0085ã\u0081¡æ\u0099\u0082é\u0096\u0093")]
		private float step3ExtensionWait;

		[SerializeField]
		[Tooltip("3.5 ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¢ã\u0082¦ã\u0083\u0088æ\u0099\u0082é\u0096\u0093")]
		private float step3FadeOutDuration;

		[SerializeField]
		[Header("-- ç\u0099½ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¢ã\u0082¦ã\u0083\u0088 --")]
		[Header("4.ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¢ã\u0082¦ã\u0083\u0088ä\u00b8­")]
		[Tooltip("4.1 ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¢ã\u0082¦ã\u0083\u0088ç¶­æ\u008c\u0081æ\u0099\u0082é\u0096\u0093")]
		private float step4FadeOutKeepWait;

		[SerializeField]
		[Tooltip("4.2 ã\u0083\u0095ã\u0082§ã\u0083¼ã\u0083\u0089ã\u0082¤ã\u0083³æ\u0099\u0082é\u0096\u0093")]
		private float step4FadeInDuration;

		private Sequence sequence;

		private GameObject[] dragonSmithObjs;

		private bool isFadingOut;

		private readonly float areaExtensionEffectAdjustY;

		private readonly float completeEffectAdjustY;

		public void OnFinishedMainFacilityFocusAnim(FacilityViewController facilityViewController)
		{
		}

		public void PlayDragonSmithTrioBuildAnimation(Vector3 newAreaPos, Transform cameraCtrlTransform, FacilityViewController facilityViewController, FinishFlashAnimType type = FinishFlashAnimType.AreaExtension)
		{
		}

		public void OnFinishSmishRemoveTrigger()
		{
		}

		public void OnFinishSmishAnim(FacilityViewController facilityViewController, Vector3 areaGroundPos, FinishFlashAnimType type)
		{
		}

		private void SetEffectOrder(EffectObject eo)
		{
		}

		public void QuitAreaExtensionAnimation()
		{
		}
	}
}
