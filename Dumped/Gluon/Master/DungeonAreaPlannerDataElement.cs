using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class DungeonAreaPlannerDataElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private string _Area;

		[SerializeField]
		private string _Bgm;

		[SerializeField]
		private int _DisableDragonBgm;

		[SerializeField]
		private int _EnableAutoPlay;

		[SerializeField]
		private int _MarkerBaseColorR;

		[SerializeField]
		private int _MarkerBaseColorG;

		[SerializeField]
		private int _MarkerBaseColorB;

		[SerializeField]
		private int _MarkerBaseColorA;

		[SerializeField]
		private int _MarkerFrameColorR;

		[SerializeField]
		private int _MarkerFrameColorG;

		[SerializeField]
		private int _MarkerFrameColorB;

		[SerializeField]
		private int _MarkerFrameColorA;

		[SerializeField]
		private int _MarkerChargeColorR;

		[SerializeField]
		private int _MarkerChargeColorG;

		[SerializeField]
		private int _MarkerChargeColorB;

		[SerializeField]
		private int _MarkerChargeColorA;

		[SerializeField]
		private int _MarkerBlinkColorR;

		[SerializeField]
		private int _MarkerBlinkColorG;

		[SerializeField]
		private int _MarkerBlinkColorB;

		[SerializeField]
		private int _MarkerBlinkColorA;

		[SerializeField]
		private int _UninvincibleMarkerBaseColorR;

		[SerializeField]
		private int _UninvincibleMarkerBaseColorG;

		[SerializeField]
		private int _UninvincibleMarkerBaseColorB;

		[SerializeField]
		private int _UninvincibleMarkerBaseColorA;

		[SerializeField]
		private int _UninvincibleMarkerFrameColorR;

		[SerializeField]
		private int _UninvincibleMarkerFrameColorG;

		[SerializeField]
		private int _UninvincibleMarkerFrameColorB;

		[SerializeField]
		private int _UninvincibleMarkerFrameColorA;

		[SerializeField]
		private int _UninvincibleMarkerChargeColorR;

		[SerializeField]
		private int _UninvincibleMarkerChargeColorG;

		[SerializeField]
		private int _UninvincibleMarkerChargeColorB;

		[SerializeField]
		private int _UninvincibleMarkerChargeColorA;

		[SerializeField]
		private int _UninvincibleMarkerBlinkColorR;

		[SerializeField]
		private int _UninvincibleMarkerBlinkColorG;

		[SerializeField]
		private int _UninvincibleMarkerBlinkColorB;

		[SerializeField]
		private int _UninvincibleMarkerBlinkColorA;

		[SerializeField]
		private float _MinimapScale;

		[SerializeField]
		private int _MinimapCoordX;

		[SerializeField]
		private int _MinimapCoordY;

		[SerializeField]
		private CameraType _CameraType;

		[SerializeField]
		private Gluon.BossCamera _BossCameraType;

		[SerializeField]
		private string _BossBlurEffect;

		[SerializeField]
		private int _BossCameraEnemy0Param;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy0Position;

		[SerializeField]
		private string _BossCameraEnemy0ShadowAttachnode;

		[SerializeField]
		private float _BossCameraEnemy0ShadowScale;

		[SerializeField]
		private int _BossCameraEnemy1Param;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy1Position;

		[SerializeField]
		private string _BossCameraEnemy1ShadowAttachnode;

		[SerializeField]
		private float _BossCameraEnemy1ShadowScale;

		[SerializeField]
		private int _BossCameraEnemy2Param;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy2Position;

		[SerializeField]
		private string _BossCameraEnemy2ShadowAttachnode;

		[SerializeField]
		private float _BossCameraEnemy2ShadowScale;

		[SerializeField]
		private int _BossCameraEnemy3Param;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy3Position;

		[SerializeField]
		private string _BossCameraEnemy3ShadowAttachnode;

		[SerializeField]
		private float _BossCameraEnemy3ShadowScale;

		[SerializeField]
		private int _BossCameraEnemy4Param;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy4Position;

		[SerializeField]
		private string _BossCameraEnemy4ShadowAttachnode;

		[SerializeField]
		private float _BossCameraEnemy4ShadowScale;

		[SerializeField]
		private int _BossCameraEnemy5Param;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy5Position;

		[SerializeField]
		private string _BossCameraEnemy5ShadowAttachnode;

		[SerializeField]
		private float _BossCameraEnemy5ShadowScale;

		[SerializeField]
		private int _BossCameraEnemy6Param;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy6Position;

		[SerializeField]
		private string _BossCameraEnemy6ShadowAttachnode;

		[SerializeField]
		private float _BossCameraEnemy6ShadowScale;

		[SerializeField]
		private int _BossCameraEnemy7Param;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy7Position;

		[SerializeField]
		private string _BossCameraEnemy7ShadowAttachnode;

		[SerializeField]
		private float _BossCameraEnemy7ShadowScale;

		[SerializeField]
		private int _BossCameraEnemy8Param;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy8Position;

		[SerializeField]
		private string _BossCameraEnemy8ShadowAttachnode;

		[SerializeField]
		private float _BossCameraEnemy8ShadowScale;

		[SerializeField]
		private int _BossCameraEnemy9Param;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy9Position;

		[SerializeField]
		private string _BossCameraEnemy9ShadowAttachnode;

		[SerializeField]
		private float _BossCameraEnemy9ShadowScale;

		[SerializeField]
		private int _BossCameraEnemy0ParamHard;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy0PositionHard;

		[SerializeField]
		private int _BossCameraEnemy0ParamVeryhard;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy0PositionVeryhard;

		[SerializeField]
		private int _BossCameraEnemy0ParamExtreme;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy0PositionExtreme;

		[SerializeField]
		private int _BossCameraEnemy0ParamHell;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy0PositionHell;

		[SerializeField]
		private int _BossCameraEnemy0Param6;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy0Position6;

		[SerializeField]
		private int _BossCameraEnemy0Param7;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy0Position7;

		[SerializeField]
		private int _BossCameraEnemy0Param8;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy0Position8;

		[SerializeField]
		private int _BossCameraEnemy0Param9;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy0Position9;

		[SerializeField]
		private int _BossCameraEnemy0Param10;

		[SerializeField]
		private Gluon.BossCameraPos _BossCameraEnemy0Position10;

		[SerializeField]
		private string _StartSystemMessage;

		[SerializeField]
		private float _BossScale;

		[SerializeField]
		private string _InGameCameraPrefab;

		[SerializeField]
		private string _InGameImgFxPrefabPrefab;

		public int Id => default(int);

		public string Area => null;

		public string Bgm => null;

		public int DisableDragonBgm => default(int);

		public int EnableAutoPlay => default(int);

		public int MarkerBaseColorR => default(int);

		public int MarkerBaseColorG => default(int);

		public int MarkerBaseColorB => default(int);

		public int MarkerBaseColorA => default(int);

		public int MarkerFrameColorR => default(int);

		public int MarkerFrameColorG => default(int);

		public int MarkerFrameColorB => default(int);

		public int MarkerFrameColorA => default(int);

		public int MarkerChargeColorR => default(int);

		public int MarkerChargeColorG => default(int);

		public int MarkerChargeColorB => default(int);

		public int MarkerChargeColorA => default(int);

		public int MarkerBlinkColorR => default(int);

		public int MarkerBlinkColorG => default(int);

		public int MarkerBlinkColorB => default(int);

		public int MarkerBlinkColorA => default(int);

		public int UninvincibleMarkerBaseColorR => default(int);

		public int UninvincibleMarkerBaseColorG => default(int);

		public int UninvincibleMarkerBaseColorB => default(int);

		public int UninvincibleMarkerBaseColorA => default(int);

		public int UninvincibleMarkerFrameColorR => default(int);

		public int UninvincibleMarkerFrameColorG => default(int);

		public int UninvincibleMarkerFrameColorB => default(int);

		public int UninvincibleMarkerFrameColorA => default(int);

		public int UninvincibleMarkerChargeColorR => default(int);

		public int UninvincibleMarkerChargeColorG => default(int);

		public int UninvincibleMarkerChargeColorB => default(int);

		public int UninvincibleMarkerChargeColorA => default(int);

		public int UninvincibleMarkerBlinkColorR => default(int);

		public int UninvincibleMarkerBlinkColorG => default(int);

		public int UninvincibleMarkerBlinkColorB => default(int);

		public int UninvincibleMarkerBlinkColorA => default(int);

		public float MinimapScale => default(float);

		public int MinimapCoordX => default(int);

		public int MinimapCoordY => default(int);

		public CameraType CameraType => default(CameraType);

		public Gluon.BossCamera BossCameraType => default(Gluon.BossCamera);

		public string BossBlurEffect => null;

		public int BossCameraEnemy0Param => default(int);

		public Gluon.BossCameraPos BossCameraEnemy0Position => default(Gluon.BossCameraPos);

		public string BossCameraEnemy0ShadowAttachnode => null;

		public float BossCameraEnemy0ShadowScale => default(float);

		public int BossCameraEnemy1Param => default(int);

		public Gluon.BossCameraPos BossCameraEnemy1Position => default(Gluon.BossCameraPos);

		public string BossCameraEnemy1ShadowAttachnode => null;

		public float BossCameraEnemy1ShadowScale => default(float);

		public int BossCameraEnemy2Param => default(int);

		public Gluon.BossCameraPos BossCameraEnemy2Position => default(Gluon.BossCameraPos);

		public string BossCameraEnemy2ShadowAttachnode => null;

		public float BossCameraEnemy2ShadowScale => default(float);

		public int BossCameraEnemy3Param => default(int);

		public Gluon.BossCameraPos BossCameraEnemy3Position => default(Gluon.BossCameraPos);

		public string BossCameraEnemy3ShadowAttachnode => null;

		public float BossCameraEnemy3ShadowScale => default(float);

		public int BossCameraEnemy4Param => default(int);

		public Gluon.BossCameraPos BossCameraEnemy4Position => default(Gluon.BossCameraPos);

		public string BossCameraEnemy4ShadowAttachnode => null;

		public float BossCameraEnemy4ShadowScale => default(float);

		public int BossCameraEnemy5Param => default(int);

		public Gluon.BossCameraPos BossCameraEnemy5Position => default(Gluon.BossCameraPos);

		public string BossCameraEnemy5ShadowAttachnode => null;

		public float BossCameraEnemy5ShadowScale => default(float);

		public int BossCameraEnemy6Param => default(int);

		public Gluon.BossCameraPos BossCameraEnemy6Position => default(Gluon.BossCameraPos);

		public string BossCameraEnemy6ShadowAttachnode => null;

		public float BossCameraEnemy6ShadowScale => default(float);

		public int BossCameraEnemy7Param => default(int);

		public Gluon.BossCameraPos BossCameraEnemy7Position => default(Gluon.BossCameraPos);

		public string BossCameraEnemy7ShadowAttachnode => null;

		public float BossCameraEnemy7ShadowScale => default(float);

		public int BossCameraEnemy8Param => default(int);

		public Gluon.BossCameraPos BossCameraEnemy8Position => default(Gluon.BossCameraPos);

		public string BossCameraEnemy8ShadowAttachnode => null;

		public float BossCameraEnemy8ShadowScale => default(float);

		public int BossCameraEnemy9Param => default(int);

		public Gluon.BossCameraPos BossCameraEnemy9Position => default(Gluon.BossCameraPos);

		public string BossCameraEnemy9ShadowAttachnode => null;

		public float BossCameraEnemy9ShadowScale => default(float);

		public int BossCameraEnemy0ParamHard => default(int);

		public Gluon.BossCameraPos BossCameraEnemy0PositionHard => default(Gluon.BossCameraPos);

		public int BossCameraEnemy0ParamVeryhard => default(int);

		public Gluon.BossCameraPos BossCameraEnemy0PositionVeryhard => default(Gluon.BossCameraPos);

		public int BossCameraEnemy0ParamExtreme => default(int);

		public Gluon.BossCameraPos BossCameraEnemy0PositionExtreme => default(Gluon.BossCameraPos);

		public int BossCameraEnemy0ParamHell => default(int);

		public Gluon.BossCameraPos BossCameraEnemy0PositionHell => default(Gluon.BossCameraPos);

		public int BossCameraEnemy0Param6 => default(int);

		public Gluon.BossCameraPos BossCameraEnemy0Position6 => default(Gluon.BossCameraPos);

		public int BossCameraEnemy0Param7 => default(int);

		public Gluon.BossCameraPos BossCameraEnemy0Position7 => default(Gluon.BossCameraPos);

		public int BossCameraEnemy0Param8 => default(int);

		public Gluon.BossCameraPos BossCameraEnemy0Position8 => default(Gluon.BossCameraPos);

		public int BossCameraEnemy0Param9 => default(int);

		public Gluon.BossCameraPos BossCameraEnemy0Position9 => default(Gluon.BossCameraPos);

		public int BossCameraEnemy0Param10 => default(int);

		public Gluon.BossCameraPos BossCameraEnemy0Position10 => default(Gluon.BossCameraPos);

		public string StartSystemMessage => null;

		public float BossScale => default(float);

		public string InGameCameraPrefab => null;

		public string InGameImgFxPrefabPrefab => null;
	}
}
