using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestChapterIconPos : MonoBehaviour
	{
		[SerializeField]
		private Image _iconImage1;

		[SerializeField]
		private Image _iconImage2;

		private bool initFlag;

		[SerializeField]
		private Button _button;

		public Image iconImage1
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2 iconPos1
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Image iconImage2
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2 iconPos2
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Button button
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Initialize(int index, Action<int> action)
		{
		}
	}
}
