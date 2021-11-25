using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class ContactGodRay : MonoBehaviour
	{
		[SerializeField]
		public MeshRenderer[] rayItems;

		private List<Material> matList;

		private void Awake()
		{
		}

		public Tweener Brighten(float duration)
		{
			return null;
		}

		public Tweener Dim(float duration)
		{
			return null;
		}

		public void SetColorPower(float value)
		{
		}
	}
}
