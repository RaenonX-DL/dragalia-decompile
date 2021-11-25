using System;
using UnityEngine;

namespace Gluon.ShaderParam
{
	[Serializable]
	public class ShaderParamBase<T> : ShaderParamCommon<T>
	{
		public T Param;

		[HideInInspector]
		public int PropertyID;

		[HideInInspector]
		public T OldParam;

		public override void Start()
		{
		}

		public override void Update()
		{
		}
	}
}
