using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class CharaFaceMouthElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _IntervalMin;

		[SerializeField]
		private int _IntervalMax;

		[SerializeField]
		private int _IntervalRatio;

		[SerializeField]
		private int _TextureIndex1;

		[SerializeField]
		private int _TextureIndex2;

		[SerializeField]
		private int _TextureIndex3;

		[SerializeField]
		private int _TextureIndex4;

		public int Id => default(int);

		public int IntervalMin => default(int);

		public int IntervalMax => default(int);

		public int IntervalRatio => default(int);

		public int TextureIndex1 => default(int);

		public int TextureIndex2 => default(int);

		public int TextureIndex3 => default(int);

		public int TextureIndex4 => default(int);
	}
}
