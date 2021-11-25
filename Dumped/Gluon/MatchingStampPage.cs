using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class MatchingStampPage : MonoBehaviour
	{
		public Image[] buttonImages;

		public GameObject[] buttonGOs;

		private List<int> stampIdList;

		public Action<int> onIconClicked;

		public void SetupByIndex(int startIndex, int endIndex, Action<int> onIconClicked)
		{
		}

		public void OnIconClick(int index)
		{
		}
	}
}
