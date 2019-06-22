# Advanced Projectile Physics Engine

## What is APPE?

APPE is a currently work-in-progress, fully featured projectile physics engine for the Unity3D game engine.

It's aim is to realistically simulated the trajectory of a projectile using real-world equations.

## What does APPE simulate?


- Gravity

    -- You can use simple gravity (a downward acceleration of 9.81m/s)

    -- The alternative is Advanced Gravity which takes into account the mass of the planet, it's radius, and the distance of the projectile from the surface.

   - The Coriolis Effect
    
    -- The projectile's position is affected by the rotation of the earth. Given the latitute of the projectile's location and the length of one day on the planet, APPE will correctly simulate the path deviation of the projectile due to the spin of the planet.

- Spin Twist

    -- When a projectile leaves the barrel, it exits with a spin to increase the projectile's precision, this however will decrease it's accuracy as it cause the projectile to deviate to the left or right, but will cause the projectile to more reliably land in the same spot.

    -- The spin of a projectile as it leaves the barrel will also affect the path a projectile takes in APPE.

- Drag/Wind

    -- Believe it or not, but drag and wind are the same thing. Drag is where the fluid an object moves through will attempt to cause the object to move at the same speed as the fluid. If the fluid is moving at 5m/s north relative to the ground, it will 'slow down' the object until it is moving at the same speed as the fluid. This way both wind and drag is simulated with just drag.

    -- APPE uses the quadratic drag function, which requires the projectile's velocity relative to the air, the air's density, the projectile's drag coefficient (which is a function of it's velocity), and the projectile's cross sectional area.

    -- The air's density is found by taking into account the altitude of the projectile, the strength of gravity(as this cause the air to be 'squished' more), the temperature at sea level, the temperature lapse rate, and ofcourse the altitude of the projectile.

    -- The drag coefficient of the projectile is found using the MCDRAG program developed by the US Military for simulating the drag of a projectile given it's exact measurements.

    -- The MCDRAG program requires many metrics of the projectile in question that you wish to simulate. These measurements then get passed into the MCDRAG program to generate the drag curve, which is a graph listing the drag coefficient of that projectile given the projectile's MACH speed. We use the velocity of the projectile relative to the speed of sound of the fluid it's travelling through rather than it's true speed. This ensures accurate drag simulation whether the projectile is moving through air or water.

To assist in the setting up of the projectile, a live-render of the projectile is provided as you work on it:

![Projectile data screen](https://drive.google.com/uc?id=1hr94lLvWlTj9hwuidrvRPReJVE0TNI3A "The projectile data screen")

Hitting the *Generate Drag Curve* button below the data options will generate the drag curve. This specific setup generates the following curve:

![The generated drag curve](https://drive.google.com/uc?id=1fmul3i5QsW0hiEe0Fglqi8kbPVrXQorA "The generated drag curve")


