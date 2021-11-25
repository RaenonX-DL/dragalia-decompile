using System;
using UnityEngine;

namespace Gluon.ShaderParam
{
	[Serializable]
	public class ShaderParamArrayBase<T> : ShaderParamCommon<T>
	{
		public delegate void SetGlobalArrayParamFromID(int id, T[] param);

		public delegate void SetGlobalArrayParamFromName(string name, T[] param);

		public SetGlobalArrayParamFromID setGlobalArrayParamFromID;

		public SetGlobalArrayParamFromName setGlobalArrayParamFromName;

		public T[] Params;

		[HideInInspector]
		public int PropertyID;

		[HideInInspector]
		public T[] OldParams;

		public override void Start()
		{
		}

		public override void Update()
		{
		}
	}
}
