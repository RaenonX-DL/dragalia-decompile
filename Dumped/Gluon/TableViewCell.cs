using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class TableViewCell<T> : MonoBehaviour
	{
		[HideInInspector]
		public RectTransform rectTransform;

		protected T itemData;

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

		public float height
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Vector2 top
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 bottom
		{
			get
			{
				return default(Vector2);
			}
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
