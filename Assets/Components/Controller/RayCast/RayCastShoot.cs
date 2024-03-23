using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poplloon.Entity;

namespace Poplloon.RayCast
{
    public class RayCastShoot : MonoBehaviour   
    {
        private void Update()
        {
            //If the first touch has been began
            if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
            {
                //Shooting ray in touches position
                Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);

                RaycastHit hit;

                if(Physics.Raycast(ray, out hit))
                {
                    var balloon = hit.collider.GetComponent<BalloonColor>();
                    var powerUp = hit.collider.GetComponent<PowerUp>();

                    if(hit.collider.CompareTag("Balloon"))
                    {
                        Reward.reward.Revenue(balloon.color);
                        balloon._isMoving = false;
                        balloon.ParticleColor();
                        balloon.StartCoroutine("DisableEntity");
                    }

                    /*if(_hit.collider.tag == "Balloon")
                    {
                        ScoreSystem.score._score += 500;
                    }*/

                    if(hit.collider.tag == "PowerUp")
                    {
                        powerUp.StartCoroutine("DisableEntity");
                        powerUp._isMoving = false;
                        PowerUpController.Controller.GetMoreDuration();

                        
                        switch (powerUp.Id)
                        {
                            case "Slowly":
                                PowerUpController.Controller.slowly = true;
                                break;

                            case "Multiplied":
                                PowerUpController.Controller.multiplied = true;
                                break;
                        }
                    }
                }
            }
        }
    }
}
