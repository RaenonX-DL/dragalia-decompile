using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SwitchingTextureData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private int _preTextureIdx;

		[SerializeField]
		[HideInInspector]
		private int _postTextureIdx;

		public int preTextureIdx => default(int);

		public int postTextureIdx => default(int);
	}
}
