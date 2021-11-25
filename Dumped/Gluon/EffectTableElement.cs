using System;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class EffectTableElement
	{
		[SerializeField]
		private string fileName;

		[SerializeField]
		private string groupName;

		[SerializeField]
		private int poolCount;

		public string FileName => null;

		public string GroupName => null;

		public int PoolCount => default(int);

		public EffectTableElement(string fileName, string groupName, int poolCount)
		{
		}
	}
}
