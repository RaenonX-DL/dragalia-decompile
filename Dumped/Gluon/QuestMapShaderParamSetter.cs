using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestMapShaderParamSetter : MonoBehaviour
	{
		[SerializeField]
		private string targetShaderName;

		[SerializeField]
		private CanvasGroup alphaReferenceCanvasGroup;

		private Image mapImage;

		private Material mapMaterial;

		private bool isAlreadyTriedCreateMaterial;

		public void Reset()
		{
		}

		public void ReflectShaderParam()
		{
		}

		private void Update()
		{
		}

		private void CreateMapMaterial()
		{
		}
	}
}
