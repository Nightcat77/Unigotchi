using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedsController : MonoBehaviour
{
    public int food, happiness, energy;
    public int foodTickRate, happinessTickRate, energyTickRate;
    public void Initailize(int food, int happiness, int energy)
    {
        this.food = food;
        this.happiness = happiness;
        this.energy = energy;
    }
    private void Update()
    {
        if (TimeManager.gameHourTimer < 0)
        {
            ChangeFood(-foodTickRate);
            ChangeHappiness(-happinessTickRate);
            ChangeEnergy(-energyTickRate);
        }
    }

    public void ChangeFood(int amount)
    {
        food += amount;
        if (food < 0)
        {
            PetController.Die();
        }
    }
    public void ChangeHappiness(int amount)
    {
        happiness += amount;
        if (happiness < 0)
        {
            PetController.Die();
        }
    }
    public  void ChangeEnergy(int amount)
    {
        energy += amount;
        if (energy < 0)
        {
            PetController.Die();
        }
    }
}
