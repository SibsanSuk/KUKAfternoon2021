********************************
*       VOLUMETRIC LIGHTS      *
*      Created by Kronnect     *   
*          README FILE         *
********************************

Requirements & Setup
--------------------
This version of Volumetric Lights works only with built-in pipeline.


Demo Scene
----------
There's a demo scene which lets you quickly check if Volumetric Lights is working correctly in your project.


Documentation
-------------
Please read the documentation (PDF) for additional instructions and options.


Support
-------
* Support: contact@kronnect.com
* Website-Forum: https://kronnect.com/support
* Twitter: @KronnectGames


Future updates
--------------
All our assets follow an incremental development process by which a few beta releases are published on our support forum (kronnect.com).
We encourage you to signup and engage our forum. The forum is the primary support and feature discussions medium.

Of course, all updates of Volumetric Lights will be eventually available on the Asset Store.


Version history
---------------

v4.4
- New option Shadow Orientation for point lights
- Optimization related to baked shadows for point lights in OnStart mode

v4.3
- Added compatibility with Unity Recorder 360 stereo video capture
- [Fix] Fixed an issue that causes an inspector error when creating a prefab in Unity 2021.1

v4.2
- Added auto-toggle "Time Check Interval" parameter.
- When "Sync With Profile" is enabled, properties in inspector are now readonly
- Using cookie texture no longer requires occlusion cam improving performance

v4.1
- Simplification. It's no longer required to create a volumetric light profile to use the effect.
- Timeline support is now simpler. The VolumetricLightAnimation is no longer used. Instead you can modify directly the VolumetricLight fields.

v4.0
- Added global blur option (check documentation)
- Removed top limit for shadow intensity
- Prefab instances no longer forces unpack
- [Fix] Fixed an issue when creating a volumetric point light in prefab mode

v3.6.5
- Improved compatibility with Unity 2020.3
- Removed a harmeless Editor warning message related to 3D textures
- [Fix] Fixed issue with visibility of area light particles

v3.6.4
- Profile must now created specifically when using volumetric lights in prefabs

v3.6.3
- Improved dust particle rendering

v3.6
- Shadow pass optimization when dust particles are also enabled
- Added support for Timeline/Animation (check documentation to enable this option)
- [Fix] Fixed an issue with occlusion camera being destroyed during a physic event resulting in a console error
- [Fix] Fixed/changed the way spotlights render when angle is >90

v3.5
- Added support for "Colored Cookie Texture" (new option in profile)

v3.4
- Added ability to dim and/or deactivate volumetric effect based on distance. Added "Autotoggle", "Distance Start Dimming" and "Distance Deactivation" properties
- [Fix] Fixed an issue that cause the effect no rendering properly when changing light range at runtime

v3.3
- When duplicating an existing volumetric light, settings are no longer shared unless they use an previously created profile asset
- When creating a Volumetric Fog Profile, the resulting asset is now placed in the current selected folder
- Volumetric area lights can now be linked to directional lights to keep their rotation and color synced
- Material handling optimizations

v3.2
- Helper: volumetric area lights can now be linked to directional lights to keep their rotation and color synced

v3.1
- Added Raymarch Presets which provides reference quality/performance settings
- Improved default settings when adding new volumetric lights to the scene
- [Fix] Fixed dithering issue that could add an halo artifact around certain lights

v3.0.1
- Improved behaviour when instantiated from a prefab

v3.0
- Added support for spot light cookies

v2.5
- Ensures light transform scale is normalized to prevent scaling issues when parent transform is changed
- Reduced shader variants by 1/4

v2.4 11-Sep-2020
- API: added "settings" property to allow modifications of individual lights without affecting a shared profile
- [Fix] Fixed particles not appearing immediately when disabling/reenabling light

v2.3 8-Sep-2020
- Added Shadow Auto Toggle and Shadow Visible Distance to optimize shadow rendering based on light distance to camera
- Added further optimizations for dust particles and shadows when not visible in frustum

v2.2.1 22-Aug-2020
- [Fix] Added workaround for grab pass shaders crashing when enabling Shadow Occlusion option

v2.2 19-Aug-2020
- Added "Raymarching Min Step" parameter which can improve performance
- Added support for orthographic camera

v2.1.4 28-Jun-2020
- Improved fit for rect light shadow map
- Removed "Flip Depth Texture" option as it's no longer needed

v2.1.3 23-Jun-2020
- Particle system user modifications are now preserved

v2.1.2 20-JUN-2020
- Improved bluenoise sampling

v2.1 19-JUN-2020
- Added "Attenuation Mode" option (Simple and Quadratic modes supported with ability to specify quadratic coeficients)
- Added "Blend Mode" : PreMultiply
- Dust Particles: added "Distance Attenuation" and "Auto Toggle" options based on distance
- Improved profile editor UI
- [Fix] Fixed clipping issue on some platforms

v1.5 15-2020
First release, based on Volumetric Lights for URP