using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Grounds
{
    public abstract void Activate();
    protected void Move(float speed = 6)
    {
        Debug.Log("Moving Speed: " + speed);
        CharacterControl.Instance.walkSpeed = speed;
    }

    protected void PlaySound(string clip)
    {
        Debug.Log("Clip Name: " + clip);
    }
    protected void SpawnParticles(string particle)
    {
        Debug.Log("Particle Name: " + particle);
    }
}
