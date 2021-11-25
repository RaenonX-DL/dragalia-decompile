using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class PageScrollCell<T> : MonoBehaviour
	{
		[HideInInspector]
		public RectTransform rectTransform;

		public int dataIndex
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		public virtual void UpdateContent(T itemData)
		{
		}
	}
}
