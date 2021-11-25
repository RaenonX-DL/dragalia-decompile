using UnityEngine;

namespace Gluon
{
	public class FacilityEffectSetter : MonoBehaviour
	{
		[SerializeField]
		[Header("ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088å\u0090\u008d")]
		private string effName;

		[SerializeField]
		private Color color;

		[SerializeField]
		private bool needApplyColor;

		[SerializeField]
		private int triggerId;

		private GameObject effectObj;

		private void Start()
		{
		}

		private string GetEffectPath(string fileName)
		{
			return null;
		}

		private void DummyForAvoidingWarning(string name, int triggerId, GameObject obj)
		{
		}
	}
}
