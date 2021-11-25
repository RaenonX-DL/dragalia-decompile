using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class FortFieldElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _Floor01;

		[SerializeField]
		private int _Floor02;

		[SerializeField]
		private int _Floor03;

		[SerializeField]
		private int _Floor04;

		[SerializeField]
		private int _Floor05;

		[SerializeField]
		private int _Floor06;

		[SerializeField]
		private int _Floor07;

		[SerializeField]
		private int _Floor08;

		[SerializeField]
		private int _Floor09;

		[SerializeField]
		private int _IdxX;

		[SerializeField]
		private int _IdxY;

		[SerializeField]
		private float _CamLeft;

		[SerializeField]
		private float _CamRight;

		[SerializeField]
		private float _CamHeight;

		[SerializeField]
		private float _CamDistanceMin;

		[SerializeField]
		private float _CamDistanceMax;

		[SerializeField]
		private float _DistanceRate;

		[SerializeField]
		private float _PullRate;

		public int Id => default(int);

		public int Floor01 => default(int);

		public int Floor02 => default(int);

		public int Floor03 => default(int);

		public int Floor04 => default(int);

		public int Floor05 => default(int);

		public int Floor06 => default(int);

		public int Floor07 => default(int);

		public int Floor08 => default(int);

		public int Floor09 => default(int);

		public int IdxX => default(int);

		public int IdxY => default(int);

		public float CamLeft => default(float);

		public float CamRight => default(float);

		public float CamHeight => default(float);

		public float CamDistanceMin => default(float);

		public float CamDistanceMax => default(float);

		public float DistanceRate => default(float);

		public float PullRate => default(float);
	}
}
