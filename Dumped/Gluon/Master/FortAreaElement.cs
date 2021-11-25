using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class FortAreaElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _FortPrefabName;

		[SerializeField]
		private int _FieldId;

		[SerializeField]
		private int _Unlock;

		[SerializeField]
		private string _Objs1;

		[SerializeField]
		private string _Objs2;

		[SerializeField]
		private string _Objs3;

		public int Id => default(int);

		public string FortPrefabName => null;

		public int FieldId => default(int);

		public int Unlock => default(int);

		public string Objs1 => null;

		public string Objs2 => null;

		public string Objs3 => null;
	}
}
