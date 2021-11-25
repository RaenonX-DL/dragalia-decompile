using System;
using UnityEngine;

namespace Gluon
{
	public class ApplyMaterialUI : MonoBehaviour
	{
		private SpriteRenderer image;

		private Action func;

		public void Initialize(Action func)
		{
		}

		public void OnLoaded(Material mtrl)
		{
		}
	}
}
