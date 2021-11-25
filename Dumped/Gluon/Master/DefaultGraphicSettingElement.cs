using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DefaultGraphicSettingElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _QualityType;

		[SerializeField]
		private string _Keyword0;

		[SerializeField]
		private string _Keyword1;

		[SerializeField]
		private string _Keyword2;

		public int Id => default(int);

		public string QualityType => null;

		public string Keyword0 => null;

		public string Keyword1 => null;

		public string Keyword2 => null;
	}
}
