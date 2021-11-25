using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class TabContentBase : MonoBehaviour
	{
		[SerializeField]
		protected ScrollRect scrollRect;

		public string tabContentName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected void InitScrollPos()
		{
		}

		protected void OnDisable()
		{
		}

		private IEnumerator LoadTabScrollPos()
		{
			return null;
		}

		private void SaveTabScrollPos()
		{
		}
	}
}
