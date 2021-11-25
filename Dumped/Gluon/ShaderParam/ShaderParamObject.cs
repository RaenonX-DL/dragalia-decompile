using System;

namespace Gluon.ShaderParam
{
	[Serializable]
	public class ShaderParamObject
	{
		public virtual void Start()
		{
		}

		public virtual void Update()
		{
		}

		public static void StartArray(ShaderParamObject[] _shaderParams)
		{
		}

		public static void UpdateArray(ShaderParamObject[] _shaderParams)
		{
		}

		public static void AddToArray<T>(ref T[] arrayData, T addData)
		{
		}
	}
}
