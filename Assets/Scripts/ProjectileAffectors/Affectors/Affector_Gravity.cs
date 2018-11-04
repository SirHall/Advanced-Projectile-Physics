﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "GravityAffector", menuName = "AProjectiles/Affectors/GravityAffector")]
[System.Serializable]
public class Affector_Gravity : AffectorBase
{
	//public Affector_Gravity() : base()
	//{
	//}

	public bool useAdvancedGravity = false;

	public Vector3 gravity = Vector3.down * 9.81f;

	public override void Tick_PostPhysics(float deltaTime)
	{
		//Debug.Log($"Gravity is running {gravity * deltaTime}");
		proj.physicsTransform.AddForce(
			useAdvancedGravity ? GetGravity(proj.physicsTransform.Position.y) : gravity,
			ForceMode.Acceleration,
			deltaTime
			);
	}

	public Vector3 GetGravity(float altitude)
	{
		return ProjectileEnvironment.instance.environment.GetGravity(altitude);
	}
}
