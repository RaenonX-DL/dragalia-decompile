using System;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class ActionPartsListElement
	{
		[SerializeField]
		private string _group;

		[SerializeField]
		private string _resourcePath;

		public string group => null;

		public string resourcePath => null;

		public ActionPartsListElement(string group, string resourcePath)
		{
		}
	}
}
