using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class QuestMainLocationElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _GroupId;

		[SerializeField]
		private int _RouteGroupNum;

		[SerializeField]
		private int _RouteIndex;

		[SerializeField]
		private int _ReleaseLocationId;

		[SerializeField]
		private string _LocationName;

		[SerializeField]
		private string _PointerImageName;

		[SerializeField]
		private int _MarkerSizeType;

		[SerializeField]
		private float _LocationPointerX;

		[SerializeField]
		private float _LocationPointerY;

		[SerializeField]
		private int _IsViewMaterialNormal;

		[SerializeField]
		private int _IsViewMaterialHard;

		[SerializeField]
		private int _IsViewMaterialVeryHard;

		[SerializeField]
		private string _QuestHeaderImage;

		[SerializeField]
		private int _QuestHeaderEnemy01;

		[SerializeField]
		private int _QuestHeaderMotion01;

		[SerializeField]
		private int _QuestHeaderEnemy02;

		[SerializeField]
		private int _QuestHeaderMotion02;

		[SerializeField]
		private int _QuestHeaderEnemy03;

		[SerializeField]
		private int _QuestHeaderMotion03;

		public int Id => default(int);

		public int GroupId => default(int);

		public int RouteGroupNum => default(int);

		public int RouteIndex => default(int);

		public int ReleaseLocationId => default(int);

		public string LocationName => null;

		public string PointerImageName => null;

		public int MarkerSizeType => default(int);

		public float LocationPointerX => default(float);

		public float LocationPointerY => default(float);

		public int IsViewMaterialNormal => default(int);

		public int IsViewMaterialHard => default(int);

		public int IsViewMaterialVeryHard => default(int);

		public string QuestHeaderImage => null;

		public int QuestHeaderEnemy01 => default(int);

		public int QuestHeaderMotion01 => default(int);

		public int QuestHeaderEnemy02 => default(int);

		public int QuestHeaderMotion02 => default(int);

		public int QuestHeaderEnemy03 => default(int);

		public int QuestHeaderMotion03 => default(int);
	}
}
