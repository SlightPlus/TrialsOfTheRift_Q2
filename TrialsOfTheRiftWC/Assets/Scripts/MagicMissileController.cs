﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicMissileController : SpellController {

    protected override void ApplyEffect(GameObject go_target) {
        if (go_target.tag == "Player") {
            if (go_target.GetComponent<PlayerController>().GetColor() != this.e_color)
            {
                go_target.GetComponent<PlayerController>().TakeDamage(Constants.SpellStats.C_MagicMissileDamage);
                go_target.GetComponent<PlayerController>().Drop();
            }
            else {
                go_target.GetComponent<PlayerController>().HealDamage(Constants.SpellStats.C_MagicMissileHeal);
            }
        }
		else if (go_target.tag == "Enemy") {
            go_target.GetComponent<EnemyController>().TakeDamage(Constants.SpellStats.C_MagicMissileDamage);
        }
		else if (go_target.tag == "Crystal"){
			Constants.Color crystalColor = go_target.GetComponent<CrystalController>().e_color;
			if (crystalColor != e_color){
				go_target.GetComponent<CrystalController>().ChangeHealth(Constants.SpellStats.C_MMCrystalDamagePercent);
			}
			else if (crystalColor == e_color) {
				go_target.GetComponent<CrystalController>().ChangeHealth(Constants.SpellStats.C_MMCrystalHealPercent);
			}
		}
    }

    protected override void BuffSpell() {
        // Magic Missile doesn't cross the rift. Destroy it
        Destroy(gameObject);
    }
}
