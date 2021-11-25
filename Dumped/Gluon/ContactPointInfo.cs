using System;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class ContactPointInfo
	{
		[SerializeField]
		public string boneName;

		public float r;

		public Vector3 offset;

		public ContactPointInfo()
		{
		}

		public ContactPointInfo(string a_boneName, float a_r)
		{
		}
	}
}
