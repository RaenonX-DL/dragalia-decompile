using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class TextLabelElement : IMasterElement
	{
		[SerializeField]
		private string _Id;

		[SerializeField]
		private string _Text;

		public string Id => null;

		public string Text => null;
	}
}
