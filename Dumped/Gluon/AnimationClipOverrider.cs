using UnityEngine;

namespace Gluon
{
	public class AnimationClipOverrider : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("ç½®ã\u0081\u008dæ\u008f\u009bã\u0081\u0088ã\u0082\u008bAnimationClipå\u0090\u008d")]
		private string[] clipNames;

		[SerializeField]
		[Tooltip("ç½®ã\u0081\u008dæ\u008f\u009bã\u0081\u0088ã\u0081\u009få¾\u008cã\u0081®AnimationClip")]
		private AnimationClip[] overrideClips;

		public void Override(Animator animator)
		{
		}
	}
}
