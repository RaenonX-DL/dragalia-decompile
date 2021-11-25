using UnityEngine;

namespace Gluon
{
	public class MyPageObjectsSettings : MonoBehaviour
	{
		public enum AmbientColorIndex
		{
			Noon,
			Evening,
			Night,
			WinterNoon,
			WinterNight,
			Max
		}

		public Vector2 characterImageOffset;

		public float slowRotateStart0;

		public float slowRotateStart1;

		public float slowRotateStart2;

		public float slowRotateStart3;

		public float slowRotateStart4;

		public float slowRotateRate0;

		public float slowRotateRate1;

		public float slowRotateRate2;

		public float slowRotateRate3;

		public float slowRotateRate4;

		public float fadeTime;

		public Vector3 moveCameraPosition;

		public Vector3 moveCameraRotation;

		public float moveCameraFOV;

		public float moveNear;

		public float moveFar;

		public Vector3 godRayPosition;

		public Vector3 godRayRotation;

		public Vector3 godRayScale;

		public Color godRayColor;

		public float godRayColorPower1;

		public float godRayColorPower2;

		public float godRayColorPower3;

		public float godRayColorPower4;

		public Vector2 windmillIrisSize;

		public Vector3 buildingIrisOffset;

		public Vector2 buildingIrisSize;

		public Vector3 effectBirdPosition;

		public Vector3 effectBirdRotation;

		public Vector3 effectBirdDirection;

		public float effectBirdSpeed;

		public Vector2 effectBirdIrisSize;

		public Vector3 moveBgPosition_Fort_Lv1_Noon;

		public Vector3 moveBgRotation_Fort_Lv1_Noon;

		public Vector3 bg01SkyPosition_Fort_Lv1_Noon;

		public float bg01SkyScale_Fort_Lv1_Noon;

		public Vector3 bg02Cloud_Fort_Lv1_Noon;

		public float bg02CloudScale_Fort_Lv1_Noon;

		public Vector3 bg03Bg_Fort_Lv1_Noon;

		public float bg03BgScale_Fort_Lv1_Noon;

		public Vector3 bg04Bg_Fort_Lv1_Noon;

		public float bg04BgScale_Fort_Lv1_Noon;

		public Vector3 moveBgPosition_Fort_Lv1_Evening;

		public Vector3 moveBgRotation_Fort_Lv1_Evening;

		public Vector3 bg01SkyPosition_Fort_Lv1_Evening;

		public float bg01SkyScale_Fort_Lv1_Evening;

		public Vector3 bg02Cloud_Fort_Lv1_Evening;

		public float bg02CloudScale_Fort_Lv1_Evening;

		public Vector3 bg03Bg_Fort_Lv1_Evening;

		public float bg03BgScale_Fort_Lv1_Evening;

		public Vector3 bg04Bg_Fort_Lv1_Evening;

		public float bg04BgScale_Fort_Lv1_Evening;

		public Vector3 moveBgPosition_Fort_Lv1_Night;

		public Vector3 moveBgRotation_Fort_Lv1_Night;

		public Vector3 bg01SkyPosition_Fort_Lv1_Night;

		public float bg01SkyScale_Fort_Lv1_Night;

		public Vector3 bg02Cloud_Fort_Lv1_Night;

		public float bg02CloudScale_Fort_Lv1_Night;

		public Vector3 bg03Bg_Fort_Lv1_Night;

		public float bg03BgScale_Fort_Lv1_Night;

		public Vector3 bg04Bg_Fort_Lv1_Night;

		public float bg04BgScale_Fort_Lv1_Night;

		public Vector3 moveBgPosition_Fort_Lv2_Noon;

		public Vector3 moveBgRotation_Fort_Lv2_Noon;

		public Vector3 bg01SkyPosition_Fort_Lv2_Noon;

		public float bg01SkyScale_Fort_Lv2_Noon;

		public Vector3 bg02Cloud_Fort_Lv2_Noon;

		public float bg02CloudScale_Fort_Lv2_Noon;

		public Vector3 bg03Bg_Fort_Lv2_Noon;

		public float bg03BgScale_Fort_Lv2_Noon;

		public Vector3 bg04Bg_Fort_Lv2_Noon;

		public float bg04BgScale_Fort_Lv2_Noon;

		public Vector3 moveBgPosition_Fort_Lv2_Evening;

		public Vector3 moveBgRotation_Fort_Lv2_Evening;

		public Vector3 bg01SkyPosition_Fort_Lv2_Evening;

		public float bg01SkyScale_Fort_Lv2_Evening;

		public Vector3 bg02Cloud_Fort_Lv2_Evening;

		public float bg02CloudScale_Fort_Lv2_Evening;

		public Vector3 bg03Bg_Fort_Lv2_Evening;

		public float bg03BgScale_Fort_Lv2_Evening;

		public Vector3 bg04Bg_Fort_Lv2_Evening;

		public float bg04BgScale_Fort_Lv2_Evening;

		public Vector3 moveBgPosition_Fort_Lv2_Night;

		public Vector3 moveBgRotation_Fort_Lv2_Night;

		public Vector3 bg01SkyPosition_Fort_Lv2_Night;

		public float bg01SkyScale_Fort_Lv2_Night;

		public Vector3 bg02Cloud_Fort_Lv2_Night;

		public float bg02CloudScale_Fort_Lv2_Night;

		public Vector3 bg03Bg_Fort_Lv2_Night;

		public float bg03BgScale_Fort_Lv2_Night;

		public Vector3 bg04Bg_Fort_Lv2_Night;

		public float bg04BgScale_Fort_Lv2_Night;

		public Vector3 moveBgPosition_Fort_Lv3_Noon;

		public Vector3 moveBgRotation_Fort_Lv3_Noon;

		public Vector3 bg01SkyPosition_Fort_Lv3_Noon;

		public float bg01SkyScale_Fort_Lv3_Noon;

		public Vector3 bg02Cloud_Fort_Lv3_Noon;

		public float bg02CloudScale_Fort_Lv3_Noon;

		public Vector3 bg03Bg_Fort_Lv3_Noon;

		public float bg03BgScale_Fort_Lv3_Noon;

		public Vector3 bg04Bg_Fort_Lv3_Noon;

		public float bg04BgScale_Fort_Lv3_Noon;

		public Vector3 moveBgPosition_Fort_Lv3_Evening;

		public Vector3 moveBgRotation_Fort_Lv3_Evening;

		public Vector3 bg01SkyPosition_Fort_Lv3_Evening;

		public float bg01SkyScale_Fort_Lv3_Evening;

		public Vector3 bg02Cloud_Fort_Lv3_Evening;

		public float bg02CloudScale_Fort_Lv3_Evening;

		public Vector3 bg03Bg_Fort_Lv3_Evening;

		public float bg03BgScale_Fort_Lv3_Evening;

		public Vector3 bg04Bg_Fort_Lv3_Evening;

		public float bg04BgScale_Fort_Lv3_Evening;

		public Vector3 moveBgPosition_Fort_Lv3_Night;

		public Vector3 moveBgRotation_Fort_Lv3_Night;

		public Vector3 bg01SkyPosition_Fort_Lv3_Night;

		public float bg01SkyScale_Fort_Lv3_Night;

		public Vector3 bg02Cloud_Fort_Lv3_Night;

		public float bg02CloudScale_Fort_Lv3_Night;

		public Vector3 bg03Bg_Fort_Lv3_Night;

		public float bg03BgScale_Fort_Lv3_Night;

		public Vector3 bg04Bg_Fort_Lv3_Night;

		public float bg04BgScale_Fort_Lv3_Night;

		public Vector3 moveBgPosition_Forest_Noon;

		public Vector3 moveBgRotation_Forest_Noon;

		public Vector3 bg01SkyPosition_Forest_Noon;

		public float bg01SkyScale_Forest_Noon;

		public Vector3 bg02Cloud_Forest_Noon;

		public float bg02CloudScale_Forest_Noon;

		public Vector3 bg03Bg_Forest_Noon;

		public float bg03BgScale_Forest_Noon;

		public Vector3 bg04Bg_Forest_Noon;

		public float bg04BgScale_Forest_Noon;

		public Vector3 moveBgPosition_Forest_Evening;

		public Vector3 moveBgRotation_Forest_Evening;

		public Vector3 bg01SkyPosition_Forest_Evening;

		public float bg01SkyScale_Forest_Evening;

		public Vector3 bg02Cloud_Forest_Evening;

		public float bg02CloudScale_Forest_Evening;

		public Vector3 bg03Bg_Forest_Evening;

		public float bg03BgScale_Forest_Evening;

		public Vector3 bg04Bg_Forest_Evening;

		public float bg04BgScale_Forest_Evening;

		public Vector3 moveBgPosition_Forest_Night;

		public Vector3 moveBgRotation_Forest_Night;

		public Vector3 bg01SkyPosition_Forest_Night;

		public float bg01SkyScale_Forest_Night;

		public Vector3 bg02Cloud_Forest_Night;

		public float bg02CloudScale_Forest_Night;

		public Vector3 bg03Bg_Forest_Night;

		public float bg03BgScale_Forest_Night;

		public Vector3 bg04Bg_Forest_Night;

		public float bg04BgScale_Forest_Night;

		public Vector3 bg01SkySpeed_Fort_Lv1_Noon;

		public Vector3 bg02CloudSpeed_Fort_Lv1_Noon;

		public Vector3 bg03BgSpeed_Fort_Lv1_Noon;

		public Vector3 bg04BgSpeed_Fort_Lv1_Noon;

		public Vector3 bg01SkySpeed_Fort_Lv1_Evening;

		public Vector3 bg02CloudSpeed_Fort_Lv1_Evening;

		public Vector3 bg03BgSpeed_Fort_Lv1_Evening;

		public Vector3 bg04BgSpeed_Fort_Lv1_Evening;

		public Vector3 bg01SkySpeed_Fort_Lv1_Night;

		public Vector3 bg02CloudSpeed_Fort_Lv1_Night;

		public Vector3 bg03BgSpeed_Fort_Lv1_Night;

		public Vector3 bg04BgSpeed_Fort_Lv1_Night;

		public Vector3 bg01SkySpeed_Fort_Lv2_Noon;

		public Vector3 bg02CloudSpeed_Fort_Lv2_Noon;

		public Vector3 bg03BgSpeed_Fort_Lv2_Noon;

		public Vector3 bg04BgSpeed_Fort_Lv2_Noon;

		public Vector3 bg01SkySpeed_Fort_Lv2_Evening;

		public Vector3 bg02CloudSpeed_Fort_Lv2_Evening;

		public Vector3 bg03BgSpeed_Fort_Lv2_Evening;

		public Vector3 bg04BgSpeed_Fort_Lv2_Evening;

		public Vector3 bg01SkySpeed_Fort_Lv2_Night;

		public Vector3 bg02CloudSpeed_Fort_Lv2_Night;

		public Vector3 bg03BgSpeed_Fort_Lv2_Night;

		public Vector3 bg04BgSpeed_Fort_Lv2_Night;

		public Vector3 bg01SkySpeed_Fort_Lv3_Noon;

		public Vector3 bg02CloudSpeed_Fort_Lv3_Noon;

		public Vector3 bg03BgSpeed_Fort_Lv3_Noon;

		public Vector3 bg04BgSpeed_Fort_Lv3_Noon;

		public Vector3 bg01SkySpeed_Fort_Lv3_Evening;

		public Vector3 bg02CloudSpeed_Fort_Lv3_Evening;

		public Vector3 bg03BgSpeed_Fort_Lv3_Evening;

		public Vector3 bg04BgSpeed_Fort_Lv3_Evening;

		public Vector3 bg01SkySpeed_Fort_Lv3_Night;

		public Vector3 bg02CloudSpeed_Fort_Lv3_Night;

		public Vector3 bg03BgSpeed_Fort_Lv3_Night;

		public Vector3 bg04BgSpeed_Fort_Lv3_Night;

		public Vector3 bg01SkySpeed_Forest_Noon;

		public Vector3 bg02CloudSpeed_Forest_Noon;

		public Vector3 bg03BgSpeed_Forest_Noon;

		public Vector3 bg04BgSpeed_Forest_Noon;

		public Vector3 bg01SkySpeed_Forest_Evening;

		public Vector3 bg02CloudSpeed_Forest_Evening;

		public Vector3 bg03BgSpeed_Forest_Evening;

		public Vector3 bg04BgSpeed_Forest_Evening;

		public Vector3 bg01SkySpeed_Forest_Night;

		public Vector3 bg02CloudSpeed_Forest_Night;

		public Vector3 bg03BgSpeed_Forest_Night;

		public Vector3 bg04BgSpeed_Forest_Night;

		public Vector3 bg01SkySpeed_Fort_Lv1_Running;

		public Vector3 bg02CloudSpeed_Fort_Lv1_Running;

		public Vector3 bg03BgSpeed_Fort_Lv1_Running;

		public Vector3 bg04BgSpeed_Fort_Lv1_Running;

		public Vector3 bg01SkySpeed_Fort_Lv2_Running;

		public Vector3 bg02CloudSpeed_Fort_Lv2_Running;

		public Vector3 bg03BgSpeed_Fort_Lv2_Running;

		public Vector3 bg04BgSpeed_Fort_Lv2_Running;

		public Vector3 bg01SkySpeed_Fort_Lv3_Running;

		public Vector3 bg02CloudSpeed_Fort_Lv3_Running;

		public Vector3 bg03BgSpeed_Fort_Lv3_Running;

		public Vector3 bg04BgSpeed_Fort_Lv3_Running;

		public Vector3 bg01SkySpeed_Forest_Running;

		public Vector3 bg02CloudSpeed_Forest_Running;

		public Vector3 bg03BgSpeed_Forest_Running;

		public Vector3 bg04BgSpeed_Forest_Running;

		public Vector3 playerPosition;

		public Vector3 playerRotation;

		public float playerShadowRotation;

		public float playerShadowStartAspect;

		public float playerShadowEndAspect;

		public float playerShadowAnimationOffset;

		public Vector3 nhaamPosition;

		public Vector3 nhaamRotation;

		public Vector3 nhaamScale;

		public Vector3 playerPositionEx;

		public Vector3 playerRotationEx;

		public Vector3 nhaamPositionEx;

		public Vector3 nhaamRotationEx;

		public Vector3 nhaamScaleEx;

		public Vector3 extraCharaPosition;

		public Vector3 extraCharaRotation;

		public Vector3 extraCharaScale;

		public float shadowCastMargin;

		public float shadowScale;

		public Vector3 earthPosition;

		public Vector3 earthRotation;

		public Vector3 buildingTavernPosition;

		public Vector3 buildingTavernRotation;

		public float buildingTavernSlowRotateRate;

		public float buildingTavernSlowRotateStartAngleX;

		public float buildingTavernYRotation;

		public Vector3 buildingInnPosition;

		public Vector3 buildingInnRotation;

		public float buildingInnSlowRotateRate;

		public float buildingInnSlowRotateStartAngleX;

		public float buildingInnYRotation;

		public Vector3 buildingShopPosition;

		public Vector3 buildingShopRotation;

		public float buildingShopSlowRotateRate;

		public float buildingShopSlowRotateStartAngleX;

		public float buildingShopYRotation;

		public Vector3 runningBuildingPosition1;

		public Vector3 runningBuildingRotation1;

		public float runningBuildingSlowRotateRate1;

		public float runningBuildingSlowRotateStartAngleX1;

		public float runningBuildingYRotation1;

		public Vector3 runningBuildingPosition2;

		public Vector3 runningBuildingRotation2;

		public float runningBuildingSlowRotateRate2;

		public float runningBuildingSlowRotateStartAngleX2;

		public float runningBuildingYRotation2;

		public Vector3 runningBuildingPosition3;

		public Vector3 runningBuildingRotation3;

		public float runningBuildingSlowRotateRate3;

		public float runningBuildingSlowRotateStartAngleX3;

		public float runningBuildingYRotation3;

		public Color noonColor;

		public Color eveningColor;

		public Color nightColor;

		public Color winterNoonColor;

		public Color winterNightColor;

		private MyPageScene scene;

		private Camera mainCamera;

		private GameObject player;

		private GameObject groundBase;

		private GameObject buildingTavernNode;

		private GameObject buildingInnNode;

		private GameObject buildingShopNode;

		private GameObject runningBuildingNode1;

		private GameObject runningBuildingNode2;

		private GameObject runningBuildingNode3;

		public void Reload()
		{
		}

		public void ResetSetting()
		{
		}
	}
}
