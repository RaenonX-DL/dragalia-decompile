using UnityEngine;

namespace Gluon
{
	public class FortCropViewController : MonoBehaviour
	{
		[SerializeField]
		private GameObject cropRoot;

		[SerializeField]
		private bool isSwitchDisp;

		[SerializeField]
		[Header("è¡\u00a8ç¤ºå\u0088\u0087æ\u009b¿ã\u0081«ã\u0082\u0088ã\u0082\u008bå\u00a0\u00b4å\u0090\u0088ã\u0081\u00afä»¥ä\u00b8\u008bã\u0082\u0092ä½¿ã\u0081\u0086ã\u0080\u0082")]
		private GameObject cropDispOn;

		[SerializeField]
		private GameObject cropDispOff;

		private Renderer[] _renderers;

		private FortSortingOrderSetter[] _sortingOrderSetters;

		public Renderer[] renderers => null;

		public FortSortingOrderSetter[] sortingOrderSetters => null;

		public void Disp(bool value)
		{
		}

		public void SetCropDispActive(bool value)
		{
		}
	}
}
