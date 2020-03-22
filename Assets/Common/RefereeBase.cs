﻿using UnityEngine;

namespace Common
{
    public abstract class RefereeBase : MonoBehaviour
    {
        [SerializeField] protected Transform Gym;

        protected float TimeSinceLastRestart => Time.fixedTime - _lastRestartTime;

        private float _lastRestartTime;

        public virtual void Restart()
        {
            _lastRestartTime = Time.fixedTime;
        }

        protected Vector2 GetRandomPositionInGym()
        {
            return (Vector2)transform.position + Gym.localScale * new Vector2(
                  Mathf.Sign(Random.Range(-1f, 1f)) * Random.Range(0.1f, 0.9f),
                  Mathf.Sign(Random.Range(-1f, 1f)) * Random.Range(0.1f, 0.9f)
                 ) / 2;
        }
    }
}
