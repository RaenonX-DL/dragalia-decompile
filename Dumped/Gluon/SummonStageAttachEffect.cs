using UnityEngine;

namespace Gluon
{
	public class SummonStageAttachEffect : MonoBehaviour
	{
		[SerializeField]
		public string effectName;

		public int kickTrigger;

		private EffectObject eff;

		private void OnEnable()
		{
		}
	}
}
