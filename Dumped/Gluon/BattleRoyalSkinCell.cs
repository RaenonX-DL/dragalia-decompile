using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class BattleRoyalSkinCell : MonoBehaviour
	{
		[SerializeField]
		[Header("Content")]
		public GameObject selectedMark;

		public RawImage icon;

		private Action<int> onDecided;

		public int skinId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Setup(int skinId, Action<int> onDecided)
		{
		}

		public void SetSelectedState(bool v)
		{
		}

		public void OnPressed()
		{
		}
	}
}
