using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	[Serializable]
	internal class MultiplayConsumeItem
	{
		public Image[] bpBaseImages;

		public Image[] bpOnImages;

		public Image[] bpRedImages;

		public Image bpBaseBarImage;

		public GameObject questItemIconRoot;

		public Image questItemIconImage;

		public Text questItemNumText;
	}
}
