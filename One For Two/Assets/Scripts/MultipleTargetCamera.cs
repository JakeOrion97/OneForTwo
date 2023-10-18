using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleTargetCamera : MonoBehaviour
{
   public List<Transform> targets; 

   public Vector3 offset;
   private Vector3 velocity; 
   public float smoothTime = .5f;

   public float minZoom = 40f; 
   public float maxZoom = 10f;
   public float zoomLimit = 50f;

   private Camera cam; 

   
   void Start()
   {
       cam = GetComponent<Camera>(); 
   }

   
   void LateUpdate()
   {
    Move(); 
    Zoom(); 
       
   }

   void Zoom(){ 
    float newZoom = Mathf.Lerp(maxZoom, minZoom, GetGreatestDistance()/ zoomLimit);
    cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime); 

   }

   float GetGreatestDistance(){ 
    var bounds = new Bounds( targets[0].position, Vector3.zero); 

    for (int i =0; i < targets.Count; i++){
        bounds.Encapsulate(targets[i].position);
    }

    return bounds.size.x;

   }

   void Move(){
    Vector3 centerPoint = GetCenterPoint();

    Vector3 newPosition = centerPoint + offset; 

    transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity,smoothTime ); 

   }

   Vector3 GetCenterPoint(){

    var bounds = new Bounds (targets[0].position, Vector3.zero); 

    for (int i =0; i < targets.Count; i++){
        bounds.Encapsulate(targets[i].position);
    }
    return bounds.center; 
   }
}
