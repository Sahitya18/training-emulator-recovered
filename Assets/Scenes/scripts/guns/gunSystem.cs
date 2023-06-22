using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunSystem : MonoBehaviour
{
    public static gunSystem instance;
    [SerializeField]
    GameObject thisObject;
    //Gun stats
    public int headDamage, bodyDamage, legDamage;
    float distanceBetweenPlayerAndEnemy;
    public float timeBetweenShooting, spread, range, reloadTime, timeBetweenShots;
    public int magazineSize = 0, bulletsPerTap = 1;
    public bool allowButtonHold, rightButtonHold;
    int bulletsLeft, bulletsShot;
    [SerializeField]
    GameObject enemyBody;
    [SerializeField]
    Transform muzzle;
    //GameObject enemyBody; 

    //bools 
    bool shooting, readyToShoot, reloading = false;
    public bool gunburst = false;

    bool rightClickBurst = false;
    //Reference
    public Camera fpsCam;
    public Transform attackPoint;
    public RaycastHit rayHit;
    public LayerMask whatIsEnemy;

    //Graphics
    public GameObject muzzleFlash, bulletHoleGraphic;
    //------public CamShake camShake;
    public float camShakeMagnitude, camShakeDuration;
    //------public TextMeshProUGUI text;

    private void Awake()
    {
        instance = this;
        readyToShoot = true;
        weaponDetails wd = new weaponDetails();
    }

    private void Update()
    {
        bulletsLeft = magazineSize;
        myInput();
        
        //print(headDamage + " " + bodyDamage + " " + legDamage);
        //print("mg size " + magazineSize);
    }
    private void myInput()
    {
        // getting gun name from gunscroll script
        currentWeapon = gunScroll.instance.currentGun;

        // Sending gun name to the weapon details script to get initial basic data of the gun
        thisObject.GetComponent<weaponDetails>().gunDetails(currentWeapon.name);



        if (allowButtonHold)
        {
            shooting = Input.GetKey(KeyCode.Mouse0);
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1) && rightClickBurst)
        {
            bulletsPerTap = 3;
            shoot();
            //rightClickBurst = false;
            //bulletsPerTap = 1;
        }
        else
        {
            shooting = Input.GetKeyDown(KeyCode.Mouse0);
        }

        //if (Input.GetKeyDown(KeyCode.R) && bulletsLeft < magazineSize && !reloading) 
        //{ 
        //    reload(); 
        //}

        //Shoot
        if (readyToShoot && shooting && !reloading && bulletsLeft > 0)
        {
            bulletsShot = bulletsPerTap;
            shoot();
        }
    }

    GameObject currentWeapon;
    private void shoot()
    {

        readyToShoot = false;

        //Spread
        float x = Random.Range(-spread, spread);
        float y = Random.Range(-spread, spread);

        //Calculate Direction with Spread
        Vector3 direction = fpsCam.transform.forward + new Vector3(x, y, 0);

        //RayCast
        if (Physics.Raycast(fpsCam.transform.position, direction, out rayHit, range, whatIsEnemy))
        {
            Debug.Log(rayHit.collider.name);

            currentWeapon = gunScroll.instance.currentGun;

            // enemyBody = enemyspawn.instance.spawnedObject;
            distanceBetweenPlayerAndEnemy = Vector3.Distance(muzzle.transform.position, enemyBody.transform.position);

            // sending gun name and distance to the weaponDetails script to get gun damages according to the distance of the player from enemy
            thisObject.GetComponent<weaponDetails>().gunDetails(currentWeapon.name, distanceBetweenPlayerAndEnemy);


            if (rayHit.collider.CompareTag("enemyHead"))
            {
                //print("hh "+headDamage);
                //damageTaking.instance.enemyHealth -= headDamage;
                enemyBody.GetComponent<damageTaking>().gettingDamage(headDamage);
            }
            if (rayHit.collider.CompareTag("enemyBody"))
            {
                //print("bb " + damageTaking.instance.enemyHealth);
                //damageTaking.instance.enemyHealth -= bodyDamage;
                enemyBody.GetComponent<damageTaking>().gettingDamage(bodyDamage);
            }
            if (rayHit.collider.CompareTag("enemyLeg"))
            {
                //print("ll " + legDamage);
                //damageTaking.instance.enemyHealth -= legDamage;
                enemyBody.GetComponent<damageTaking>().gettingDamage(legDamage);

            }
        }


        //Graphics
        Instantiate(bulletHoleGraphic, rayHit.point, Quaternion.Euler(0, 180, 0));
        Instantiate(muzzleFlash, attackPoint.position, Quaternion.identity);

        bulletsLeft--;
        bulletsShot--;

        //print("magg " + bulletsShot + " " + bulletsLeft);


        Invoke("resetShot", timeBetweenShooting);

        //readyToShoot = true;
        if (bulletsShot > 0 && bulletsLeft > 0)
            Invoke("shoot", timeBetweenShots);
    }

    // getting details from weaponDetails
    public void gettingDetailofWeapons(int inheritMagazine, int inheritBulletsPerTap, bool inheritButtonHold, float inheritSpread)
    {
        magazineSize = inheritMagazine;
        bulletsPerTap = inheritBulletsPerTap;
        spread = inheritSpread;
        allowButtonHold = inheritButtonHold;
        //print("m " + magazineSize);
    }

    public void gunDamage(int inheritHeadDamage, int inheritBodyDamage, int inheritLegDamage)
    {
        headDamage = inheritHeadDamage;
        bodyDamage = inheritBodyDamage;
        legDamage = inheritLegDamage;
    }

    private void resetShot()
    {
        readyToShoot = true;
    }
    //private void reload()
    //{
    //    reloading = true;
    //    Invoke("reloadFinished", reloadTime);
    //}
    //private void reloadFinished()
    //{
    //    bulletsLeft = magazineSize;
    //    reloading = false;
    //}
}


//Remarks: Remove print statements