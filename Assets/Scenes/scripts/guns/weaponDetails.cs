using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class weaponDetails : MonoBehaviour
{
    public static weaponDetails instance;
    public int headDamage, bodyDamage, legDamage, magazineSize;

    [SerializeField]
    GameObject thisObject;

    GameObject currentWeapon;
    int bulletsPerTap = 0;
    int burstTap = 0;
    public bool ads = false;
    bool buttonhold = false;
    bool rightClickBurst = false;
    float spread = 0.02f;
    bool onlyBurstGuns = false;
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        currentGunDetails();
    }

    void currentGunDetails()
    {
        currentWeapon = gunScroll.instance.currentGun;
        //gunDetails();
    }

    // Sending guns basic details initially to the gun system script
    public void gunDetails(string name)
    {
        if (name == "Classic")
        {
            onlyBurstGuns = false;
            spread = 0.02f;
            ads = false;
            buttonhold = false;
            rightClickBurst = true;
            bulletsPerTap = 1;
            burstTap = 3;
            magazineSize = 12;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }
        if (name == "Shorty")
        {
            onlyBurstGuns = true; ;
            spread = 0.05f;
            ads = false;
            buttonhold = false;
            rightClickBurst = false;
            bulletsPerTap = 5;
            burstTap = 0;
            magazineSize = 2;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }
        if (name == "Frenzy")
        {
            onlyBurstGuns = false; ;
            spread = 0.02f;
            ads = false;
            buttonhold = true;
            rightClickBurst = false;
            bulletsPerTap = 1;
            burstTap = 0;
            magazineSize = 13;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }
        if (name == "Ghost")
        {
            onlyBurstGuns = false; ;
            spread = 0.02f;
            ads = false;
            buttonhold = false;
            rightClickBurst = false;
            bulletsPerTap = 1;
            burstTap = 0;
            magazineSize = 15;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }
        if (name == "Sheriff")
        {
            onlyBurstGuns = false; ;
            spread = 0.02f;
            ads = false;
            buttonhold = false;
            rightClickBurst = false;
            bulletsPerTap = 1;
            burstTap = 0;
            magazineSize = 6;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }

        // SMGS ------------------------------------------------------------------------------------------------ 

        if (name == "Stinger")
        {
            onlyBurstGuns = false; ;
            spread = 0.02f;
            ads = true;
            buttonhold = true;
            rightClickBurst = false;
            bulletsPerTap = 1;
            burstTap = 0;
            magazineSize = 30;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }
        if (name == "Spectre")
        {
            onlyBurstGuns = false; ;
            spread = 0.02f;
            ads = true;
            buttonhold = true;
            rightClickBurst = false;
            bulletsPerTap = 1;
            burstTap = 0;
            magazineSize = 20;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }

        // SHOTGUNNS ------------------------------------------------------------------------------------------------

        if (name == "Bucky")
        {
            onlyBurstGuns = true; ;
            spread = 0.05f;
            ads = false;
            buttonhold = true;
            rightClickBurst = true;
            bulletsPerTap = 5;
            burstTap = 0;
            magazineSize = 5;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }
        if (name == "Judge")
        {
            onlyBurstGuns = true; ;
            spread = 0.05f;
            ads = false;
            buttonhold = false;
            rightClickBurst = true;
            bulletsPerTap = 5;
            burstTap = 0;
            magazineSize = 7;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }

        // RIFLES ------------------------------------------------------------------------------------------------

        if (name == "Vandal")
        {
            onlyBurstGuns = false; ;
            spread = 0.02f;
            ads = true;
            buttonhold = true;
            rightClickBurst = false;
            bulletsPerTap = 1;
            burstTap = 0;
            magazineSize = 25;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }
        if (name == "Phantom")
        {
            onlyBurstGuns = false; ;
            spread = 0.02f;
            ads = true;
            buttonhold = true;
            rightClickBurst = false;
            bulletsPerTap = 1;
            burstTap = 0;
            magazineSize = 30;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }
        if (name == "Bulldog")
        {
            // ads burst remaining
            onlyBurstGuns = false; ;
            spread = 0.02f;
            ads = true;
            buttonhold = true;
            rightClickBurst = false;
            bulletsPerTap = 1;
            burstTap = 0;
            magazineSize = 24;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }
        if (name == "Guardian")
        {
            onlyBurstGuns = false; ;
            spread = 0.02f;
            ads = true;
            buttonhold = false;
            rightClickBurst = false;
            bulletsPerTap = 1;
            burstTap = 0;
            magazineSize = 12;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }

        // SNIPER RIFLES ------------------------------------------------------------------------------------------------
        if (name == "Operator")
        {
            magazineSize = 5;

            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }
        if (name == "Marshal")
        {
            magazineSize = 5;

            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
            print("marshal" + " " + headDamage + " " + bodyDamage + " " + legDamage);
        }

        // MACHINE GUNS ------------------------------------------------------------------------------------------------
        if (name == "Aries")
        {
            onlyBurstGuns = false; ;
            spread = 0.02f;
            ads = true;
            buttonhold = true;
            rightClickBurst = false;
            bulletsPerTap = 1;
            burstTap = 0;
            magazineSize = 50;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }
        if (name == "Odin")
        {
            onlyBurstGuns = false; ;
            spread = 0.02f;
            ads = true;
            buttonhold = true;
            rightClickBurst = false;
            bulletsPerTap = 1;
            burstTap = 0;
            magazineSize = 100;
            thisObject.GetComponent<gunSystem>().gettingDetailofWeapons(magazineSize, bulletsPerTap, buttonhold, spread);
        }
    }


    // Function overloaded with gun details with respect to the distance between enemy and player
    public void gunDetails(string name, float distance)
    {
        // PISTOLS------------------------------------------------------------------------------------------------

        if (name == "Classic")
        {
            if (distance <= 30)
            {
                headDamage = 78;
                bodyDamage = 26;
                legDamage = 22;
            }
            else
            {
                headDamage = 66;
                bodyDamage = 22;
                legDamage = 18;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
        }
        if (name == "Shorty")
        {
            if (distance <= 7)
            {
                headDamage = 24;
                bodyDamage = 12;
                legDamage = 10;
            }
            else if (distance >= 8 && distance <= 15)
            {
                headDamage = 16;
                bodyDamage = 8;
                legDamage = 6;
            }
            else
            {
                headDamage = 6;
                bodyDamage = 3;
                legDamage = 2;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
        }
        if (name == "Frenzy")
        {
            if (distance <= 20)
            {
                headDamage = 78;
                bodyDamage = 26;
                legDamage = 22;
            }
            else
            {
                headDamage = 63;
                bodyDamage = 21;
                legDamage = 17;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
        }
        if (name == "Ghost")
        {
            if (distance <= 30)
            {
                headDamage = 105;
                bodyDamage = 30;
                legDamage = 25;
            }
            else
            {
                headDamage = 87;
                bodyDamage = 25;
                legDamage = 21;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
        }
        if (name == "Sheriff")
        {
            if (distance <= 30)
            {
                headDamage = 159;
                bodyDamage = 55;
                legDamage = 46;
            }
            else
            {
                headDamage = 145;
                bodyDamage = 50;
                legDamage = 42;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
        }

        // SMGS ------------------------------------------------------------------------------------------------ 

        if (name == "Stinger")
        {

            if (distance <= 15)
            {
                headDamage = 67;
                bodyDamage = 27;
                legDamage = 22;
            }
            else
            {
                headDamage = 57;
                bodyDamage = 23;
                legDamage = 19;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
        }
        if (name == "Spectre")
        {
            if (distance <= 15)
            {
                headDamage = 78;
                bodyDamage = 26;
                legDamage = 20;
            }
            else if (distance >= 16 && distance <= 30)
            {
                headDamage = 66;
                bodyDamage = 22;
                legDamage = 18;
            }
            else
            {
                headDamage = 60;
                bodyDamage = 20;
                legDamage = 17;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
        }

        // SHOTGUNNS ------------------------------------------------------------------------------------------------

        if (name == "Bucky")
        {
            if (distance <= 8)
            {
                headDamage = 40;
                bodyDamage = 20;
                legDamage = 17;
            }
            else if (distance >= 9 && distance <= 12)
            {
                headDamage = 26;
                bodyDamage = 13;
                legDamage = 11;
            }
            else
            {
                headDamage = 18;
                bodyDamage = 9;
                legDamage = 7;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
        }
        if (name == "Judge")
        {
            if (distance <= 10)
            {
                headDamage = 34;
                bodyDamage = 17;
                legDamage = 14;
            }
            else if (distance >= 11 && distance <= 15)
            {
                headDamage = 22;
                bodyDamage = 10;
                legDamage = 8;
            }
            else
            {
                headDamage = 14;
                bodyDamage = 7;
                legDamage = 5;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
        }

        // RIFLES ------------------------------------------------------------------------------------------------

        if (name == "Vandal")
        {
            if (distance <= 50)
            {
                headDamage = 160;
                bodyDamage = 40;
                legDamage = 34;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
        }
        if (name == "Phantom")
        {
            if (distance <= 15)
            {
                headDamage = 156;
                bodyDamage = 39;
                legDamage = 33;
            }
            else if (distance >= 16 && distance <= 30)
            {
                headDamage = 140;
                bodyDamage = 35;
                legDamage = 29;
            }
            else
            {
                headDamage = 124;
                bodyDamage = 31;
                legDamage = 26;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
        }
        if (name == "Bulldog")
        {
            // ads burst remaining
            if (distance <= 50)
            {
                headDamage = 115;
                bodyDamage = 35;
                legDamage = 29;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
            //print("bulldog" + " " + headDamage + " " + bodyDamage + " " + legDamage);
        }
        if (name == "Guardian")
        {
            if (distance <= 50)
            {
                headDamage = 195;
                bodyDamage = 65;
                legDamage = 48;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
            print("marshal" + " " + headDamage + " " + bodyDamage + " " + legDamage);
        }

        // SNIPER RIFLES ------------------------------------------------------------------------------------------------
        if (name == "Operator")
        {
            if (distance <= 50)
            {
                headDamage = 255;
                bodyDamage = 150;
                legDamage = 120;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
            //print("operator" + " " + headDamage + " " + bodyDamage + " " + legDamage);
        }
        if (name == "Marshal")
        {
            if (distance <= 50)
            {
                headDamage = 202;
                bodyDamage = 101;
                legDamage = 85;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
            print("marshal" + " " + headDamage + " " + bodyDamage + " " + legDamage);
        }

        // MACHINE GUNS ------------------------------------------------------------------------------------------------
        if (name == "Aries")
        {
            if (distance <= 30)
            {
                headDamage = 72;
                bodyDamage = 30;
                legDamage = 25;
            }
            else
            {
                headDamage = 67;
                bodyDamage = 28;
                legDamage = 23;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);

        }
        if (name == "Odin")
        {
            if (distance <= 30)
            {
                headDamage = 95;
                bodyDamage = 38;
                legDamage = 32;
            }
            else
            {
                headDamage = 77;
                bodyDamage = 31;
                legDamage = 26;
            }
            thisObject.GetComponent<gunSystem>().gunDamage(headDamage, bodyDamage, legDamage);
        }


        // for guardian allow button hold set false in gunsystem
    }

    //void currentGunDetails()
    //{
    //    currentWeapon = gunScroll.instance.currentGun;
    //    gunDetails();
    //}

    //void gunDetails()
    //{

    //    // PISTOLS------------------------------------------------------------------------------------------------

    //    if (currentWeapon.name == "Classic")
    //    {
    //        magazineSize = 12;
    //        if (distance <= 30)
    //        {
    //            headDamage = 78;
    //            bodyDamage = 26;
    //            legDamage = 22;
    //        }
    //        else
    //        {
    //            headDamage = 66;
    //            bodyDamage = 22;
    //            legDamage = 18;
    //        }
    //        print("classic " + distance + " " + headDamage + " " + bodyDamage + " " + legDamage);
    //    }
    //    if (currentWeapon.name == "Shorty")
    //    {
    //        magazineSize = 2;
    //        if (distance <= 7)
    //        {
    //            headDamage = 24;
    //            bodyDamage = 12;
    //            legDamage = 10;
    //        }
    //        else if (distance >= 8 && distance <= 15)
    //        {
    //            headDamage = 16;
    //            bodyDamage = 8;
    //            legDamage = 6;
    //        }
    //        else
    //        {
    //            headDamage = 6;
    //            bodyDamage = 3;
    //            legDamage = 2;
    //        }
    //        print("Shorty " + distance + " " + headDamage + " " + bodyDamage + " " + legDamage);
    //    }
    //    if (currentWeapon.name == "Frenzy")
    //    {
    //        magazineSize = 13;
    //        if (distance <= 20)
    //        {
    //            headDamage = 78;
    //            bodyDamage = 26;
    //            legDamage = 22;
    //        }
    //        else
    //        {
    //            headDamage = 63;
    //            bodyDamage = 21;
    //            legDamage = 17;
    //        }
    //        print("Frenzy " + distance + " " + headDamage + " " + bodyDamage + " " + legDamage);
    //    }
    //    if (currentWeapon.name == "Ghost")
    //    {
    //        magazineSize = 15;
    //        if (distance <= 30)
    //        {
    //            headDamage = 105;
    //            bodyDamage = 30;
    //            legDamage = 25;
    //        }
    //        else
    //        {
    //            headDamage = 87;
    //            bodyDamage = 25;
    //            legDamage = 21;
    //        }
    //        print("Ghost " + distance + " " + headDamage + " " + bodyDamage + " " + legDamage);
    //    }
    //    if (currentWeapon.name == "Sheriff")
    //    {
    //        magazineSize = 6;
    //        if (distance <= 30)
    //        {
    //            headDamage = 159;
    //            bodyDamage = 55;
    //            legDamage = 46;
    //        }
    //        else
    //        {
    //            headDamage = 145;
    //            bodyDamage = 50;
    //            legDamage = 42;
    //        }
    //        print("Sheriff " + distance + " " + headDamage + " " + bodyDamage + " " + legDamage);
    //    }

    //    // SMGS ------------------------------------------------------------------------------------------------ 

    //    if (currentWeapon.name == "Stinger")
    //    {
    //        magazineSize = 30;
    //        if (distance <= 15)
    //        {
    //            headDamage = 67;
    //            bodyDamage = 27;
    //            legDamage = 22;
    //        }
    //        else
    //        {
    //            headDamage = 57;
    //            bodyDamage = 23;
    //            legDamage = 19;
    //        }
    //        print("Stinger " + distance + " " + headDamage + " " + bodyDamage + " " + legDamage);
    //    }
    //    if (currentWeapon.name == "Spectre")
    //    {
    //        magazineSize = 20;
    //        if (distance <= 15)
    //        {
    //            headDamage = 78;
    //            bodyDamage = 26;
    //            legDamage = 20;
    //        }
    //        else if (distance >= 16 && distance <= 30)
    //        {
    //            headDamage = 66;
    //            bodyDamage = 22;
    //            legDamage = 18;
    //        }
    //        else
    //        {
    //            headDamage = 60;
    //            bodyDamage = 20;
    //            legDamage = 17;
    //        }
    //        print("Stinger " + distance + " " + headDamage + " " + bodyDamage + " " + legDamage);
    //    }

    //    // SHOTGUNNS ------------------------------------------------------------------------------------------------

    //    if (currentWeapon.name == "Bucky")
    //    {
    //        magazineSize = 5;
    //        if (distance <= 8)
    //        {
    //            headDamage = 40;
    //            bodyDamage = 20;
    //            legDamage = 17;
    //        }
    //        else if (distance >= 9 && distance <= 12)
    //        {
    //            headDamage = 26;
    //            bodyDamage = 13;
    //            legDamage = 11;
    //        }
    //        else
    //        {
    //            headDamage = 18;
    //            bodyDamage = 9;
    //            legDamage = 7;
    //        }
    //    }
    //    if (currentWeapon.name == "Judge")
    //    {
    //        magazineSize = 7;
    //        if (distance <= 10)
    //        {
    //            headDamage = 34;
    //            bodyDamage = 17;
    //            legDamage = 14;
    //        }
    //        else if (distance >= 11 && distance <= 15)
    //        {
    //            headDamage = 22;
    //            bodyDamage = 10;
    //            legDamage = 8;
    //        }
    //        else
    //        {
    //            headDamage = 14;
    //            bodyDamage = 7;
    //            legDamage = 5;
    //        }
    //    }

    //    // RIFLES ------------------------------------------------------------------------------------------------

    //    if (currentWeapon.name == "Vandal")
    //    {
    //        magazineSize = 25;
    //        if (distance <= 50)
    //        {
    //            headDamage = 160;
    //            bodyDamage = 40;
    //            legDamage = 34;
    //        }

    //        print("vandal" + " " + headDamage + " " + bodyDamage + " " + legDamage);
    //    }
    //    if (currentWeapon.name == "Phantom")
    //    {
    //        magazineSize = 30;
    //        if (distance <= 15)
    //        {
    //            headDamage = 156;
    //            bodyDamage = 39;
    //            legDamage = 33;
    //        }
    //        else if (distance >= 16 && distance <= 30)
    //        {
    //            headDamage = 140;
    //            bodyDamage = 35;
    //            legDamage = 29;
    //        }
    //        else
    //        {
    //            headDamage = 124;
    //            bodyDamage = 31;
    //            legDamage = 26;
    //        }
    //    }
    //    if (currentWeapon.name == "Bulldog")
    //    {
    //        magazineSize = 24;
    //        if (distance <= 50)
    //        {
    //            headDamage = 115;
    //            bodyDamage = 35;
    //            legDamage = 29;
    //        }
    //        print("bulldog" + " " + headDamage + " " + bodyDamage + " " + legDamage);
    //    }
    //    if (currentWeapon.name == "Guardian")
    //    {
    //        magazineSize = 12;
    //        if (distance <= 50)
    //        {
    //            headDamage = 195;
    //            bodyDamage = 65;
    //            legDamage = 48;
    //        }
    //        print("marshal" + " " + headDamage + " " + bodyDamage + " " + legDamage);
    //    }

    //    // SNIPER RIFLES ------------------------------------------------------------------------------------------------
    //    if (currentWeapon.name == "Opertor")
    //    {
    //        magazineSize = 5;
    //        if (distance <= 50)
    //        {
    //            headDamage = 255;
    //            bodyDamage = 150;
    //            legDamage = 120;
    //        }
    //        print("marshal" + " " + headDamage + " " + bodyDamage + " " + legDamage);
    //    }
    //    if (currentWeapon.name == "Marshal")
    //    {
    //        magazineSize = 5;
    //        if (distance <= 50)
    //        {
    //            headDamage = 202;
    //            bodyDamage = 101;
    //            legDamage = 85;
    //        }
    //        print("marshal" + " " + headDamage + " " + bodyDamage + " " + legDamage);
    //    }

    //    // MACHINE GUNS ------------------------------------------------------------------------------------------------
    //    if (currentWeapon.name == "Aries")
    //    {
    //        magazineSize = 50;
    //        if (distance <= 30)
    //        {
    //            headDamage = 72;
    //            bodyDamage = 30;
    //            legDamage = 25;
    //        }
    //        else
    //        {
    //            headDamage = 67;
    //            bodyDamage = 28;
    //            legDamage = 23;
    //        }
    //    }
    //    if (currentWeapon.name == "Odin")
    //    {
    //        magazineSize = 100;
    //        if (distance <= 30)
    //        {
    //            headDamage = 95;
    //            bodyDamage = 38;
    //            legDamage = 32;
    //        }
    //        else
    //        {
    //            headDamage = 77;
    //            bodyDamage = 31;
    //            legDamage = 26;
    //        }
    //    }


    //    // for guardian allow button hold set false in gunsystem
    //}
}