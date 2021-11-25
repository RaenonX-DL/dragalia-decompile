using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class BRPulse : MonoBehaviour
	{
		private List<BRPulsePoint> points;

		public float maxRadius;

		[SerializeField]
		[Tooltip("CommonActionHitAttributeã\u0081®ã\u0083©ã\u0083\u0099ã\u0083«")]
		private string actionHitAttributeName;

		[SerializeField]
		[Tooltip("ã\u0082²ã\u0083¼ã\u0083\u00a0é\u0096\u008bå§\u008bã\u0081\u0097ã\u0081¦ã\u0081\u008bã\u0082\u0089å\u008f\u008eæ\u009d\u009fã\u0081\u0097å§\u008bã\u0082\u0081ã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®ã\u0083\u0087ã\u0082£ã\u0083¬ã\u0082¤ç§\u0092æ\u0095°")]
		private float delaySec;

		[SerializeField]
		[Tooltip("å\u008f\u008eæ\u009d\u009fã\u0081\u008cå§\u008bã\u0081¾ã\u0081£ã\u0081¦ã\u0081\u008bã\u0082\u0089æ\u009c\u0080å\u0088\u009dã\u0081«å\u008f\u008eæ\u009d\u009fã\u0081\u008cé\u0081\u0085ã\u0081\u008fã\u0081ªã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®å\u008d\u008aå¾\u0084")]
		private float firstSlowRadius;

		[SerializeField]
		[Tooltip("å\u008f\u008eæ\u009d\u009fã\u0081\u008cå§\u008bã\u0081¾ã\u0081£ã\u0081¦ã\u0081\u008bã\u0082\u0089æ\u009c\u0080å\u0088\u009dã\u0081«å\u008f\u008eæ\u009d\u009fã\u0081\u008cé\u0081\u0085ã\u0081\u008fã\u0081ªã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®ç§\u0092æ\u0095°")]
		private float firstSlowSec;

		[SerializeField]
		[Tooltip("å\u008f\u008eæ\u009d\u009fã\u0081\u008cå§\u008bã\u0081¾ã\u0081£ã\u0081¦ã\u0081\u008bã\u0082\u0089æ\u009c\u0080å\u0088\u009dã\u0081«å\u008f\u008eæ\u009d\u009fã\u0081\u008cé\u0081\u0085ã\u0081\u008fã\u0081ªã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8ä¿\u0082æ\u0095°ï¼\u0088æ\u009c\u0080å¤§HPã\u0081®%ã\u0082\u0092å°\u0091æ\u0095°ã\u0081§æ\u008c\u0087å®\u009aï¼\u0089")]
		private float firstSlowDamageRatio;

		[SerializeField]
		[Tooltip("å\u008f\u008eæ\u009d\u009fã\u0081\u008cå§\u008bã\u0081¾ã\u0081£ã\u0081¦ã\u0081\u008bã\u0082\u0089æ\u009c\u0080å\u0088\u009dã\u0081«å\u008f\u008eæ\u009d\u009fã\u0081\u008cé\u0081\u0085ã\u0081\u008fã\u0081ªã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8é\u0096\u0093é\u009a\u0094ï¼\u0088ç§\u0092ï¼\u0089")]
		private float firstSlowDamageIntervalSec;

		[SerializeField]
		[Tooltip("2å\u009b\u009eç\u009b®ã\u0081«å\u008f\u008eæ\u009d\u009fã\u0081\u008cé\u0081\u0085ã\u0081\u008fã\u0081ªã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®å\u008d\u008aå¾\u0084")]
		private float secondSlowRadius;

		[SerializeField]
		[Tooltip("1å\u009b\u009eç\u009b®ã\u0081®å\u008f\u008eæ\u009d\u009fã\u0081\u008cé\u0081\u0085ã\u0081\u008fã\u0081ªã\u0081£ã\u0081¦ã\u0081\u008bã\u0082\u00892å\u009b\u009eç\u009b®ã\u0081«å\u008f\u008eæ\u009d\u009fã\u0081\u008cé\u0081\u0085ã\u0081\u008fã\u0081ªã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®ç§\u0092æ\u0095°")]
		private float secondSlowSec;

		[SerializeField]
		[Tooltip("1å\u009b\u009eç\u009b®ã\u0081®å\u008f\u008eæ\u009d\u009fã\u0081\u008cé\u0081\u0085ã\u0081\u008fã\u0081ªã\u0081£ã\u0081¦ã\u0081\u008bã\u0082\u00892å\u009b\u009eç\u009b®ã\u0081«å\u008f\u008eæ\u009d\u009fã\u0081\u008cé\u0081\u0085ã\u0081\u008fã\u0081ªã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8ä¿\u0082æ\u0095°ï¼\u0088æ\u009c\u0080å¤§HPã\u0081®%ã\u0082\u0092å°\u0091æ\u0095°ã\u0081§æ\u008c\u0087å®\u009aï¼\u0089")]
		private float secondSlowDamageRatio;

		[SerializeField]
		[Tooltip("1å\u009b\u009eç\u009b®ã\u0081®å\u008f\u008eæ\u009d\u009fã\u0081\u008cé\u0081\u0085ã\u0081\u008fã\u0081ªã\u0081£ã\u0081¦ã\u0081\u008bã\u0082\u00892å\u009b\u009eç\u009b®ã\u0081«å\u008f\u008eæ\u009d\u009fã\u0081\u008cé\u0081\u0085ã\u0081\u008fã\u0081ªã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8é\u0096\u0093é\u009a\u0094ï¼\u0088ç§\u0092ï¼\u0089")]
		private float secondSlowDamageIntervalSec;

		[SerializeField]
		[Tooltip("2å\u009b\u009eç\u009b®ã\u0081®å\u008f\u008eæ\u009d\u009fã\u0081\u008cé\u0081\u0085ã\u0081\u008fã\u0081ªã\u0081£ã\u0081¦ã\u0081\u008bã\u0082\u0089ä\u00b8­å¿\u0083ã\u0081«å\u008f\u008eæ\u009d\u009fã\u0081\u0099ã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®ç§\u0092æ\u0095°")]
		private float convergeSecAfterSecondSlow;

		[SerializeField]
		[Tooltip("2å\u009b\u009eç\u009b®ã\u0081®å\u008f\u008eæ\u009d\u009fã\u0081\u008cé\u0081\u0085ã\u0081\u008fã\u0081ªã\u0081£ã\u0081¦ã\u0081\u008bã\u0082\u0089ä\u00b8­å¿\u0083ã\u0081«å\u008f\u008eæ\u009d\u009fã\u0081\u0099ã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8ä¿\u0082æ\u0095°ï¼\u0088æ\u009c\u0080å¤§HPã\u0081®%ã\u0082\u0092å°\u0091æ\u0095°ã\u0081§æ\u008c\u0087å®\u009aï¼\u0089")]
		private float lastDamageRatio;

		[SerializeField]
		[Tooltip("2å\u009b\u009eç\u009b®ã\u0081®å\u008f\u008eæ\u009d\u009fã\u0081\u008cé\u0081\u0085ã\u0081\u008fã\u0081ªã\u0081£ã\u0081¦ã\u0081\u008bã\u0082\u0089ä\u00b8­å¿\u0083ã\u0081«å\u008f\u008eæ\u009d\u009fã\u0081\u0099ã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8é\u0096\u0093é\u009a\u0094ï¼\u0088ç§\u0092ï¼\u0089")]
		private float lastDamageIntervalSec;

		private HashSet<CharacterBase> contactCharas;

		private float damageTimer;

		private bool isBeforeStart;

		private float elapsedSec;

		private static readonly string pulseEffectLabel;

		private EffectObject pulseEffectObj;

		private static readonly float pulseEffectScale;

		private bool announced;

		private static readonly float pulseRadiusNotifyEventIntervalTime;

		private float pulseRadiusNotifyEventSendDelayTime;

		public Vector3 areaCirclePos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float areaCircleRadNow
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

		public HashSet<CharacterBase> ContactCharas => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void RegisterPoint(BRPulsePoint point)
		{
		}

		private void SetBrAreaData(bool hasAppeared)
		{
		}

		private void SetPulseEffectData(bool hasAppeared)
		{
		}

		public bool IsInside(Vector3 pos, float margin = 0f)
		{
			return default(bool);
		}

		public void ClearEffect()
		{
		}

		public void SendPulseRadius()
		{
		}
	}
}
