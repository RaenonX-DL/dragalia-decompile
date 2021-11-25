using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CommonUnionIcon : MonoBehaviour
	{
		[SerializeField]
		private Graphic unionIcon;

		private void Awake()
		{
		}

		public void SetUnionByCrestId(int crestId, IconLoader.Size size = IconLoader.Size.S)
		{
		}

		public void SetUnionByUnionGroupId(int unionGroupId, IconLoader.Size size = IconLoader.Size.S)
		{
		}
	}
}
