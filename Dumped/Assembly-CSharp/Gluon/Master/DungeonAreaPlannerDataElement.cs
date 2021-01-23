/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class DungeonAreaPlannerDataElement : IMasterElement
	{
		// Fields
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
		private CameraType _CameraType;
		[SerializeField]
		private BossCamera _BossCameraType;
		[SerializeField]
		private string _BossBlurEffect;
		[SerializeField]
		private int _BossCameraEnemy0Param;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy0Position;
		[SerializeField]
		private string _BossCameraEnemy0ShadowAttachnode;
		[SerializeField]
		private float _BossCameraEnemy0ShadowScale;
		[SerializeField]
		private int _BossCameraEnemy1Param;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy1Position;
		[SerializeField]
		private string _BossCameraEnemy1ShadowAttachnode;
		[SerializeField]
		private float _BossCameraEnemy1ShadowScale;
		[SerializeField]
		private int _BossCameraEnemy2Param;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy2Position;
		[SerializeField]
		private string _BossCameraEnemy2ShadowAttachnode;
		[SerializeField]
		private float _BossCameraEnemy2ShadowScale;
		[SerializeField]
		private int _BossCameraEnemy3Param;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy3Position;
		[SerializeField]
		private string _BossCameraEnemy3ShadowAttachnode;
		[SerializeField]
		private float _BossCameraEnemy3ShadowScale;
		[SerializeField]
		private int _BossCameraEnemy4Param;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy4Position;
		[SerializeField]
		private string _BossCameraEnemy4ShadowAttachnode;
		[SerializeField]
		private float _BossCameraEnemy4ShadowScale;
		[SerializeField]
		private int _BossCameraEnemy5Param;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy5Position;
		[SerializeField]
		private string _BossCameraEnemy5ShadowAttachnode;
		[SerializeField]
		private float _BossCameraEnemy5ShadowScale;
		[SerializeField]
		private int _BossCameraEnemy6Param;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy6Position;
		[SerializeField]
		private string _BossCameraEnemy6ShadowAttachnode;
		[SerializeField]
		private float _BossCameraEnemy6ShadowScale;
		[SerializeField]
		private int _BossCameraEnemy7Param;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy7Position;
		[SerializeField]
		private string _BossCameraEnemy7ShadowAttachnode;
		[SerializeField]
		private float _BossCameraEnemy7ShadowScale;
		[SerializeField]
		private int _BossCameraEnemy8Param;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy8Position;
		[SerializeField]
		private string _BossCameraEnemy8ShadowAttachnode;
		[SerializeField]
		private float _BossCameraEnemy8ShadowScale;
		[SerializeField]
		private int _BossCameraEnemy9Param;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy9Position;
		[SerializeField]
		private string _BossCameraEnemy9ShadowAttachnode;
		[SerializeField]
		private float _BossCameraEnemy9ShadowScale;
		[SerializeField]
		private int _BossCameraEnemy0ParamHard;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy0PositionHard;
		[SerializeField]
		private int _BossCameraEnemy0ParamVeryhard;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy0PositionVeryhard;
		[SerializeField]
		private int _BossCameraEnemy0ParamExtreme;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy0PositionExtreme;
		[SerializeField]
		private int _BossCameraEnemy0ParamHell;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy0PositionHell;
		[SerializeField]
		private int _BossCameraEnemy0Param6;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy0Position6;
		[SerializeField]
		private int _BossCameraEnemy0Param7;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy0Position7;
		[SerializeField]
		private int _BossCameraEnemy0Param8;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy0Position8;
		[SerializeField]
		private int _BossCameraEnemy0Param9;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy0Position9;
		[SerializeField]
		private int _BossCameraEnemy0Param10;
		[SerializeField]
		private BossCameraPos _BossCameraEnemy0Position10;
		[SerializeField]
		private string _StartSystemMessage;
		[SerializeField]
		private float _BossScale;
		[SerializeField]
		private string _InGameCameraPrefab;
		[SerializeField]
		private string _InGameImgFxPrefabPrefab;
	
		// Properties
		public int Id { get; }
		public string Area { get; }
		public string Bgm { get; }
		public int DisableDragonBgm { get; }
		public int EnableAutoPlay { get; }
		public int MarkerBaseColorR { get; }
		public int MarkerBaseColorG { get; }
		public int MarkerBaseColorB { get; }
		public int MarkerBaseColorA { get; }
		public int MarkerFrameColorR { get; }
		public int MarkerFrameColorG { get; }
		public int MarkerFrameColorB { get; }
		public int MarkerFrameColorA { get; }
		public int MarkerChargeColorR { get; }
		public int MarkerChargeColorG { get; }
		public int MarkerChargeColorB { get; }
		public int MarkerChargeColorA { get; }
		public int MarkerBlinkColorR { get; }
		public int MarkerBlinkColorG { get; }
		public int MarkerBlinkColorB { get; }
		public int MarkerBlinkColorA { get; }
		public int UninvincibleMarkerBaseColorR { get; }
		public int UninvincibleMarkerBaseColorG { get; }
		public int UninvincibleMarkerBaseColorB { get; }
		public int UninvincibleMarkerBaseColorA { get; }
		public int UninvincibleMarkerFrameColorR { get; }
		public int UninvincibleMarkerFrameColorG { get; }
		public int UninvincibleMarkerFrameColorB { get; }
		public int UninvincibleMarkerFrameColorA { get; }
		public int UninvincibleMarkerChargeColorR { get; }
		public int UninvincibleMarkerChargeColorG { get; }
		public int UninvincibleMarkerChargeColorB { get; }
		public int UninvincibleMarkerChargeColorA { get; }
		public int UninvincibleMarkerBlinkColorR { get; }
		public int UninvincibleMarkerBlinkColorG { get; }
		public int UninvincibleMarkerBlinkColorB { get; }
		public int UninvincibleMarkerBlinkColorA { get; }
		public CameraType CameraType { get; }
		public BossCamera BossCameraType { get; }
		public string BossBlurEffect { get; }
		public int BossCameraEnemy0Param { get; }
		public BossCameraPos BossCameraEnemy0Position { get; }
		public string BossCameraEnemy0ShadowAttachnode { get; }
		public float BossCameraEnemy0ShadowScale { get; }
		public int BossCameraEnemy1Param { get; }
		public BossCameraPos BossCameraEnemy1Position { get; }
		public string BossCameraEnemy1ShadowAttachnode { get; }
		public float BossCameraEnemy1ShadowScale { get; }
		public int BossCameraEnemy2Param { get; }
		public BossCameraPos BossCameraEnemy2Position { get; }
		public string BossCameraEnemy2ShadowAttachnode { get; }
		public float BossCameraEnemy2ShadowScale { get; }
		public int BossCameraEnemy3Param { get; }
		public BossCameraPos BossCameraEnemy3Position { get; }
		public string BossCameraEnemy3ShadowAttachnode { get; }
		public float BossCameraEnemy3ShadowScale { get; }
		public int BossCameraEnemy4Param { get; }
		public BossCameraPos BossCameraEnemy4Position { get; }
		public string BossCameraEnemy4ShadowAttachnode { get; }
		public float BossCameraEnemy4ShadowScale { get; }
		public int BossCameraEnemy5Param { get; }
		public BossCameraPos BossCameraEnemy5Position { get; }
		public string BossCameraEnemy5ShadowAttachnode { get; }
		public float BossCameraEnemy5ShadowScale { get; }
		public int BossCameraEnemy6Param { get; }
		public BossCameraPos BossCameraEnemy6Position { get; }
		public string BossCameraEnemy6ShadowAttachnode { get; }
		public float BossCameraEnemy6ShadowScale { get; }
		public int BossCameraEnemy7Param { get; }
		public BossCameraPos BossCameraEnemy7Position { get; }
		public string BossCameraEnemy7ShadowAttachnode { get; }
		public float BossCameraEnemy7ShadowScale { get; }
		public int BossCameraEnemy8Param { get; }
		public BossCameraPos BossCameraEnemy8Position { get; }
		public string BossCameraEnemy8ShadowAttachnode { get; }
		public float BossCameraEnemy8ShadowScale { get; }
		public int BossCameraEnemy9Param { get; }
		public BossCameraPos BossCameraEnemy9Position { get; }
		public string BossCameraEnemy9ShadowAttachnode { get; }
		public float BossCameraEnemy9ShadowScale { get; }
		public int BossCameraEnemy0ParamHard { get; }
		public BossCameraPos BossCameraEnemy0PositionHard { get; }
		public int BossCameraEnemy0ParamVeryhard { get; }
		public BossCameraPos BossCameraEnemy0PositionVeryhard { get; }
		public int BossCameraEnemy0ParamExtreme { get; }
		public BossCameraPos BossCameraEnemy0PositionExtreme { get; }
		public int BossCameraEnemy0ParamHell { get; }
		public BossCameraPos BossCameraEnemy0PositionHell { get; }
		public int BossCameraEnemy0Param6 { get; }
		public BossCameraPos BossCameraEnemy0Position6 { get; }
		public int BossCameraEnemy0Param7 { get; }
		public BossCameraPos BossCameraEnemy0Position7 { get; }
		public int BossCameraEnemy0Param8 { get; }
		public BossCameraPos BossCameraEnemy0Position8 { get; }
		public int BossCameraEnemy0Param9 { get; }
		public BossCameraPos BossCameraEnemy0Position9 { get; }
		public int BossCameraEnemy0Param10 { get; }
		public BossCameraPos BossCameraEnemy0Position10 { get; }
		public string StartSystemMessage { get; }
		public float BossScale { get; }
		public string InGameCameraPrefab { get; }
		public string InGameImgFxPrefabPrefab { get; }
	
		// Constructors
		public DungeonAreaPlannerDataElement();
	}
}
