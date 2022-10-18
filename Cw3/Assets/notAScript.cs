using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notAScript : MonoBehaviour
{

    // Status
    int maxPowerLvl = 100;

    // Hero info
    public string heroName = "Not a Hero";
    public string heroSuperPower = "Nerd";
    public int heroPowerLvl = 23;
    public int HeroSpeed = 20;

    // Villain info
    public string villainName = "Not a Hero";
    public string villainSuperPower = "Extra Super Nerd";
    public int villainPowerLvl = 37;
    public int villainSpeed = 25;



    // Start is called before the first frame update
    void Start()
    {
    
        // f num 1
        double playerSpeed = 0;

        void SetSpeed(double Speed)
        {
           playerSpeed = Speed;
          SetSpeed(2.5);
        }


        // if s1
        if (heroPowerLvl > villainPowerLvl)
        {
            print("The villain is Dead");
        }
        else if (villainPowerLvl >= heroPowerLvl)
        {
            print("The Hero is Dead");
        }
        else
        {
            print("they are playing rocket league i think");
        }
        
        // f num 2
        void CompareSpeed() 
        {
           if (HeroSpeed >= villainSpeed) {
              print("fastest man life");
         } else if (villainSpeed > HeroSpeed || HeroSpeed != villainSpeed) {
             print("villains always on top");
         } else if (HeroSpeed == villainSpeed) {
             print("Hero Speed =" + HeroSpeed + "," + "villain Speed =" + villainSpeed);
          }
        }   


    }

    // f num 2
    /*void CompareSpeed() 
    {
        if (HeroSpeed >= villainSpeed) {
            print("fastest man life");
        } else if (villainSpeed > HeroSpeed || HeroSpeed != villainSpeed) {
            print("villains always on top");
        } else if (HeroSpeed == villainSpeed) {
            print("Hero Speed =" + HeroSpeed + "," + "villain Speed =" + villainSpeed);
        }
     CompareSpeed();
    }
    */

    // Update is called once per frame
    void Update()
    {

    } 

}

