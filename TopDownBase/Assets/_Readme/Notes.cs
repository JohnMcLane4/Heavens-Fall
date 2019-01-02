using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour {

    /*
     *Player:
     * 
     *   + substitude Graphics with the player model (ship,spider)
     *   + add a capsule collider (or mesh collider(cpu heavy)) to the model
     *   + Engine/movement particle system
     * 
     *   capsule collider: direction: z-axis and change size
     *   mesh collider: check "convex", check "Is trigger" and maybe add a new simplified Mesh
     * 
     * 
     *Projectile:
     *  + New Sprite: add own projectile sprite and change capsule collider to appropriate size
     * 
     * 
     *Enemy/Hazard
     *  + substitude Graphics with new model
     *  + add a capsule collider (or mesh collider(cpu heavy)) to the model
     * 
     * 
     *Stuff to add:
     *    GameMaster:
     *  + EnemyOrHazard: deathEffect(prefab)
     *  + EnemyOrHazard: Engine or dust Effect(prefab)
     *  
     *  
     *  + Projectile: hitEffect(prefab)
     *  + HumingRockets
     *  
     * 
     * 
     * 
     *Camera: 
     * "Projection" Perspective/Orthografic? trying parallaxing?
     * 
     *
     * 
     *Lighting: 
     *  maybe a second, less strong light?
     * 
     *
     * 
     *playerMovement: 
     *  control if tilt is working
     *  
     *BoundaryBox:
     *  needs to be >= than the field of view: all prefabs getting destroyed reaching this box
     * 
     * 
     *TextFont:
     *  we need one
     *  
     *GameOverUI:
     * Button texture and color
     * textfont and shadow
     * create/edit animation
     * Shop: Button Textures (weapons image)     
     * 
     * 
     *Shield:
     * see ep. 29 around min 7, regenRate
     * 
     *PlayerStats:
     * HullMultiplier: function for round numbers
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */
}
