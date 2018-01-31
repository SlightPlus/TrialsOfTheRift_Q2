﻿/*  Constants - Everyone
 * 
 *  Desc:   Holds all of the numbers used in the codebase.
 *          DebugParametersController can adjust these numbers.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constants {

    // Global Constants
    public static class Global {
        public enum Color { RED, BLUE };
        public enum Side { LEFT = -1, RIGHT = 1 };
    }

    // Player Stats
    public static class PlayerStats {
        public static float C_MovementSpeed = 10.0f;
        public static float C_WispMovementSpeed = 2.0f;
        public static float C_RespawnTimer = 5.0f;
        public static float C_MaxHealth = 300.0f;
    }

    // Spell Stats
    // TODO: Damage players?
    public static class SpellStats {
        // Common Spell Stats
        public static float C_RiftDamageMultiplier = 2.0f;
        public static float C_SpellLiveTime = 2.0f;
        public static float C_SpellChargeTime = 3.0f;
        public static float C_NextSpellDelay = 0.5f;
        public static float C_PlayerProjectileSize = 0.75f;
        public static float C_SpellScaleMultiplier = 1.15f;

        // Magic Missile Stats
        public static float C_MagicMissileLiveTime = 0.35f;
		public static float C_MagicMissileSpeed = 20.0f;
        public static float C_MagicMissileDamage = 25.0f;
        public static float C_MagicMissileCooldown = 0.34f;
        public static float C_MagicMissileChargeTime = C_SpellChargeTime;
        public static float C_MagicMissileChargeCooldown = 0.50f;
        public static float C_MagicMissileHeal = 10.0f;

        // Wind Stats
        public static float C_WindLiveTime = 0.20f;
        public static float C_WindSpeed = 20.0f;
        public static float C_WindDamage = 50.0f;
        public static float C_WindCooldown = 3.0f;
        public static float C_WindChargeTime = C_SpellChargeTime;
        public static float C_WindRiftDamageMultiplier = C_RiftDamageMultiplier;
        public static float C_WindPlayerDamageMultiplier = 0.5f;
        public static float C_WindForce = 6000.0f; // 4m worth of distance - we need to do our own 

        // Ice Stats
        // TODO: UHHHHH....? (live time vs. charge time... FIGHT)
        public static float C_IceLiveTime = 3.00f;
        public static float C_IceSpeed = 10.0f;
        public static float C_IceDamage = 75.0f;
        public static float C_IceCooldown = 5.0f;
        public static float C_IceChargeTime = C_SpellChargeTime;
        public static float C_IceRiftDamageMultiplier = C_RiftDamageMultiplier;
        public static float C_IceFreezeTime = 3.0f;
        public static float C_IcePlayerDamageMultiplier = 0.5f;

        // it's ELECTRIC! (boogie woogie woogie) Stats
        // TODO: make charge time and Live time tied
        public static float C_ElectricLiveTime = 0.3f;
        public static float C_ElectricSpeed = 20.0f;
		public static float C_ElectricDamage = 40.0f;
		public static float C_ElectricCooldown = 8.0f;
        public static float C_ElectricChargeTime = C_SpellChargeTime;
        public static float C_ElectricRiftDamageMultiplier = C_RiftDamageMultiplier;
        public static float C_ElectricAOESlowMultiplier = 0.5f;
        public static float C_ElectricAOELiveTime = 5.0f;
        public static float C_ElectricPlayerDamageMultiplier = 0.5f;

        // Crystal based percentages Stats
        // TODO: uhh... why is it percent for this? make it real damage instead
        public static float C_SpellCrystalDamagePercent = -0.10f;
        public static float C_SpellCrystalHealPercent = 0.05f;
        public static float C_MagicMissileCrystalDamagePercent = -0.01f;
        public static float C_MagicMissileCrystalHealPercent = 0.005f;
    }

    // Objective Stats
    public static class ObjectiveStats {
        // Generic Objective Spawning Stats
        public static Vector3 C_GenericRedObjectiveTargetSpawn = new Vector3(20.0f, 0.5f, 0f);
        public static Vector3 C_GenericBlueObjectiveTargetSpawn = new Vector3(-20.0f, 0.5f, 0f);
        public static Vector3 C_GenericRedObjectiveGoalSpawn = new Vector3(-3.0f, .01f, 0f);
        public static Vector3 C_GenericBlueObjectiveGoalSpawn = new Vector3(3.0f, .01f, 0f);

        // Potato Stats
        public static Vector3 C_RedPotatoSpawn = new Vector3(-5.0f, 0.5f, 0f);
        public static Vector3 C_BluePotatoSpawn = new Vector3(5.0f, 0.5f, 0f);
        public static int C_PotatoCompletionTimer = 30;
        public static int C_PotatoSelfDestructTimer = 10;

        // CTF Stats
        public static Vector3 C_RedFlagSpawn = C_GenericBlueObjectiveTargetSpawn;
        public static Vector3 C_BlueFlagSpawn = C_GenericRedObjectiveTargetSpawn;
        public static Vector3 C_RedCTFGoalSpawn = C_GenericRedObjectiveGoalSpawn;
        public static Vector3 C_BlueCTFGoalSpawn = C_GenericBlueObjectiveGoalSpawn;
        public static int C_CTFMaxScore = 3;

        // Crystal Stats
        public static Vector3 C_RedCrystalSpawn = C_GenericBlueObjectiveTargetSpawn;
        public static Vector3 C_BlueCrystalSpawn = C_GenericRedObjectiveTargetSpawn;
        public static float C_CrystalMaxHealth = 500.0f;

        //Ice Hockey Stats
        public static Vector3 C_RedPuckSpawn = new Vector3(20.0f, 0.5f, 0f);
        public static Vector3 C_BluePuckSpawn = new Vector3(5.0f, 0.5f, 0f);
        public static Vector3 C_RedHockeyGoalSpawn = new Vector3(-20.0f, 0.01f, 0.0f);
        public static Vector3 C_BlueHockeyGoalSpawn = new Vector3(20.0f, 0.01f, 0.0f);
        public static int C_HockeyMaxScore = 3;
        public static int C_PuckDamage = 240;
        public static float C_SpeedDecayDelay = 3.0f;
        public static float C_SpeedDecayRate = 1.0f;
        public static float C_SpeedDecreaseRate = 2.0f;
        public static float C_PuckBaseSpeed = 10.0f;
        public static float C_HitIncreaseSpeed = 5.0f;
    }
       
    // Enemy Stats
    public static class EnemyStats {
        public static int C_EnemySpawnCapPerSide = 30;
        public static float C_EnemySpeed = 3.5f;
		public static float C_EnemyAttackRange = 1.5f;
        public static float C_EnemyHealth = 75.0f;
        public static float C_EnemyDamage = 25.0f;
    }

    // Rift Stats
    public static class RiftStats {
        public static float C_VolatilityResetTime = 5.0f;
        //public static float C_Volatility_CameraFlipTime = 5.0f;
        public static float C_VolatilityEnemySpawnTimer = 7.0f;
        public static float C_VolatilityMeteorDamage = 50.0f;

        public static float C_VolatilityIncrease_RoomAdvance = 5.0f;
        public static float C_VolatilityIncrease_SpellCross = 0.5f;
        public static float C_VolatilityIncrease_PlayerDeath = 2.5f;

        public static float C_VolatilityMultiplier_L1 = 0.0f;
        public static float C_VolatilityMultiplier_L2 = 0.2f;
        public static float C_VolatilityMultiplier_L3 = 0.5f;
        public static float C_VolatilityMultiplier_L4 = 1.0f;

        public enum Volatility { ZERO, FIVE, TWENTYFIVE, THIRTYFIVE, FIFTY, SIXTYFIVE, SEVENTYFIVE, ONEHUNDRED };
    }

	public static GameObject[] C_Players = GameObject.FindGameObjectsWithTag("Player");
}
