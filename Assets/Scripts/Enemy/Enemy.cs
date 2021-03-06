﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
	//System
	public SpriteRenderer renderer;
	public BoxCollider2D collider;
	public Rigidbody2D rigidbody;
	public Animator animator;

	//Developer
	public EnemyControllerAI controls;
	public EnemyStatus status;
	public EnemyMelee melee;

	//Weapon Prefab

	//Initialization
	void Awake ()
	{
		renderer = GetComponent<SpriteRenderer>();
		collider = GetComponent<BoxCollider2D>();
		rigidbody = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();

		controls = GetComponent<EnemyControllerAI>();
		status = GetComponent<EnemyStatus>();
		melee = GetComponentInChildren<EnemyMelee>();
		//camera = GetComponentInChildren<PlayerCamera>();

		if(controls != null) controls.self = this;
		if(status != null) status.self = this;
	}

	/*
    public float HP = 10f;
	public GameObject damageIndicator;
	public float attackStats = 1;

	void Update()
    {
        if(HP <= 0) Destroy(gameObject);
    }

	public void Hurt(bool isCrit)
	{
		float finalDmg = attackStats * (isCrit ? 3 : 1);
		HP -= finalDmg;
	     
		FloatingText(finalDmg.ToString(), (int)finalDmg, (isCrit ? Color.red : Color.yellow));
	}
	 
	public void FloatingText(string text, int damage = 1, Color? textColor = null)
	{
		GameObject textGO = Instantiate(damageIndicator);
		textGO.transform.SetParent(GameObject.Find("Canvas").transform);
		//textGO.transform.GetChild(0).GetComponent<Text>().text = ???;

		Text tempText = textGO.GetComponent<Text>();
		tempText.resizeTextForBestFit = true;
		tempText.alignment = TextAnchor.MiddleCenter;
		tempText.text = text;
		tempText.color = textColor ?? Color.white;
	    
		RectTransform tempRect = textGO.GetComponent<RectTransform>();
		tempRect.transform.position = transform.position + (Vector3.up * 0.4f);
		tempRect.transform.localScale = damageIndicator.transform.localScale / 3 * damage;

		textGO.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 2, ForceMode2D.Impulse);

		Destroy(textGO, 0.3f);
	}
	*/
}
