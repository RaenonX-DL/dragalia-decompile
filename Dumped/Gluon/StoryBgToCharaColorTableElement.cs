using System;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class StoryBgToCharaColorTableElement
	{
		[SerializeField]
		private string fileName;

		[SerializeField]
		private DifferenceImageController.MaterialParameter materialParameter;

		public string FileName => null;

		public DifferenceImageController.MaterialParameter MaterialParameter => null;

		public StoryBgToCharaColorTableElement(string fileName, DifferenceImageController.MaterialParameter materialParameter)
		{
		}
	}
}
