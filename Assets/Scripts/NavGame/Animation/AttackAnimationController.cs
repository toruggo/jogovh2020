﻿using UnityEngine;
using UnityEngine.AI;
using NavGame.Core;

namespace NavGame.Animation
{
    [RequireComponent(typeof(AttackGameObject))]

    public class AttackAnimationController : BasicAnimationController
    {
        protected AttackGameObject attackGameObject;

        protected override void Awake()
        {
            base.Awake();
            attackGameObject = GetComponent<AttackGameObject>();
        }

        protected override void Update()
        {
            base.Update();
            animator.SetBool("InCombat", attackGameObject.isInCombat);
        }

        void OnEnable()
        {
            attackGameObject.onAttackStart += OnAttackStart;
        }

        void OnAttackStart()
        {
            animator.SetTrigger("attack");
        }
    }
}