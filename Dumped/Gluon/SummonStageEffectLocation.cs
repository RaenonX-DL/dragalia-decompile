using UnityEngine;

namespace Gluon
{
	public class SummonStageEffectLocation : SingletonMonoBehaviour<SummonStageEffectLocation>
	{
		[SerializeField]
		[Header("Location")]
		public Transform[] locations;

		public Transform[] weapons;

		public Transform[] moons;

		public SummonStageShadowReceiver[] shadows;

		public TweenSequenceVisualizer pillarMovement;

		public Animator statueAnimator;

		[SerializeField]
		[Header("ModelParent")]
		public GameObject modelParent;

		public void ClearShadows()
		{
		}
	}
}
