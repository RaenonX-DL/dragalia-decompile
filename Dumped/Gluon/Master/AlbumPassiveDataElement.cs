using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class AlbumPassiveDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private AlbumPassiveType _AlbumPassiveType;

		[SerializeField]
		private int _AlbumPassiveValue;

		[SerializeField]
		private FortPlantEffect _EffectType;

		[SerializeField]
		private float _AlbumPassiveEffHp;

		[SerializeField]
		private float _AlbumPassiveEffAtk;

		public int Id => default(int);

		public AlbumPassiveType AlbumPassiveType => default(AlbumPassiveType);

		public int AlbumPassiveValue => default(int);

		public FortPlantEffect EffectType => default(FortPlantEffect);

		public float AlbumPassiveEffHp => default(float);

		public float AlbumPassiveEffAtk => default(float);
	}
}
