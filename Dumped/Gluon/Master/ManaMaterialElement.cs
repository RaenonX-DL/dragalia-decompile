using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class ManaMaterialElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _FireMaterialId;

		[SerializeField]
		private int _WaterMaterialId;

		[SerializeField]
		private int _WindMaterialId;

		[SerializeField]
		private int _LightMaterialId;

		[SerializeField]
		private int _DarkMaterialId;

		public int Id => default(int);

		public int FireMaterialId => default(int);

		public int WaterMaterialId => default(int);

		public int WindMaterialId => default(int);

		public int LightMaterialId => default(int);

		public int DarkMaterialId => default(int);
	}
}
