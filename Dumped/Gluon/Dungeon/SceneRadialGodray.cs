using System.Collections;
using SPFX;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class SceneRadialGodray : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("ã\u0082\u00b4ã\u0083\u0083ã\u0083\u0089ã\u0083¬ã\u0082¤ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0082\u0092è¡\u00a8ç¤ºã\u0081\u0097å§\u008bã\u0082\u0081ã\u0082\u008bã\u0082«ã\u0083¡ã\u0083©è§\u0092åº¦")]
		private float FadeStartRotationRateX;

		[SerializeField]
		[Tooltip("ã\u0082\u00b4ã\u0083\u0083ã\u0083\u0089ã\u0083¬ã\u0082¤ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081\u008cå®\u008cå\u0085\u00a8ã\u0081«è¡\u00a8ç¤ºã\u0081\u0095ã\u0082\u008cã\u0082\u008bã\u0082«ã\u0083¡ã\u0083©è§\u0092åº¦")]
		private float FadeEndRotationRateX;

		[SerializeField]
		[Tooltip("ã\u0082«ã\u0083¡ã\u0083©ã\u0081®ç§»å\u008b\u0095ã\u0081«å\u0090\u0088ã\u0082\u008fã\u0081\u009bã\u0081\u009fã\u0082\u00b4ã\u0083\u0083ã\u0083\u0089ã\u0083¬ã\u0082¤ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®ç§»å\u008b\u0095é\u0087\u008fX")]
		private float EffectMoveRateX;

		[SerializeField]
		[Tooltip("ã\u0082«ã\u0083¡ã\u0083©ã\u0081®ç§»å\u008b\u0095ã\u0081«å\u0090\u0088ã\u0082\u008fã\u0081\u009bã\u0081\u009fã\u0082\u00b4ã\u0083\u0083ã\u0083\u0089ã\u0083¬ã\u0082¤ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®ç§»å\u008b\u0095é\u0087\u008fZ")]
		private float EffectMoveRateZ;

		[SerializeField]
		[Tooltip("ã\u0082\u00b4ã\u0083\u0083ã\u0083\u0089ã\u0083¬ã\u0082¤ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®åº§æ\u00a8\u0099ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088X")]
		private float EffectScreenOffsetX;

		[SerializeField]
		[Tooltip("ã\u0082\u00b4ã\u0083\u0083ã\u0083\u0089ã\u0083¬ã\u0082¤ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0081®åº§æ\u00a8\u0099ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088Y")]
		private float EffectScreenOffsetY;

		[SerializeField]
		[Tooltip("è§£å\u0083\u008fåº¦ã\u0081«ã\u0082\u0088ã\u0082\u008bç§»å\u008b\u0095é\u0087\u008fXã\u0081®è£\u009cæ­£å\u0080¤(å¤§ã\u0081\u008dã\u0081\u0084ã\u0081»ã\u0081©è§£å\u0083\u008fåº¦ã\u0081«ã\u0082\u0088ã\u0082\u008bç§»å\u008b\u0095é\u0087\u008fã\u0081®å·®ã\u0081\u008cå¤§ã\u0081\u008dã\u0081\u008fã\u0081ªã\u0082\u008b)")]
		private float EffectMoveXCorrectionByAspect;

		private const float BaseAspectRatio = 1.775f;

		private SPFXInstance effectInstanceObject;

		private void Start()
		{
		}

		private IEnumerator PlayEffectCoroutine()
		{
			return null;
		}

		private void Update()
		{
		}
	}
}
