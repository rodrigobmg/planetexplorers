using UnityEngine;
using System.Collections;
using System;
using uLink;

public class SyncAnimationState : uLink.MonoBehaviour
{
	public enum AniStates
	{
        Walk = 0,
        Run1,//1
        Run2,//1
        flashlightStand,
        flashlightTurn,

        IdleLeft,//2
        IdleRight,//3
		InjuredWalk,//3
        TurnBack,//4
        TurnLeft,//5
        TurnRight,//6
        Awalk,//7
        ATurnBack,//8
        ATurnLeft,//9
        ATurnRight,//10
        StartJump,//11
        Jump,//12
        Jumpend,//13
        Idle,//14
        Common1,
        Common2,//20
		ToxophilyFront,
		ToxophilyBack,
		DressStand,
		DressIdle1,
		DressIdle2,
		TurnLeft90,
		TurnLeft45,
		TurnRight90,
		TurnRight45,
		ServantRun,
		LowerWalkF,
		LowerRunF,
		LowerRunB,
		LowerWF,
		LowerWB,
		LowerAtkIdle,
        attackIdle,
        attack1,
        attack2,
        attack3,
        attack4,
        attack5,
        attack6,
        attack7,
        attack8,
        attack9,//31
        attack10,
        attack11,
        attack12,
        attack13,
        attack14,
        attack15,
        attack16,
        Hit1,
        Hit2,
        Hit3,//41
        Hit4,
        Hit5,
        Hit6,
        Death1,
        Death2,
        DodgeRight,
        DodgeLeft,
        SleepDown,
        Sleep,
        SleepUp,//50
        Eat1,
        Spade1,
        Spade2,
        Spade3,
        Mine1,
        Mine2,
        Mine3,
        Felling1,
        Felling2,
        Felling3,//60
        HerbDown,
        Herb,
        HerbUp,
        Build1,
        Build2,
        Build3,
        SwimmingFront,
		SwimmingLeft,
		SwimmingRight,
		SwimmingBack,
		SwimmingUp,
		SwimmingIdle,
		WeaponSwimFront,
		WeaponSwimLeft,
		WeaponSwimRight,
		WeaponSwimBack,
		WeaponSwimUp,
		WeaponSwimIdle,
        Bomb1,
        Bomb2,
        Bomb3,//70
        Pickup,
        Toxophily1,
        Toxophily2,
        Toxophily3,
        Toxophily4,
        Toxophily5,
        Shoot1,
        Shoot2,
        Shoot3,
		Shoot4,
		DoubleShoot1,
		DoubleShoot2,
		DoubleShoot3,
		DoubleShoot4,
        Recover,
        Skill,
        Breathlying,
        Lyinggetup,
        PAMax
	}
}
