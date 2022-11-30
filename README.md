# FDV-Cameras

1. Add a camera a 2D virtual camera. Assign the camera to the player - so it will follow the movement

    Add confiner to the main background
    
    Viewer size of this camera is just the rocket a small area around
    
    
2. Add another 2D virtual camera. Assign to the enemy - so it will follow the enemy

    Add confiner smaller than the main background (see the video)
    
    Viewer size is the aliens + bigger area around
    
    
3. Add a Camera listener (to the principal camera) and a source (to the planets)

    Select bump as the noise for the shake when collision
    
    IMPORTANT: make sure you have collider and rigidbody in both elements 
    
    Connect listener to source - and the shaky camera should work
  
