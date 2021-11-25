using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class FirstCharaSelectController : TableViewController<FirstCharaSelectData>
	{
		[SerializeField]
		private AnimationListOneCol listAnimation;

		public void LoadData(List<FirstCharaSelectData> data, Action<int> onClick)
		{
		}
	}
}
