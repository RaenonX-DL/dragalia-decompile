using SPFX;
using UnityEngine;

namespace Gluon
{
	[DisallowMultipleComponent]
	public class CustomSPFXRadialBlurObject : MonoBehaviour
	{
		[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®ç\u0099ºç\u0094\u009fä½\u008dç½®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public Vector3 BlurOffset;

		[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®ç\u0099ºç\u0094\u009fã\u0081¾ã\u0081§ã\u0081®æ\u0099\u0082é\u0096\u0093ï¼\u0088ç§\u0092ï¼\u0089")]
		public float BlurDelay;

		[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®ç\u0099ºç\u0094\u009fæ\u0099\u0082é\u0096\u0093ï¼\u0088ç§\u0092ï¼\u0089")]
		public float BlurTime;

		[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®å¼·ã\u0081\u0095")]
		public float BlurStrength;

		[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®æ¿\u0083ã\u0081\u0095")]
		public float BlurPower;

		[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®æ\u00b8\u009bè¡°")]
		public float BlurAttenuation;

		[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®ã\u0082µã\u0083³ã\u0083\u0097ã\u0083ªã\u0083³ã\u0082°ã\u0082¿ã\u0082¤ã\u0083\u0097")]
		public CustomSPFXBlurController.BlurSampleLabel BlurSample;

		[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®å¼·åº¦ã\u0082«ã\u0083¼ã\u0083\u0096")]
		public AnimationCurve BlurCurve;

		[Tooltip("ã\u0083\u0096ã\u0083©ã\u0083¼ã\u0081®è¿½å¾\u0093ON/OFF")]
		public bool IsBlurFollowGameObject;

		private SPFXInstanceBase SpfxComponent;

		private CustomSPFXBlurController[] BlurComponents;

		private float BlurDelayRest;

		private bool BlurCreated;

		private void Awake()
		{
		}

		private void RetargetBlurComponent()
		{
		}

		private void OnPlay(GameObject This)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void BlurInit()
		{
		}

		private void BlurExec()
		{
		}
	}
}
