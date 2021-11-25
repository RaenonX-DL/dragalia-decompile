using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class BRItemDirectionParam : MonoBehaviour
	{
		public static BRItemDirectionParam instance;

		public static readonly float popDelayMin;

		public static readonly float popDelayMax;

		[SerializeField]
		[Tooltip("ã\u0083\u009dã\u0083\u0083ã\u0083\u0097ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082\u00b8ã\u0083£ã\u0083³ã\u0083\u0097ã\u0081®ä\u00b8\u008aä\u00b8\u008bç§»å\u008b\u0095ã\u0080\u0081æ\u0099\u0082é\u0096\u0093ã\u0081®é\u0095·ã\u0081\u0095")]
		private AnimationCurve popJumpAnimCurve;

		[SerializeField]
		[Tooltip("ã\u0083\u009dã\u0083\u0083ã\u0083\u0097ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«å¤\u0089å\u008b\u0095")]
		private AnimationCurve popScaleAnimCurve;

		[SerializeField]
		[Tooltip("ã\u0083\u009dã\u0083\u0083ã\u0083\u0097ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®å\u009b\u009eè»¢ã\u0081®é\u0080\u009fã\u0081\u0095(1.0ã\u0081§1å\u0080\u008d)")]
		private AnimationCurve popRotScaleAnimCurve;

		[SerializeField]
		[Tooltip("ã\u0083\u009dã\u0083\u0083ã\u0083\u0097ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088")]
		private string popEffectLabel;

		[SerializeField]
		[Tooltip("ã\u0083\u009dã\u0083\u0083ã\u0083\u0097ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082µã\u0082¦ã\u0083³ã\u0083\u0089")]
		private string popSoundLabel;

		[SerializeField]
		[Tooltip("å¾\u0085æ©\u009fä\u00b8­ã\u0081®å\u009c°é\u009d¢ã\u0081\u008bã\u0082\u0089ã\u0081®ã\u0082ªã\u0083\u0095ã\u0082»ã\u0083\u0083ã\u0083\u0088")]
		public Vector3 idleOffset;

		[SerializeField]
		[Tooltip("å¾\u0085æ©\u009fä\u00b8­ã\u0081«å\u009b\u009eè»¢ã\u0081\u0099ã\u0082\u008bè§\u0092åº¦/æ\u00af\u008eç§\u0092")]
		public float idleAddRotY;

		[SerializeField]
		[Tooltip("å\u008f\u0096å¾\u0097ã\u0081§ã\u0081\u008dã\u0081ªã\u0081\u0084ã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082\u0086ã\u0082\u008c")]
		private AnimationCurve cantCatchShakeAnimCurve;

		[SerializeField]
		[Tooltip("å\u008f\u0096å¾\u0097ã\u0081§ã\u0081\u008dã\u0081ªã\u0081\u0084ã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088")]
		private string cantCatchEffectLabel;

		[SerializeField]
		[Tooltip("å\u008f\u0096å¾\u0097ã\u0081§ã\u0081\u008dã\u0081ªã\u0081\u0084ã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082µã\u0082¦ã\u0083³ã\u0083\u0089")]
		private string cantCatchSoundLabel;

		[SerializeField]
		[Tooltip("å\u008f\u0096å¾\u0097ã\u0081\u0095ã\u0082\u008cã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082\u00b8ã\u0083£ã\u0083³ã\u0083\u0097ã\u0081®ä\u00b8\u008aä\u00b8\u008bç§»å\u008b\u0095ã\u0080\u0081æ\u0099\u0082é\u0096\u0093ã\u0081®é\u0095·ã\u0081\u0095")]
		private AnimationCurve caughtJumpAnimCurve;

		[SerializeField]
		[Tooltip("å\u008f\u0096å¾\u0097ã\u0081\u0095ã\u0082\u008cã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«å¤\u0089å\u008b\u0095")]
		private AnimationCurve caughtScaleAnimCurve;

		[SerializeField]
		[Tooltip("å\u008f\u0096å¾\u0097ã\u0081\u0095ã\u0082\u008cã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082\u00b8ã\u0083£ã\u0083³ã\u0083\u0097ã\u0081®ã\u0082­ã\u0083£ã\u0083©ã\u0081\u00b8ã\u0081®æ\u008e¥è¿\u0091ã\u0080\u00810ï¼\u009dã\u0083\u009dã\u0083\u0083ã\u0083\u0097å\u009c°ç\u0082¹ã\u0080\u00801ï¼\u009dã\u0082­ã\u0083£ã\u0083©ä½\u008dç½®")]
		private AnimationCurve caughtStalkAnimCurve;

		[SerializeField]
		[Tooltip("ã\u0083\u009dã\u0083\u0083ã\u0083\u0097ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®å\u009b\u009eè»¢ã\u0081®é\u0080\u009fã\u0081\u0095(1.0ã\u0081§1å\u0080\u008d)")]
		private AnimationCurve caughtRotScaleAnimCurve;

		[SerializeField]
		[Tooltip("å\u008f\u0096å¾\u0097ã\u0081\u0095ã\u0082\u008cã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088")]
		private string caughtEffectLabel;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public float GetDirectionSecPop()
		{
			return default(float);
		}

		public void SetDirectionPop(Transform targetObj, Vector3 startPos, Vector3 endPos, bool ignoreSeFx)
		{
		}

		public IEnumerator CoDirectionPop(Transform targetObj, Vector3 startPos, Vector3 endPos, bool ignoreSeFx)
		{
			return null;
		}

		public void SetDirectionCantCatch(Transform targetObj)
		{
		}

		public IEnumerator CoDirectionCantCatch(Transform targetObj)
		{
			return null;
		}

		public void SetDirectionCaught(Transform targetObj, Transform stalkObj)
		{
		}

		public IEnumerator CoDirectionCaught(Transform targetObj, Transform stalkObj)
		{
			return null;
		}
	}
}
