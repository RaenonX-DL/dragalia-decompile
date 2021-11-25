using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class ShishimaiBoxUniqueCtrl : EnemyUniqueCtrl
	{
		private bool isValid;

		private List<EnemyCharacter> _boxes;

		private int _opendNum;

		private Vector3 BOX_CENTER;

		public int opendNum => default(int);

		public override void Initialize()
		{
		}

		private void LateUpdate()
		{
		}

		public void OpenBox()
		{
		}

		public void ReCloseBox(string motionState)
		{
		}
	}
}
