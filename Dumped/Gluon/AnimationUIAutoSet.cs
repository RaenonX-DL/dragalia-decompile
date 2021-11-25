using UnityEngine;

namespace Gluon
{
	public class AnimationUIAutoSet : MonoBehaviour
	{
		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡å\u0088\u009dæ\u009c\u009fæ\u008b¡å¤§ç\u008e\u0087Lerp")]
		public float enterScaleMin;

		public float enterScaleMax;

		public bool randomEnterScale;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡é\u0081\u0085å»¶ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0MinMax")]
		public int enterDelayMin;

		public int enterDelayMax;

		[SerializeField]
		[Header("ã\u0082·ã\u0083¼ã\u0083³çµ\u0082äº\u0086ã\u0082¢ã\u0083\u008bã\u0083¡é\u0081\u0085å»¶ã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0Lerp")]
		public int exitDelayMin;

		public int exitDelayMax;

		[SerializeField]
		[Header("Overrideã\u0081\u008bã\u0081©ã\u0081\u0086ã\u0081\u008b")]
		public bool overrideOriginal;

		public GameObject[] objectsInSet;

		private AnimationUIAutoPublisher publisher;

		public void Preheat(AnimationUIAutoPublisher publisher)
		{
		}

		public void Publish(AnimationUIAutoPublisher publisher)
		{
		}

		public void PlayEnterAnimation()
		{
		}

		public void PlayExitAnimation()
		{
		}

		public void ClearPlayedState(bool enterState = false, bool exitState = false)
		{
		}

		public void CompleteRunningAnimation()
		{
		}
	}
}
